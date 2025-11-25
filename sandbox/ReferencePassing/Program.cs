class Program
{
    static void PassReferenceType(int[] data)
    {
        // This function passes in something that is already a reference type (string, array, etc.).
        // So you don't have to use the ref keyword.
        data[3] = 12345;
        Console.WriteLine($"In the Reference Type function, data[3] is: {data[3]}.");
    }
    static void PassByOut(out int a)
    {
        // This is the exact same as ref, but you force the function to initialize a value.

        // Because you used the out keyword, this function *must* initialize the value of a.
        // This creates a contract in the code, much like an abstract class requiring its
        // method to be implemented by its child classes.

        // This changes the value of the integer even outside the function, just like in PassByReference.
        a = 17;
        Console.WriteLine($"In the Out function, a is: {a}.");
    }
    static void PassByReference(ref int x)
    {
        // This changes the actual value of x in the rest of the code/memory.
        // Instead of creating a copy of the variable x, this function references
        // the original x and changes it.

        // If you ever are passing a value and *really* want to change it when it gets passed
        // instead of returning it, the ref keyword is your go-to.
        x = 9999;
        Console.WriteLine($"In the reference function, x is: {x}.");
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

        int z;
        PassByOut(out z);
        // With this you can force your function to do all your initialization for you.
        Console.WriteLine($"In Main, z is: {z}.");

        PassReferenceType(a);
        foreach(int i in a)
        {
            Console.WriteLine($"In Main, i is: {i}.");
        }
    }
}