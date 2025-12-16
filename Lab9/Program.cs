using System;
using Lab6;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scene sc = new Scene([
                new Point(4, 5, "red"),
                new Line(2, 2, 3, 3, "yellow"),
                new Circle(3, 8, 13, "blue")
            ]);
            sc.Scale(3);
            sc.DrawScene();
        }
    }
}
