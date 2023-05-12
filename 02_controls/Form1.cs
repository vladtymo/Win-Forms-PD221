namespace _02_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowCodeBtnClick(object sender, EventArgs e)
        {
            if (codeTextBox.PasswordChar != '\0')
                codeTextBox.PasswordChar = '\0';
            else
                codeTextBox.PasswordChar = '•';
        }

        private void DarkThemeCheckedChanged(object sender, EventArgs e)
        {
            if (darkCheckBox.Checked)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = Color.Black;
            }
        }

        private void SubmitBtnClick(object sender, EventArgs e)
        {
            string result = "Registration data:\n";

            result += $"Name: {nameTxtBox.Text}\n";
            result += $"Phone: {phoneTxtBox.Text}\n";
            result += $"Code: {codeTextBox.Text}\n";
            result += $"Salary: {salaryNumeric.Value}\n";
            result += $"Date: {datePicker.Value.ToLongDateString()}\n";

            //if (easyRb.Checked)
            //    result += $"Level: Ease\n";
            //else if (mediumRb.Checked)
            //    result += $"Level: Medium\n";
            //else if (hardRb.Checked)
            //    result += $"Level: Hard\n";

            foreach (var rb in levelsPanel.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    result += $"Level: {rb.Text}\n";
                    break;
                }
            }

            result += $"Mode: {groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text ?? "not selected"}\n";

            result += $"Calendar dates: {monthCalendar.SelectionStart.ToShortDateString()} ... {monthCalendar.SelectionEnd.ToShortDateString()}\n";

            MessageBox.Show(result);
        }
    }
}