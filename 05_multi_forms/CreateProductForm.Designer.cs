namespace _05_multi_forms
{
    partial class CreateProductForm
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
            label2 = new Label();
            nameBox = new TextBox();
            label1 = new Label();
            priceNumeric = new NumericUpDown();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)priceNumeric).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 124);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 5;
            label2.Text = "Name:";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(106, 121);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(298, 31);
            nameBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 200);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 6;
            label1.Text = "Price:";
            // 
            // priceNumeric
            // 
            priceNumeric.Location = new Point(106, 198);
            priceNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            priceNumeric.Name = "priceNumeric";
            priceNumeric.Size = new Size(298, 31);
            priceNumeric.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 34);
            label3.Name = "label3";
            label3.Size = new Size(305, 45);
            label3.TabIndex = 8;
            label3.Text = "Create New Product";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(241, 304);
            button1.Name = "button1";
            button1.Size = new Size(163, 49);
            button1.TabIndex = 9;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateBtnClick;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(47, 304);
            button2.Name = "button2";
            button2.Size = new Size(163, 49);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CloseBtnClick;
            // 
            // CreateProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 406);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(priceNumeric);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Name = "CreateProductForm";
            Text = "Create Product Form";
            ((System.ComponentModel.ISupportInitialize)priceNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox nameBox;
        private Label label1;
        private NumericUpDown priceNumeric;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}