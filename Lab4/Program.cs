namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            int?[] numbers = new int?[args.Length];
            int sum = 0;
            for (int i = 0; i < args.Length; i++) {
                int tempForCheck;
                if (int.TryParse(args[i], out tempForCheck))
                {
                    numbers[i] = tempForCheck;
                    sum += tempForCheck;
                }
                else
                {
                    numbers[i] = null;
                    Console.WriteLine($"{i + 1} элемент не является числом, значение : '{args[i]}'");
                }
            }
            Console.WriteLine($"Сумма чисело равна: {sum}");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for(int j=0; j< numbers.Length - 1; j++)
            //    {
            //        if ((numbers[j] ?? 0) > (numbers[j + 1] ?? 0))
            //        {
            //            int? temp = numbers[j + 1];
            //            numbers[j + 1] = numbers[j];
            //            numbers[j] = temp;
            //        }
            //    }
            //}
            Array.Sort( numbers );
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write("{0,-6}",numbers[i]==null ? "err" : numbers[i]);
            }
        }
    }
}
