class Circle
{
    private double _radius; // Now that _radius is private, it's only usable inside this class.

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetCircleArea()
    {
        return 3.141592653589 * _radius;
    }
}