using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Lab10.GraphObjects
{
    internal class Scene : IEnumerable
    {
        public Shape[] Shapes {get;set;}
        public Scene(Shape[] shapes)
        {
            this.Shapes = shapes;
        }
        public Scene DrawScene()
        {
            foreach (Shape shape in this)
            {
                shape.Draw();
            }
            return this;
        }
        public Scene Scale(double factor){
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
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Shape shape in this.Shapes)
                yield return shape;
        }

        public Scene Save(string filename)
        {
            string data = JsonConvert.SerializeObject(this.Shapes);
            File.WriteAllText(filename, data);
            Console.WriteLine($"save to file {filename}");
            return this;
        }

        public static Scene Load(string filename)
        {
            JObject[] objects = JsonConvert.DeserializeObject<JObject[]>(
                File.ReadAllText(filename)
            ); // JObject

            Shape[] shapes = new Shape[objects.Length];

            for (int i = 0; i < objects.Length; i++)
            {
                JObject o = objects[i];
                string typeName = "Lab10.GraphObjects." +
                    o.Property("ShapeType").Value.ToString();
                Type t = Type.GetType(typeName);
                shapes[i] = (Shape)o.ToObject(t);
            }
            Console.WriteLine();
            Console.WriteLine($"load from file {filename}");
            return new Scene(shapes);
        }
    }

}
