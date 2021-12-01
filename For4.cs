// See https://aka.ms/new-console-template for more information
int L = 1;
int N;
int kg;
Console.Write("Enter numbers: ");
N = int.Parse(Console.ReadLine());
for (kg = 9; kg > 0; L++)

{
    Console.WriteLine(N * L);
    if (kg < L)
    {
        Console.ReadKey();
        return;
    }
            