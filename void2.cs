public class Program
{

    public static bool IsEven(int a)
    {
        return (a % 2) == 0;
    }

    static void Main()
    {
        Console.WriteLine(IsEven(3));
    }
}