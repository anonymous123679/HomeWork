using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int N = int.Parse(Console.ReadLine());

            float otvet = 0;


            for (float i = 1; N >= i; i++)
            {
                otvet = 1 / i + otvet;
            }
            Console.WriteLine(otvet);
        }
    }
}
