namespace _09_graphics.Shapes
{
    public class MyLine : IDrawable
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public Pen Pen { get; set; }
        public MyLine(Point start, Point end, Pen? pen = null)
        {
            Start = start;
            End = end;
            Pen = pen ?? Pens.Black;
        }
        public void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, Start, End);
        }
    }
}