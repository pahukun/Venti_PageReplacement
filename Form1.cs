using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venti_PageReplacement
{

    // Class ข้างล่างนี้นำมาจาก https://www.youtube.com/channel/UC_eOodxvwS_H7x2uLQa-svw?view_as=subscriber เพื่อนำมาใช้ในการเขียน Log
    public abstract class LogBase
    {
        public abstract void Log(string Messsage);
    }

    public class Logger : LogBase
    {

        private String CurrentDirectory
        {
            get;
            set;
        }

        private String FileName
        {
            get;
            set;
        }

        private String FilePath
        {
            get;
            set;
        }

        public Logger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log.txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;

        }

        public override void Log(string Messsage)
        {

            System.Console.WriteLine("{0}", Messsage);

            using (System.IO.StreamWriter w = System.IO.File.AppendText(this.FilePath))
            {
                w.WriteLine("  {0}", Messsage);

            }
        }
        public void LogTime()
        {
            using (System.IO.StreamWriter w = System.IO.File.AppendText(this.FilePath))
            {
                w.Write("{0} {1}\n", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            }
        }
    }
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        //รูปแบบของ method searching และ predict ศึกษาและนำมาใช้มาจากเว๊บไซต์ https://www.geeksforgeeks.org/optimal-page-replacement-algorithm/ 
        public bool searching(int key, List<int> page)
        {
            for (int i = 0; i < page.Count; i++)
            {
                if (page[i] == key)
                    return true;
            }
            return false;
        }
        public int predict(int[] ref_array, List<int> page, int ref_count, int index)
        {
            int temp = -1, farthest = index;
            for (int i = 0; i < page.Count; i++)
            {
                int j;
                for (j = index; j < ref_count; j++)
                {
                    if (page[i] == ref_array[j])
                    {
                        if (j > farthest)
                        {
                            farthest = j;
                            temp = i;
                        }
                        break;
                    }
                }
                if (j == ref_count)
                {
                    return i;
                }
            }
            return (temp == -1) ? 0 : temp;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //รูปแบบ Algorithm ข้างล่าง ได้ศึกษาและคัดลอกมาดัดแปลงบางส่วนจากเว็บไซต์ https://www.geeksforgeeks.org/ ซึ่งเป็นเว็บรวบรวมบทเรียนและบทความเรื่องการ Coding
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            var logger = new Logger();
            logger.LogTime();

            var algorithm = comboBox_Algorithm.SelectedItem;

            if (algorithm != null && textBox_input_references.Text != "")
            {
                int frames_count = decimal.ToInt32(numericUpDown_of_Frame.Value);
                int[] ref_array = new int[textBox_input_references.Text.Split().Length];

                for (int c = 0; c < textBox_input_references.Text.Split().Length; c++)
                {
                    ref_array[c] = int.Parse(textBox_input_references.Text.Split()[c]);
                }
                int ref_count = ref_array.Count();
                List<string> frameTitle = new List<string>();
                for (int x = 1; x <= frames_count; x++)
                {
                    frameTitle.Add("fr" + x.ToString());
                }
                HashSet<int> page = new HashSet<int>(frames_count);
                int page_fault = 0;
                int page_hit = 0;
                if (comboBox_Algorithm.SelectedIndex == 0) //FIFO
                {
                    logger.Log("Algorithm : " + algorithm.ToString());

                    Queue index = new Queue();

                    for (int i = 0; i < ref_count; i++)
                    {

                        logger.Log("Time " + (i + 1));
                        logger.Log("Reference Number => " + ref_array[i].ToString());
                        if (page.Count < frames_count)
                        {
                            if (!page.Contains(ref_array[i]))
                            {
                                page.Add(ref_array[i]);
                                page_fault += 1;
                                index.Enqueue(ref_array[i]);

                            }
                            else
                            {
                                page_hit += 1;

                            }
                            logger.Log("Fault = " + page_fault);
                            logger.Log("Hit = " + page_hit);
                        }
                        else
                        {
                            if (!page.Contains(ref_array[i]))
                            {
                                int val = (int)index.Peek();
                                index.Dequeue();
                                page.Remove(val);
                                page.Add(ref_array[i]);
                                page_fault += 1;
                                index.Enqueue(ref_array[i]);

                            }
                            else
                            {
                                page_hit += 1;

                            }
                            logger.Log("Fault = " + page_fault);
                            logger.Log("Hit = " + page_hit);
                        }


                        logger.Log(String.Join("\t", frameTitle));
                        logger.Log(String.Join("\t", page));
                        logger.Log("===============================================================================================================");
                    }
                }
                else if (comboBox_Algorithm.SelectedIndex == 1) //LRU
                {
                    logger.Log("Algorithm : " + algorithm.ToString());
                    Dictionary<int, int> index = new Dictionary<int, int>();
                    for (int i = 0; i < ref_count; i++)
                    {
                        logger.Log("Time " + (i + 1));
                        logger.Log("Reference Number => " + ref_array[i].ToString());
                        if (page.Count < frames_count)
                        {
                            if (!page.Contains(ref_array[i]))
                            {
                                page.Add(ref_array[i]);
                                page_fault += 1;

                            }
                            else
                            {
                                page_hit += 1;
                            }
                            if (index.ContainsKey(ref_array[i]))
                                index[ref_array[i]] = i;
                            else
                                index.Add(ref_array[i], i);
                            logger.Log("Fault = " + page_fault);
                            logger.Log("Hit = " + page_hit);
                        }
                        else
                        {
                            if (!page.Contains(ref_array[i]))
                            {
                                int lru = int.MaxValue, val = 0;
                                foreach (int itr in page)
                                {
                                    int temp = itr;
                                    if (index[temp] < lru)
                                    {
                                        lru = index[temp];
                                        val = temp;
                                    }
                                }

                                page.Remove(val);
                                index.Remove(val);
                                page.Add(ref_array[i]);
                                page_fault += 1;

                            }
                            else
                            {
                                page_hit += 1;
                            }
                            if (index.ContainsKey(ref_array[i]))
                            {
                                index[ref_array[i]] = i;
                            }
                            else
                            {
                                index.Add(ref_array[i], i);
                            }
                            logger.Log("Fault = " + page_fault);
                            logger.Log("Hit = " + page_hit);
                        }
                        logger.Log(String.Join("\t", frameTitle));
                        logger.Log(String.Join("\t", page));
                        logger.Log("===============================================================================================================");
                    }

                }
                else //OPT
                {
                    logger.Log("Algorithm : " + algorithm.ToString());
                    List<int> pageList = new List<int>();
                    for (int i = 0; i < ref_count; i++)
                    {
                        logger.Log("Time " + (i + 1));
                        logger.Log("Reference Number => " + ref_array[i].ToString());
                        if (this.searching(ref_array[i], pageList))
                        {
                            page_hit++;
                            logger.Log("Fault = " + page_fault);
                            logger.Log("Hit = " + page_hit);
                            logger.Log(String.Join("\t", frameTitle));
                            logger.Log(String.Join("\t", pageList));
                            logger.Log("===============================================================================================================");
                            continue;
                        }
                        if (pageList.Count < frames_count)
                        {
                            pageList.Add(ref_array[i]);
                            page_fault++;
                        }
                        else
                        {
                            int j = this.predict(ref_array, pageList, ref_count, i + 1);
                            pageList[j] = ref_array[i];
                            page_fault++;


                        }
                        logger.Log("Fault = " + page_fault);
                        logger.Log("Hit = " + page_hit);
                        logger.Log(String.Join("\t", frameTitle));
                        logger.Log(String.Join("\t", pageList));
                        logger.Log("===============================================================================================================");
                    }



                }

                label_showAlgorithm.Text = algorithm.ToString();
                label_showFaults.Text = page_fault.ToString();
                label_showFrames.Text = frames_count.ToString();
                label_showHits.Text = page_hit.ToString();
                label_showReferences.Text = ref_count.ToString();
                label_showString.Text = textBox_input_references.Text;

            }
            else
            {
                logger.Log("Form Incomplete!!");
                MessageBox.Show("Please complete your form", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void MainWindows_Load(object sender, EventArgs e)
        {
            numericUpDown_of_Frame.Value = 4;
            textBox_input_references.Text = "";
            label_showAlgorithm.Text = "";
            label_showFaults.Text = "";
            label_showFrames.Text = "";
            label_showHits.Text = "";
            label_showReferences.Text = "";
            label_showString.Text = "";
        }
    }


}
