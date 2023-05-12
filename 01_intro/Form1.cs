using Microsoft.VisualBasic.Devices;
using System.Diagnostics;

namespace _01_intro
{
    public partial class Form1 : Form
    {
        // properties...
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();

            // create new button
            Button myBtn = new Button();
            myBtn.Location = new System.Drawing.Point(761, 492);
            myBtn.Size = new System.Drawing.Size(300, 100);
            myBtn.Text = "Dynamic Created";
            myBtn.UseVisualStyleBackColor = false;

            myBtn.Click += MyBtn_Click;

            this.Controls.Add(myBtn);
        }

        // event handlers...

        private void MyBtn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to close the Window?", 
                                         "Exit?", MessageBoxButtons.YesNo, 
                                         MessageBoxIcon.Question, 
                                         MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // change label properties
            mainLabel.Text += "!";
            mainLabel.ForeColor = Color.Brown;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            mainLabel.ForeColor = Color.Black;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.coordsLabel.Text = $"Cursor position: {e.X} : {e.Y}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = $"Time: {++counter}";
        }
    }
}