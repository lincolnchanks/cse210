class Program
{
    static void Main()
    {
        Circle myCircle = new Circle();

        myCircle.SetRadius(10);

        Console.WriteLine(myCircle.GetCircleArea());

        Circle myOtherCircle = new Circle(100);
        Console.WriteLine(myOtherCircle.GetCircleArea());
        Console.WriteLine(myOtherCircle.GetCircumference());
        Console.WriteLine(myOtherCircle.GetDiameter());

        // List is a templated class.
        List<Circle> circles = new List<Circle>();
        circles.Add(myCircle);
        circles.Add(myOtherCircle);

        foreach (Circle c in circles)
        {
            Console.WriteLine(c.GetCircleArea());
        }
    }
}