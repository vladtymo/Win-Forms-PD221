namespace _09_graphics
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private Point start;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Graphics - contains methods to create graphics objects

            // ways to get Graphics instance
            // 1 - using Create methods

            Graphics g = pictureBox1.CreateGraphics();

            // Draw...() - print figure without filling
            // Fill...() - pring filled figure

            // Pen - contains outline properties
            // Brush - contains filler properties

            g.DrawEllipse(Pens.Teal, 220, 200, 100, 100);
            g.FillEllipse(Brushes.Tomato, 300, 300, 100, 200);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            this.Text = $"Render count: {++count}";

            // 2 - using Paint event
            var g = e.Graphics;

            g.DrawEllipse(Pens.Violet, 370, 200, 100, 100);
            g.FillEllipse(Brushes.YellowGreen, 400, 300, 100, 200);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var g = pictureBox1.CreateGraphics();

            // create size
            Size size = new()
            {
                Width = Math.Abs(e.X - start.X),
                Height = Math.Abs(e.Y - start.Y),
            };

            // normalize start location
            start.X = start.X > e.X ? e.X : start.X;
            start.Y = start.Y > e.Y ? e.Y : start.Y;

            // print rectangle
            Rectangle rectangle = new(start, size);

            g.FillRectangle(Brushes.Green, rectangle);
        }
    }
}