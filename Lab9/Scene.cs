using Lab6;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Lab9
{
    internal class Scene : IEnumerable
    {
        public Shape[] Shapes {get;set;}
        public Scene(Shape[] shapes)
        {
            this.Shapes = shapes;
        }
        public void DrawScene()
        {
            foreach (Shape shape in this)
            {
                shape.Draw();
            }
        }
        public void Scale(double factor){
            foreach (Shape shape in this)
            {
                Type x = shape.GetType();
                if (x.GetMethod("Scale") != null)
                {
                    dynamic newShape = Convert.ChangeType(shape, x);
                    newShape.Scale(factor);
                    Console.WriteLine($"{shape.ToString()} - Scaled");
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Shape shape in this.Shapes)
                yield return shape;
        }
    }

}
