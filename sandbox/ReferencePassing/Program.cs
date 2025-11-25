class Program
{
    static void PassByReference(ref int x)
    {
        // This changes the actual value of x in the rest of the code/memory.
        // Instead of creating a copy of the variable x, this function references
        // the original x and changes it.
        x = 9999;
        Console.WriteLine($"In the reference function, x is: {x}");
    }
    static void PassByValue(int x)
    {
        // When x is passed into the function another chunk of memory is created
        // with x's value. Thereby this is a duplicate of x and when it is changed
        // here, x-prime (the original x) is not changed.
        x = 1001;
        Console.WriteLine($"In the function, x is: {x}.");
    }
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

        PassByValue(x);
        Console.WriteLine($"In Main, x is: {x}.");

        PassByReference(ref x);
        Console.WriteLine($"In Main, x is: {x}.");
    }
}