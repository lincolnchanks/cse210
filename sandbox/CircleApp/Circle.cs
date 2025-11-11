class Circle
{
    private double _radius; // Now that _radius is private, it's only usable inside this class.
    // Keep **all of your data** private!
    // If someone needs access to it, make access methods so they can access them ON YOUR TERMS.
    public Circle() // These should set the attributes to initial values.
    {
        _radius = 10;
    }
    public Circle(double radius)
    {
        this.SetRadius(radius);

        // if (radius < 0)
        // {
        //     Console.WriteLine("Invalid radius. Setting radius to 0.");
        //     _radius = 0;
        // }
        // else
        // {
        //     _radius = radius;
        // }
    }

    public void SetRadius(double radius)
    {
        // SetRadius allows the user to set the radius, but now it must be set according to
        // your standards. This keeps the data from being set to something invalid.
        if (radius < 0)
        {
            Console.WriteLine("Invalid raidus, must be >= 0.0");
            _radius = 0;
        }
        else
        {
            _radius = radius;
        }
    }

    public double GetCircleArea()
    {
        return 3.141592653589 * _radius;
    }
}