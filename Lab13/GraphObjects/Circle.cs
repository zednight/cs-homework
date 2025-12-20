using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab13.GraphObjects
{
    public class Circle : Shape
    {
        public event Action<Circle, double, double> OnRadiusChanged;
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
                    double oldRadius = this.radius;
                    this.radius = value;
                    OnRadiusChanged?.Invoke(this, this.radius, oldRadius);
                    
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
        public string Info()
        {
            return $"Circle - X: {this.X}, Y: {this.Y}, Radius : {this.Radius}{this.DrawColor()}";
        }
        public override Circle Draw()
        {
            Console.WriteLine(this.Info());
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

        public override bool Equals(object? obj)
        {
            if(obj != null && obj.GetType() == typeof(Circle))
            {
                Circle cir = (Circle)obj;
                return (this.Radius == cir.Radius) && (this.Color == cir.Color);
            }
            return base.Equals(obj);
        }

        public static bool operator ==(Circle c1, Circle c2) => Object.Equals(c1, c2);

        public static bool operator !=(Circle c1, Circle c2) => !Object.Equals(c1, c2);

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Radius.GetHashCode(),this.Color.GetHashCode());
        }

    }

}
