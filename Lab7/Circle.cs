using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab6
{
    public class Circle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                if (value > 0)
                {
                    this.radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Не корректное значение радиуса ({value} меньше или равно 0)");
                }
            }
        }
        public Circle(int x = 0, int y = 0, double radius = 5.0, string color = Shape.Def_color) : base(color)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public override Circle Draw()
        {
            Console.WriteLine($"Circle - X: {this.X}, Y: {this.Y}, Radius : {this.Radius}{this.DrawColor()}");
            return this;
        }
        public Circle MoveBy(int x, int y)
        {
            this.X += x;
            this.Y += y;
            return this;
        }
        public Circle Scale(double scale)
        {
            this.Radius *= scale;
            return this;
        }
    }

}
