// See https://aka.ms/new-console-template for more information
float L = 0.1f;
int N;
Console.Write("Enter numbers: ");
N = int.Parse(Console.ReadLine());
for (float kg = 1f; kg > 0; L ++)

{
    Console.WriteLine(N * L);
    if (kg < L)
    {
        Console.ReadKey();
        return;
    }
} 