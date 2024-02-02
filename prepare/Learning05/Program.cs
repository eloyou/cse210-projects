using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4);
        Circle circle = new Circle("Blue", 3);
        Rectangle rectangle = new Rectangle("Green", 3,5);

        List<Shape> shape = new List<Shape>();
        
        shape.Add(square);
        shape.Add(rectangle);
        shape.Add(circle);

        foreach (Shape s in shape)
        {
            Console.WriteLine($"Color {s.getColor()} Area: {s.GetArea()}" );
        }
    }
}