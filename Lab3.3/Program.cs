using QuadraticEquationResult = (double? x1, double? x2, bool HasRoots, bool IsSingleRoot);

namespace Lab3._3
{
    internal class Program
    {
        public static QuadraticEquationResult SolutionOfQuadraticEquation (double a, double b, double c){
            double d = (b * b) - (4 * a * c);
            if (d > 0)
            {
                return (
                    (-b + Math.Sqrt(d)) / (2 * a),
                    (-b - Math.Sqrt(d)) / (2 * a),
                    true,
                    false
                );
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                return (x, x, true, true);
            }
            else//d<0
            {
                return (null, null, false, false);
            }
            return (4,2,false,false);
        }
        public static void ShowQuadraticEquationSolution(QuadraticEquationResult data){
            if (!data.HasRoots)
                Console.WriteLine("Нет решения, нет корней");
            else
                if(data.IsSingleRoot)
                    Console.WriteLine($"Один корень : {data.x1}");
                else
                    Console.WriteLine($"Два корня : {data.x1} и {data.x2}");

        }
        static void Main(string[] args)
        {
            ShowQuadraticEquationSolution(SolutionOfQuadraticEquation(1,-6,9));
            ShowQuadraticEquationSolution(SolutionOfQuadraticEquation(1,-5,6));
            ShowQuadraticEquationSolution(SolutionOfQuadraticEquation(1,1,1));
        }
    }
}
