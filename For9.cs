int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int answer = 1;
for (int i = A; i <= B; i++)
{
    answer *= i * i;
    Console.WriteLine(answer);
}
