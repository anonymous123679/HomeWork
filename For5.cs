// See https://aka.ms/new-console-template for more information
float L = 1;
float N;
int kg;
Console.Write("Enter numbers: ");
N = int.Parse(Console.ReadLine());
if (N < 0)
{

    Console.WriteLine("vi debil");
    return;
}
for (kg = 9; kg > 0; L++)
   
{
    Console.WriteLine(N * L * 0.1);
    if (kg < L)
    {
        Console.ReadKey();
        return;
    }
}