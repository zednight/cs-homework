using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab5
{
    internal class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        private double radius;
        public double Radius {
            get=>radius;
            set {
                if (value > 0)
                {
                    this.radius = value; 
                }else
                {
                    throw new ArgumentOutOfRangeException($"Не корректное значение радиуса ({value} меньше или равно 0)");
                }
            }
        }
        public Circle(int x = 0, int y = 0, double radius=5.0)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public Circle Draw(){
            Console.WriteLine($"Circle - X: {this.X}, Y: {this.Y}, Radius : {this.Radius}");
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
