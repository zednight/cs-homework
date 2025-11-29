using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во ворон");
            string crowNumberText = Console.ReadLine();
            string wordCase;
            int crowNumber;
            if(int.TryParse(crowNumberText, out crowNumber))
            {
                if (Convert.ToInt32(crowNumberText) < 0)
                    Console.WriteLine("Кол-во ворон меньше 0");
                else
                {
                    wordCase = crowNumberText switch
                    {
                        string i when i.Length > 1 && i.Substring(i.Length - 2, 1) == "1" => "",
                        string i when i.Substring(i.Length - 1) == "1" => "a",
                        string i when (
                            i.Substring(i.Length - 1) == "2"
                            || i.Substring(i.Length - 1) == "3"
                            || i.Substring(i.Length - 1) == "4"
                        ) => "ы",
                        _ => ""
                    };
                    Console.WriteLine($"На ветке {crowNumberText} ворон{wordCase}");

                }
            }
            else
            {
                Console.WriteLine("Вы ввели не корректное число");
            }

        }
    }
}
