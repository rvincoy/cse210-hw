using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square square = new Square("red",5);      
        Rectangle rectangle = new Rectangle("yellow",7,2);
        Circle circle = new Circle("blue",10);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetShapeType() + " color is " + shape.GetColor() + " and the area is " + shape.GetArea() + "."); 
        }
    }
}