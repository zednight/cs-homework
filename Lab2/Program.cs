namespace Lab2
{
    enum Shapes
    {
        Point,
        Circle,
        Line
    }
    struct Point{
        public float x;
        public float y;
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"Point : (x:{this.x}, y:{this.y})";
        }
    }
    struct Circle
    {
        public Point center;
        public float radius;
        public Circle(float x, float y, float radius)
        {
            this.center = new(x, y);
            this.radius = radius;
        }
        public override string ToString()
        {
            return $"Circle : (center: (x:{this.center.x}, y:{this.center.y});radius: {this.radius})";
        }
    }
    struct Line
    {
        public Point dot1;
        public Point dot2;
        public Line(float x1, float y1, float x2, float y2)
        {
            this.dot1 = new Point(x1, y1);
            this.dot2 = new Point(x2, y2);
        }
        public override string ToString() => $"Line: (start: {this.dot1.ToString()}; end: {this.dot2.ToString()})";

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new(6,7);
            Console.WriteLine(point);
            Circle circle = new(6, 7, 7.5f);
            Console.WriteLine(circle);
            Line line = new Line(8.2f, 5.4f, 7.5f, 3f);
            Console.WriteLine(line);
        }
    }
}
