namespace Lab3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 1;
            while(j < 1000)
            {
                Console.WriteLine(j);
                j += i;
                i = j - i;
            }
        }
    }
}
