using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Shape square = new Square("red", 4.5);
        shapes.Add(square);
        Shape circle = new Circle(2.8, "blue");
        shapes.Add(circle);
        Shape rectangle = new Rectangle("purple", 10.2, 90.3);
        shapes.Add(rectangle);

        Console.WriteLine("These the colors and areas of the shapes in the list: ");

        foreach(Shape shape in shapes){
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}