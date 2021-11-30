using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++) Console.WriteLine(i);
                int n = b - a + 1;
                Console.WriteLine(n);
                Console.ReadKey();
            }
        }
}
