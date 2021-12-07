int N = int.Parse(Console.ReadLine());
float ans = 0f;
float h = 1f;
for (int i = 1; i <= N; i++)
{
    h *= i;
    ans += 1 / h;
}
Console.WriteLine(ans);