using Lab10.GraphObjects;

namespace Lab10
{
    internal class Program
    {
        const string saveFileName = @"..\..\..\result\scene.json";
        const string loadFileName = @"..\..\..\result\scene.json";
        static void Main(string[] args)
        {
            Scene sc = new Scene([
                new Point(4, 5, "red"),
                new Line(2, 2, 3, 3, "yellow"),
                new Circle(3, 8, 13, "blue")
            ]);
            sc
                .Scale(3)
                .DrawScene()
                .Save(saveFileName);

            Scene sc2 = Scene.Load(loadFileName);
            sc2.DrawScene();
        }
    }
}
