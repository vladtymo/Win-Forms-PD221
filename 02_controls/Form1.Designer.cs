namespace _02_controls
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bioTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.importantCb = new System.Windows.Forms.CheckBox();
            this.darkCheckBox = new System.Windows.Forms.CheckBox();
            this.easyRb = new System.Windows.Forms.RadioButton();
            this.mediumRb = new System.Windows.Forms.RadioButton();
            this.hardRb = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fastRb = new System.Windows.Forms.RadioButton();
            this.slowRb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.levelsPanel = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.levelsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(452, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Form";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(161, 187);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(439, 39);
            this.nameTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bio:";
            // 
            // bioTxtBox
            // 
            this.bioTxtBox.Location = new System.Drawing.Point(809, 190);
            this.bioTxtBox.Multiline = true;
            this.bioTxtBox.Name = "bioTxtBox";
            this.bioTxtBox.Size = new System.Drawing.Size(447, 167);
            this.bioTxtBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salary:";
            // 
            // salaryNumeric
            // 
            this.salaryNumeric.DecimalPlaces = 1;
            this.salaryNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.salaryNumeric.Location = new System.Drawing.Point(161, 268);
            this.salaryNumeric.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.salaryNumeric.Name = "salaryNumeric";
            this.salaryNumeric.Size = new System.Drawing.Size(439, 39);
            this.salaryNumeric.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone:";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(156, 603);
            this.phoneTxtBox.Mask = "+38(\\000) 000-0000";
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(447, 39);
            this.phoneTxtBox.TabIndex = 10;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(161, 352);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(439, 39);
            this.datePicker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 697);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(156, 697);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '•';
            this.codeTextBox.Size = new System.Drawing.Size(310, 39);
            this.codeTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 697);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowCodeBtnClick);
            // 
            // importantCb
            // 
            this.importantCb.AutoSize = true;
            this.importantCb.Location = new System.Drawing.Point(280, 806);
            this.importantCb.Name = "importantCb";
            this.importantCb.Size = new System.Drawing.Size(151, 36);
            this.importantCb.TabIndex = 16;
            this.importantCb.Text = "Important";
            this.importantCb.UseVisualStyleBackColor = true;
            // 
            // darkCheckBox
            // 
            this.darkCheckBox.AutoSize = true;
            this.darkCheckBox.Location = new System.Drawing.Point(1222, 62);
            this.darkCheckBox.Name = "darkCheckBox";
            this.darkCheckBox.Size = new System.Drawing.Size(176, 36);
            this.darkCheckBox.TabIndex = 17;
            this.darkCheckBox.Text = "Dark Theme";
            this.darkCheckBox.UseVisualStyleBackColor = true;
            this.darkCheckBox.CheckedChanged += new System.EventHandler(this.DarkThemeCheckedChanged);
            // 
            // easyRb
            // 
            this.easyRb.AutoSize = true;
            this.easyRb.Location = new System.Drawing.Point(13, 34);
            this.easyRb.Name = "easyRb";
            this.easyRb.Size = new System.Drawing.Size(91, 36);
            this.easyRb.TabIndex = 18;
            this.easyRb.TabStop = true;
            this.easyRb.Text = "Easy";
            this.easyRb.UseVisualStyleBackColor = true;
            // 
            // mediumRb
            // 
            this.mediumRb.AutoSize = true;
            this.mediumRb.Location = new System.Drawing.Point(150, 36);
            this.mediumRb.Name = "mediumRb";
            this.mediumRb.Size = new System.Drawing.Size(135, 36);
            this.mediumRb.TabIndex = 19;
            this.mediumRb.TabStop = true;
            this.mediumRb.Text = "Medium";
            this.mediumRb.UseVisualStyleBackColor = true;
            // 
            // hardRb
            // 
            this.hardRb.AutoSize = true;
            this.hardRb.Location = new System.Drawing.Point(330, 36);
            this.hardRb.Name = "hardRb";
            this.hardRb.Size = new System.Drawing.Size(96, 36);
            this.hardRb.TabIndex = 20;
            this.hardRb.TabStop = true;
            this.hardRb.Text = "Hard";
            this.hardRb.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Level:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 25;
            // 
            // fastRb
            // 
            this.fastRb.AutoSize = true;
            this.fastRb.Location = new System.Drawing.Point(280, 62);
            this.fastRb.Name = "fastRb";
            this.fastRb.Size = new System.Drawing.Size(86, 36);
            this.fastRb.TabIndex = 23;
            this.fastRb.TabStop = true;
            this.fastRb.Text = "Fast";
            this.fastRb.UseVisualStyleBackColor = true;
            // 
            // slowRb
            // 
            this.slowRb.AutoSize = true;
            this.slowRb.Location = new System.Drawing.Point(90, 62);
            this.slowRb.Name = "slowRb";
            this.slowRb.Size = new System.Drawing.Size(95, 36);
            this.slowRb.TabIndex = 22;
            this.slowRb.Text = "Slow";
            this.slowRb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fastRb);
            this.groupBox1.Controls.Add(this.slowRb);
            this.groupBox1.Location = new System.Drawing.Point(805, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 140);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Mode";
            // 
            // levelsPanel
            // 
            this.levelsPanel.Controls.Add(this.mediumRb);
            this.levelsPanel.Controls.Add(this.easyRb);
            this.levelsPanel.Controls.Add(this.hardRb);
            this.levelsPanel.Location = new System.Drawing.Point(157, 429);
            this.levelsPanel.Name = "levelsPanel";
            this.levelsPanel.Size = new System.Drawing.Size(439, 104);
            this.levelsPanel.TabIndex = 27;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(809, 587);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 917);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 82);
            this.button2.TabIndex = 29;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SubmitBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 1055);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.levelsPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.darkCheckBox);
            this.Controls.Add(this.importantCb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salaryNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bioTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.levelsPanel.ResumeLayout(false);
            this.levelsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nameTxtBox;
        private Label label2;
        private Label label3;
        private TextBox bioTxtBox;
        private Label label4;
        private NumericUpDown salaryNumeric;
        private Label label5;
        private MaskedTextBox phoneTxtBox;
        private DateTimePicker datePicker;
        private Label label6;
        private Label label7;
        private TextBox codeTextBox;
        private Button button1;
        private CheckBox importantCb;
        private CheckBox darkCheckBox;
        private RadioButton easyRb;
        private RadioButton mediumRb;
        private RadioButton hardRb;
        private Label label8;
        private Label label9;
        private RadioButton fastRb;
        private RadioButton slowRb;
        private GroupBox groupBox1;
        private Panel levelsPanel;
        private MonthCalendar monthCalendar;
        private Button button2;
    }
}