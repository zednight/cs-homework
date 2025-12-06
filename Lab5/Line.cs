using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    internal class Line
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Line(int x1 = 0, int y1 = 0, int x2 = 1, int y2 = 0)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
        public Line Draw()
        {
            Console.WriteLine($"Line - X1: {this.X1}, Y1: {this.Y1}, X2: {this.X2}, Y2: {this.Y2}");
            return this;
        }
        public Line MoveBy(int x, int y)
        {
            this.X1 += x;
            this.Y1 += y;
            this.X2 += x;
            this.Y2 += y;
            return this;
        }
    }
}
