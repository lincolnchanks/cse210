class Program
{
    static void Main()
    {
        Console.WriteLine("Terve Kaikki!");

        Circle myCircle = new Circle();

        myCircle._radius = 10;

        Console.WriteLine(myCircle.GetCircleArea());
    }
}