class Circle
{
    public double _radius;

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetCircleArea()
    {
        return 3.141592653589 * _radius;
    }
}