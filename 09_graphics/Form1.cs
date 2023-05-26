using System.Drawing;
using System.Drawing.Imaging;
using _09_graphics.Shapes;

namespace _09_graphics
{
    public partial class Form1 : Form
    {
        private List<IDrawable> objects = new List<IDrawable>();
        public enum ToolType { Pen, Erase, Rectangle, Line }
        public ToolType SelectedTool { get; private set; }

        private int count = 0;
        private Point start;
        private Bitmap bitmap = null;
        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;

            foreach (var tool in Enum.GetValues<ToolType>())
            {
                toolComboBox.Items.Add(tool);
            }
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

            // TODO: ignore objects which out of Clip Rectangle area

            // redraw all objects
            foreach (var obj in objects)
            {
                obj.Draw(g);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var g = Graphics.FromImage(bitmap); //pictureBox1.CreateGraphics();
            Point end = e.Location;

            IDrawable? shape = null;

            switch (SelectedTool)
            {
                case ToolType.Pen:
                    break;
                case ToolType.Erase:
                    break;
                case ToolType.Rectangle:
                    // create size
                    Size size = new()
                    {
                        Width = Math.Abs(e.X - start.X),
                        Height = Math.Abs(e.Y - start.Y),
                    };

                    // normalize start location
                    start.X = start.X > e.X ? e.X : start.X;
                    start.Y = start.Y > e.Y ? e.Y : start.Y;

                    shape = new MyRectangle(size, start);
                    break;
                case ToolType.Line:
                    shape = new MyLine(start, end);
                    break;
            }

            if (shape != null)
            {
                shape.Draw(g);
                objects.Add(shape);
            }
            pictureBox1.Image = bitmap;
        }

        private void toolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolComboBox.SelectedIndex != -1)
                SelectedTool = (ToolType)toolComboBox.SelectedItem;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("image.jpeg", ImageFormat.Jpeg);
        }
    }
}