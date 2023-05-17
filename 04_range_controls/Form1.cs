namespace _04_range_controls
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtnClick(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = progressBar1.Minimum;
            timer1.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var step = rand.Next(10);

            if (progressBar1.Value + step <= progressBar1.Maximum)
                progressBar1.Value += step;
            else
            {
                progressBar1.Value = progressBar1.Maximum;
                timer1.Stop();
            }
        }

        private void TrackBarValueChanged(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value / 100.0;
        }

        private void GroupBoxShowChecked(object sender, EventArgs e)
        {
            groupBox1.Visible = checkBox1.Checked;
        }

        private void TimeTimerTick(object sender, EventArgs e)
        {
            timeLabel.Text = $"Time: {DateTime.Now.ToLongTimeString()}";
        }
    }
}