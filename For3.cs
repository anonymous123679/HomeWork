using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = b - 1; i > a; i--)
                Console.WriteLine(i);
            Console.WriteLine(b - a - 1);
        }
    }
}
