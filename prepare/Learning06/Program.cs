using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");
        List<Shape> shapes = new List<Shape>();

        Circle circle = new("Red", 2);
        Square square = new("Blue", 5.0);
        Rectangle rect = new Rectangle("Green", 4.0, 5.4);

        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(rect);

        foreach (var shape in shapes)
        {
            System.Console.WriteLine($"Color is: {shape.GetColor()} and area is: {shape.GetArea()}");                       
        }
    }
}