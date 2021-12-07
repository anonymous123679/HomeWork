int N = int.Parse(Console.ReadLine());
float help = 0f;
float ans = 0f;
for (int i = 0; i < N; i++)
{
     help += 0.1f;
    ans += N * help; 
}
Console.WriteLine(ans);
