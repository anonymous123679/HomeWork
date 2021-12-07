public class Program
{

    public static int Power(int n, int m)
    {
        return (int)Math.Pow(n, m);
    }

    static void Main()
    {
        Console.WriteLine(Power(3, 10));
    }
}