using Lab13.GraphObjects;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scene sc = new Scene();
            Circle c1 = new Circle(3, 8, 13, "blue");
            Circle c2 = new Circle(4, 6, 13, "blue");
            Circle c3 = new Circle(2, 8, 13, "Yellow");
            Circle c4 = new Circle(6, 7, 9, "blue");

            c1.OnRadiusChanged += (c1, oldValue, newValue) =>
            {
                Console.WriteLine($"Изменен радиус с {oldValue} на {newValue}");
                Console.WriteLine("Перерисовываем окружность");
                c1.Draw();
            };

            c1.Radius = 6.4;


        }
    }
}
