using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x=0, int y=0)
        {
            X = x;
            Y = y;
        }
        public Point Draw()
        {
            Console.WriteLine($"Point - X: {this.X}, Y: {this.Y}");
            return this;
        }
        public Point MoveBy(int x, int y)
        {
            this.X += x;
            this.Y += y;
            return this;
        }
    }
}
