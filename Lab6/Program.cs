namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawScene([
                new Point(4, 5, "red"),
                new Line(2, 2, 3, 3, "yellow"),
                new Circle(3, 8, 13, "blue")
            ]);
        }

        public static void DrawScene(Shape[] scene)
        {
            foreach(Shape shape in scene)
            {
                shape.Draw();
            }
        }

    }
}
