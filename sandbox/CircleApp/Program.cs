class Program
{
    static void Main()
    {
        Console.WriteLine("Terve Kaikki!");

        Circle myCircle = new Circle();

        // myCircle._radius = 10; <-- This does not work because _radius is now private, as **all data should be**.
        myCircle.SetRadius(10);

        Console.WriteLine(myCircle.GetCircleArea());

        Circle myOtherCircle = new Circle(100);
        Console.WriteLine(myOtherCircle.GetCircleArea());
    }
}