using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);
        // Console.WriteLine(s1.GetColor());
        // Console.WriteLine(s1.GetArea());

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);
        // Console.WriteLine(s2.GetColor());
        // Console.WriteLine(s2.GetArea());

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);
        // Console.WriteLine(s3.GetColor());
        // Console.WriteLine(s3.GetArea());

        foreach (Shape s in shapes)
        {
           string color = s.GetColor();
           double area = s.GetArea();

           Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}