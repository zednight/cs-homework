using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Lab8
{
    internal class Program
    {
        public static int Factorial(int n)
        {
            int s = 1;
            for (int i = 1; i<=n; i++)
            {
                s = checked(s * i);
            }
            return s;
        }
        static BigInteger FactorialBigInt(int n)
        {
            BigInteger r = 1;
            checked
            {
                for (int k = 1; k <= n; k++)
                    r *= k;
            }
            return r;

        }
        static void Main(string[] args)
        {
            for(int i = 0; i<50; i++)
            {
                try
                {
                    Console.WriteLine($"{i}! = {Factorial(i)}");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine($"Переполнено значение int на шаге {i}");
                    break;
                }
            }
            try
            {
                Console.WriteLine($"{1000}! = {FactorialBigInt(1000)}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Что там за ошибка? {e.ToString()}");
            }
        }
    }
}
