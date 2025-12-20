using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.GraphObjects
{
    public class Point : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x = 0, int y = 0, string color = Shape.Def_color) : base(color)
        {
            X = x;
            Y = y;
        }
        public override Point Draw()
        {
            Console.WriteLine($"Point - X: {this.X}, Y: {this.Y}{this.DrawColor()}");
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
