namespace Venti_PageReplacement
{
    partial class MainWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_input_references = new System.Windows.Forms.TextBox();
            this.numericUpDown_of_Frame = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Algorithm = new System.Windows.Forms.ComboBox();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_showFrames = new System.Windows.Forms.Label();
            this.label_showFaults = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_showHits = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_showString = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_showReferences = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_showAlgorithm = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_of_Frame)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Page replacement algorithm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(108, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Frame :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(167, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "References :";
            // 
            // textBox_input_references
            // 
            this.textBox_input_references.Font = new System.Drawing.Font("DB Adman X", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input_references.ForeColor = System.Drawing.Color.Black;
            this.textBox_input_references.Location = new System.Drawing.Point(308, 139);
            this.textBox_input_references.Multiline = true;
            this.textBox_input_references.Name = "textBox_input_references";
            this.textBox_input_references.Size = new System.Drawing.Size(364, 31);
            this.textBox_input_references.TabIndex = 3;
            // 
            // numericUpDown_of_Frame
            // 
            this.numericUpDown_of_Frame.Font = new System.Drawing.Font("DB Adman X", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_of_Frame.Location = new System.Drawing.Point(308, 91);
            this.numericUpDown_of_Frame.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_of_Frame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_of_Frame.Name = "numericUpDown_of_Frame";
            this.numericUpDown_of_Frame.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown_of_Frame.TabIndex = 6;
            this.numericUpDown_of_Frame.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // comboBox_Algorithm
            // 
            this.comboBox_Algorithm.DisplayMember = "1";
            this.comboBox_Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Algorithm.Font = new System.Drawing.Font("DB Adman X", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Algorithm.FormattingEnabled = true;
            this.comboBox_Algorithm.Items.AddRange(new object[] {
            "First in First out (FIFO)",
            "Least recently used (LRU)",
            "Optimal (OPT)"});
            this.comboBox_Algorithm.Location = new System.Drawing.Point(308, 35);
            this.comboBox_Algorithm.Name = "comboBox_Algorithm";
            this.comboBox_Algorithm.Size = new System.Drawing.Size(236, 32);
            this.comboBox_Algorithm.TabIndex = 7;
            // 
            // button_Calculate
            // 
            this.button_Calculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Calculate.Font = new System.Drawing.Font("DB Adman X", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calculate.ForeColor = System.Drawing.Color.White;
            this.button_Calculate.Location = new System.Drawing.Point(197, 213);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(132, 37);
            this.button_Calculate.TabIndex = 8;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = false;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Clear.Font = new System.Drawing.Font("DB Adman X", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(359, 213);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(132, 37);
            this.button_Clear.TabIndex = 9;
            this.button_Clear.Text = "Clear ";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.MainWindows_Load);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Crimson;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Exit.Font = new System.Drawing.Font("DB Adman X", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(540, 592);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(132, 37);
            this.button_Exit.TabIndex = 10;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_showFrames);
            this.panel1.Controls.Add(this.label_showFaults);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label_showHits);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label_showString);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_showReferences);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_showAlgorithm);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(17, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 311);
            this.panel1.TabIndex = 11;
            // 
            // label_showFrames
            // 
            this.label_showFrames.AutoSize = true;
            this.label_showFrames.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_showFrames.ForeColor = System.Drawing.Color.MediumPurple;
            this.label_showFrames.Location = new System.Drawing.Point(182, 52);
            this.label_showFrames.Name = "label_showFrames";
            this.label_showFrames.Size = new System.Drawing.Size(172, 30);
            this.label_showFrames.TabIndex = 37;
            this.label_showFrames.Text = "label_showFrames";
            // 
            // label_showFaults
            // 
            this.label_showFaults.AutoSize = true;
            this.label_showFaults.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_showFaults.ForeColor = System.Drawing.Color.MediumPurple;
            this.label_showFaults.Location = new System.Drawing.Point(182, 245);
            this.label_showFaults.Name = "label_showFaults";
            this.label_showFaults.Size = new System.Drawing.Size(160, 30);
            this.label_showFaults.TabIndex = 41;
            this.label_showFaults.Text = "label_showFaults";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumPurple;
            this.label9.Location = new System.Drawing.Point(13, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 30);
            this.label9.TabIndex = 30;
            this.label9.Text = "Total references :";
            // 
            // label_showHits
            // 
            this.label_showHits.AutoSize = true;
            this.label_showHits.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_showHits.ForeColor = System.Drawing.Color.MediumPurple;
            this.label_showHits.Location = new System.Drawing.Point(182, 215);
            this.label_showHits.Name = "label_showHits";
            this.label_showHits.Size = new System.Drawing.Size(143, 30);
            this.label_showHits.TabIndex = 40;
            this.label_showHits.Text = "label_showHits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumPurple;
            this.label8.Location = new System.Drawing.Point(45, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 30);
            this.label8.TabIndex = 31;
            this.label8.Text = "Total frames :";
            // 
            // label_showString
            // 
            this.label_showString.AutoSize = true;
            this.label_showString.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_showString.ForeColor = System.Drawing.Color.MediumPurple;
            this.label_showString.Location = new System.Drawing.Point(182, 112);
            this.label_showString.Name = "label_showString";
            this.label_showString.Size = new System.Drawing.Size(161, 30);
            this.label_showString.TabIndex = 39;
            this.label_showString.Text = "label_showString";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumPurple;
            this.label7.Location = new System.Drawing.Point(70, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 30);
            this.label7.TabIndex = 32;
            this.label7.Text = "Algorithm :";
            // 
            // label_showReferences
            // 
            this.label_showReferences.AutoSize = true;
            this.label_showReferences.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_showReferences.ForeColor = System.Drawing.Color.MediumPurple;
            this.label_showReferences.Location = new System.Drawing.Point(182, 82);
            this.label_showReferences.Name = "label_showReferences";
            this.label_showReferences.Size = new System.Drawing.Size(205, 30);
            this.label_showReferences.TabIndex = 38;
            this.label_showReferences.Text = "label_showReferences";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(103, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "String :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(121, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 30);
            this.label5.TabIndex = 34;
            this.label5.Text = "Hits :";
            // 
            // label_showAlgorithm
            // 
            this.label_showAlgorithm.AutoSize = true;
            this.label_showAlgorithm.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_showAlgorithm.ForeColor = System.Drawing.Color.MediumPurple;
            this.label_showAlgorithm.Location = new System.Drawing.Point(182, 22);
            this.label_showAlgorithm.Name = "label_showAlgorithm";
            this.label_showAlgorithm.Size = new System.Drawing.Size(194, 30);
            this.label_showAlgorithm.TabIndex = 36;
            this.label_showAlgorithm.Text = "label_showAlgorithm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DB Adman X", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumPurple;
            this.label6.Location = new System.Drawing.Point(104, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 35;
            this.label6.Text = "Faults :";
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(698, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.comboBox_Algorithm);
            this.Controls.Add(this.numericUpDown_of_Frame);
            this.Controls.Add(this.textBox_input_references);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainWindows";
            this.Text = "Page Replacement";
            this.Load += new System.EventHandler(this.MainWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_of_Frame)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_input_references;
        private System.Windows.Forms.NumericUpDown numericUpDown_of_Frame;
        private System.Windows.Forms.ComboBox comboBox_Algorithm;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_showFrames;
        private System.Windows.Forms.Label label_showFaults;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_showHits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_showString;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_showReferences;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_showAlgorithm;
        private System.Windows.Forms.Label label6;
    }
}

