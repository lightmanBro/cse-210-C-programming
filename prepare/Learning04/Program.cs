using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Learning04 World!");
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Red",6);
        Rectangle rect = new Rectangle("Blue",12,11);
        Circle circle = new Circle("Orange",23);
        shapes.Add(square);
        shapes.Add(rect);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            // Console.Write(shape);
            Console.WriteLine($"{color} :{area}");
        }
    }
}