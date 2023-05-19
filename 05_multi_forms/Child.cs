using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_multi_forms
{
    public partial class Child : Form
    {
        public string Login { get; set; } 
        public Child(string? login = null)
        {
            InitializeComponent();

            Login = login ?? "annonymous";
            ShowGreeting();
        }

        public void Show(Color backColor)
        {
            this.BackColor = backColor;
            Show();
        }
        public void ShowGreeting()
        {
            this.Text = $"Hello, dear {Login}";
        }
        private void CloseBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
