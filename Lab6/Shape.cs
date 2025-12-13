using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public abstract Shape Draw();
        public const string Def_color = "black";
        public Shape(string color)
        {
            this.Color = color;
        }
        public string DrawColor()
        {
            return $" / color : {this.Color}";
        }
    }
}
