namespace _05_multi_forms
{
    partial class Parent
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
            label1 = new Label();
            button1 = new Button();
            loginTxtBox = new TextBox();
            label2 = new Label();
            productListBox = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(388, 26);
            label1.Name = "label1";
            label1.Size = new Size(238, 54);
            label1.TabIndex = 0;
            label1.Text = "Parent Form";
            // 
            // button1
            // 
            button1.Location = new Point(97, 235);
            button1.Name = "button1";
            button1.Size = new Size(212, 65);
            button1.TabIndex = 1;
            button1.Text = "Open Child Forms";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OpenChildFormBtnClick;
            // 
            // loginTxtBox
            // 
            loginTxtBox.Location = new Point(163, 135);
            loginTxtBox.Name = "loginTxtBox";
            loginTxtBox.Size = new Size(298, 31);
            loginTxtBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 138);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 3;
            label2.Text = "Login:";
            // 
            // productListBox
            // 
            productListBox.FormattingEnabled = true;
            productListBox.ItemHeight = 25;
            productListBox.Location = new Point(588, 135);
            productListBox.Name = "productListBox";
            productListBox.Size = new Size(381, 254);
            productListBox.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(588, 398);
            button2.Name = "button2";
            button2.Size = new Size(172, 40);
            button2.TabIndex = 5;
            button2.Text = "Add New Product";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddProductBtnClick;
            // 
            // Parent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 450);
            Controls.Add(button2);
            Controls.Add(productListBox);
            Controls.Add(label2);
            Controls.Add(loginTxtBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Parent";
            Text = "Parent Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox loginTxtBox;
        private Label label2;
        private ListBox productListBox;
        private Button button2;
    }
}