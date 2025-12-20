using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.GraphObjects
{
    public abstract class Shape
    {
        public string ShapeType { get; init; }
        public string Color { get; set; }
        public abstract Shape Draw();
        public const string Def_color = "black";
        public Shape(string color)
        {
            this.Color = color;
            ShapeType = this.GetType().Name;
        }
        public string DrawColor()
        {
            return $" / color : {this.Color}";
        }
    }
}
