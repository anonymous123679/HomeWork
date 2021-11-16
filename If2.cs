using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            int a;
            a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine(a + 1);
            }
            else
            {
                Console.WriteLine(a - 2);
            }
        }
        
    }
}
