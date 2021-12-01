// See https://aka.ms/new-console-template for more information
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int answer = 0;
for (int i = A; i <= B; i++)
{
    answer += i;
    Console.WriteLine(answer);

}
