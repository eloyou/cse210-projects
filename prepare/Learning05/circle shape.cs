using System;

public class Circle : Shape
{
    private double _raduis;

   
    public Circle(string color, double radius) : base(color)
    {
        base.setColor(color);
        _raduis = radius;
    }
    
    public override double GetArea()
    {
        double areaCircle = Math.PI * Math.Pow(_raduis,2);
        return areaCircle;
    }
}