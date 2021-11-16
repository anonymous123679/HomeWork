using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            int a = int.Parse(Console.ReadLine());
            int ones = a % 10;
            int decates = a / 10 % 10;
            int hundreads = a / 100;




            Console.WriteLine(ones != decates && decates != hundreads);
        }
        
    }
}
