using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 5.0);
        Rectangle rectangle = new Rectangle("blue", 4.0, 6.0);
        Circle circle = new Circle("green", 3.0);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("All shapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.Color}");
            Console.WriteLine($"Shape area: {shape.GetArea()}");
        }
    }
}