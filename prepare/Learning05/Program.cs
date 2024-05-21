using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 5);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("yellow", 10, 15);
        shapes.Add(rectangle);
        
        Circle circle = new Circle("orange", 7);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The shape has a color of {color} and an area of {area}");
        }

    }
}