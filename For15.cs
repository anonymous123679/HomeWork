int A = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

int ans = 1;
for (int i = 0; i < N; i++)
{
    ans *= A;
}
Console.WriteLine(ans);
