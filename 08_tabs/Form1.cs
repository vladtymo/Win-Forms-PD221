namespace _08_tabs
{
    public partial class Form1 : Form
    {
        public TextBox SelectedTextBox
        {
            get
            {
                return tabControl1.SelectedTab.Controls.OfType<TextBox>().First();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void NewTabBtnClick(object sender, EventArgs e)
        {
            string name = $"Page {tabControl1.TabPages.Count + 1}";

            var tabTextBox = new TextBox()
            {
                Location = new Point(448, 245),
                Multiline = true,
                Size = new Size(554, 143),
                TabIndex = 1
            };

            var tabBtn = new Button()
            {
                Location = new Point(585, 441),
                Size = new Size(284, 70),
                TabIndex = 2,
                Text = "Show Message",
                UseVisualStyleBackColor = true
            };
            tabBtn.Click += (sender, args) =>
            {
                MessageBox.Show(tabTextBox.Text);
            };
            //tabBtn.Click += ShowMessageBtnClick;

            var tabLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(598, 116),
                Size = new Size(271, 78),
                TabIndex = 0,
                Text = $"{name} Body!"
            };

            var newTab = new TabPage(name)
            {
                Location = new Point(8, 46),
                Padding = new Padding(3),
                Size = new Size(1439, 716),
                TabIndex = 0,
                UseVisualStyleBackColor = true
            };
            newTab.Controls.Add(tabBtn);
            newTab.Controls.Add(tabTextBox);
            newTab.Controls.Add(tabLabel);

            tabControl1.TabPages.Add(newTab);
        }

        private void ShowMessageBtnClick(object sender, EventArgs e)
        {
            MessageBox.Show(SelectedTextBox.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
        }
    }
}