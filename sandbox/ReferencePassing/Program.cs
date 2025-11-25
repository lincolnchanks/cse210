class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("I'm not happy Bob. Not happy.");

        int x = 10;
        int y = x;
        y++;
        Console.WriteLine($"{x} {y}");

        int[] a = {1, 2, 3, 4, 5, 6};
        int[] b = a;

        b[3] = 111;
        Console.WriteLine($"{a[3]}, {b[3]}");
    }
}