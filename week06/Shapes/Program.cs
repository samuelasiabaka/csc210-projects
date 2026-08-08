using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle("Red", 5);

        Rectangle rectangle = new Rectangle("Blue", 4, 6);

        Square square = new Square("Green", 3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} has an area of {shape.GetArea()}");
        }
    }
}