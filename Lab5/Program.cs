namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(6, 7);
            point
                .MoveBy(4,3)
                .Draw();
            Line line = new Line(0, 0, 2, 2);
            line
                .MoveBy(4, 3)
                .Draw();
            Circle circle = new Circle(0, 0, 7.0);
            circle
                .MoveBy(4, 3)
                .Scale(2)
                .Draw();
        }
    }
}
