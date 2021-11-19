using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int N = int.Parse(Console.ReadLine());

            int otvet = 0;


            for (int i = 1; N >= i; i++)
            {
                otvet = (N + i) * (N + i) + otvet;
            }
            Console.WriteLine(otvet + N * N + ((2 * N) * (2 * N)));


        }
    }
}
