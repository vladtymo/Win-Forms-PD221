namespace _03_list_controls
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
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cityComboBox
            // 
            this.cityComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cityComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Lviv",
            "Kyiv",
            "Kharkiv",
            "Lutsk",
            "Rivne",
            "Obariv",
            "Kolodenka",
            "Oleksin"});
            this.cityComboBox.Location = new System.Drawing.Point(252, 94);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(445, 40);
            this.cityComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your city:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(633, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CityShowBtnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(633, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UserShowBtnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select current user:";
            // 
            // usersComboBox
            // 
            this.usersComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.usersComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Items.AddRange(new object[] {
            "Lviv",
            "Kyiv",
            "Kharkiv",
            "Lutsk",
            "Rivne",
            "Obariv",
            "Kolodenka",
            "Oleksin"});
            this.usersComboBox.Location = new System.Drawing.Point(288, 367);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(409, 40);
            this.usersComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(317, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cities";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(317, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "Users";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(298, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RemoveUserBtnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 533);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(307, 46);
            this.button4.TabIndex = 9;
            this.button4.Text = "Add New";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Black",
            "White",
            "Yellow",
            "Gray",
            "Cyan",
            "Pink"});
            this.listBox1.Location = new System.Drawing.Point(819, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(268, 452);
            this.listBox1.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(819, 543);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(268, 46);
            this.button5.TabIndex = 11;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ListBoxItemsShowBtnClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1138, 536);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(268, 46);
            this.button6.TabIndex = 13;
            this.button6.Text = "Show";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.CheckedListBoxShowBtnClick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Black",
            "White",
            "Yellow",
            "Gray",
            "Cyan",
            "Pink"});
            this.checkedListBox1.Location = new System.Drawing.Point(1138, 63);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(268, 436);
            this.checkedListBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 651);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cityComboBox;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private ComboBox usersComboBox;
        private Label label3;
        private Label label4;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Button button5;
        private Button button6;
        private CheckedListBox checkedListBox1;
    }
}