namespace _09_graphics.Shapes
{
    public class MyRectangle : IDrawable
    {
        public Size Size { get; set; }
        public Point Location { get; set; }
        public Brush Brush { get; set; }
        public MyRectangle(Size size, Point location, Brush? brush = null)
        {
            Size = size;
            Location = location;
            Brush = brush ?? Brushes.Green;
        }
        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brush, Location.X, Location.Y, Size.Width, Size.Height);
        }
    }
}