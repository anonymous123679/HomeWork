// See https://aka.ms/new-console-template for more information
float L = 0;
int N;
float kg;
Console.Write("Enter numbers: ");
N = int.Parse(Console.ReadLine());
for (kg = 1.2f; kg < 2.1; kg += 0.2f, L++)

{
    Console.WriteLine(kg * N);
    if (L == 4)
    {
        Console.ReadKey();
        return;
    }
}