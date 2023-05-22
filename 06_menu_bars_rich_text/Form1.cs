namespace _06_menu_bars_rich_text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening a file...");
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (darkThemeBtn.Checked)
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

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(fontToolStripMenuItem.Font.FontFamily, float.Parse(toolStripTextBox2.Text), FontStyle.Regular);
        }
    }
}