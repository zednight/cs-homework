using Lab12.GraphObjects;

namespace Lab12
{
    internal class Program
    {
        const string saveFileName = @"..\..\..\result\scene.json";
        const string loadFileName = @"..\..\..\result\scene.json";
        static void Main(string[] args)
        {
            Scene sc = new Scene();
            Circle c1 = new Circle(3, 8, 13, "blue");
            Circle c2 = new Circle(4, 6, 13, "blue");
            Circle c3 = new Circle(2, 8, 13, "Yellow");
            Circle c4 = new Circle(6, 7, 9, "blue");

            sc
                .Add([
                    new Point(4, 5, "red"),
                    new Line(2, 2, 3, 3, "yellow"),
                ])
                .Add(c1)
                .Add(c2)
                .Add(c3)
                .Add(c4);
                //.Scale(3)
                //.DrawScene();
                //.Save(saveFileName)
                //.Clear()
                //.DrawScene("after clear");

            Console.WriteLine($"{c1.Info()} ===> {(c1 == c2 ? "Equals" : "Not equals")} <=== {c2.Info()}");
            Console.WriteLine($"{c1.Info()} ===> {(c1 == c3 ? "Equals" : "Not equals")} <=== {c3.Info()}");
            Console.WriteLine($"{c1.Info()} ===> {(c1 == c4 ? "Equals" : "Not equals")} <=== {c4.Info()}");
            if (c1 == c2)
                Console.WriteLine("c1==c2");
            else
                Console.WriteLine("c1!=c2");
            if (c1 == c3)
                Console.WriteLine("c1==c3");
            else
                Console.WriteLine("c1!=c3");
            //Scene sc2 = Scene.Load(loadFileName);
            //sc2.DrawScene("draw sc2");
        }
    }
}
