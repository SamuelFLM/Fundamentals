internal class Program
{
    private static void Main(string[] args)
    {
        Somar(1, 1);
        int num = Subtrair(2, 1);

        Console.WriteLine(num);
    }
    private static void Somar(int x, int y)
    {
        Console.WriteLine(x + y);
    }

    private static int Subtrair(int x, int y){
        return x - y;
    }
}