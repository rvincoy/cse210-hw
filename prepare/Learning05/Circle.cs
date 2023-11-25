public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius) : base(color)
    {
        _radius=radius;
    }
    public override double GetArea()
    {
        double pi=3.14;
        return _radius*_radius*pi;
    }
    public override string GetShapeType()
    {
        return "Circle";
    }
}