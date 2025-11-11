class Program
{
    static void Main()
    {
        Console.WriteLine("Terve Kaikki!");

        Circle myCircle = new Circle();

        // myCircle._radius = 10;
        myCircle.SetRadius(10);

        Console.WriteLine(myCircle.GetCircleArea());

        Circle myOtherCircle = new Circle(100);
        Console.WriteLine(myOtherCircle.GetCircleArea());
    }
}