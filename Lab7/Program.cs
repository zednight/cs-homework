using System.Reflection;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (Type t in assembly.GetTypes())
            {
                Console.WriteLine($"{t.Name}  '{t.FullName}' Class: {t.IsClass}");
                Console.WriteLine("Properties:");
                PropertyInfo[] props = t.GetProperties();
                if (props.Length==0)
                    Console.WriteLine($"no properties");
                foreach (PropertyInfo prop in props)
                    Console.WriteLine($"\t{prop.PropertyType.Name} {prop.Name}, type: {prop.PropertyType}");
                Console.WriteLine("Methods:");
                MethodInfo[] meths = t.GetMethods();
                if (meths.Length==0)
                    Console.WriteLine($"no methods");
                foreach (MethodInfo meth in meths)
                    Console.WriteLine($"\t{meth.ReturnType.Name} {meth.Name}");
                Console.WriteLine("\r\n");
            }
        }

        public static void DrawScene(Shape[] scene)
        {
            foreach(Shape shape in scene)
            {
                shape.Draw();
            }
        }

    }
}
