using Lab11.GraphObjects;

namespace Lab11
{
    internal class Program
    {
        const string saveFileName = @"..\..\..\result\scene.json";
        const string loadFileName = @"..\..\..\result\scene.json";
        static void Main(string[] args)
        {
            Scene sc = new Scene();

            sc
                .Add([
                    new Point(4, 5, "red"),
                    new Line(2, 2, 3, 3, "yellow"),
                    new Circle(3, 8, 13, "blue")
                ])
                .Scale(3)
                .DrawScene("before clear")
                //.Save(saveFileName)
                .Clear()
                .DrawScene("after clear");

            Scene sc2 = Scene.Load(loadFileName);
            sc2.DrawScene("draw sc2");
        }
    }
}
