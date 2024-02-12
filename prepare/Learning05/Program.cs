using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        
       List<Shape> shape = new List<Shape>
       {
            new Square("Blue", 5),
            new Rectangle("black", 5, 6),
            new Circle("Yellow", 5)
       };

       foreach (Shape shape1 in shape)
       {
        Console.WriteLine($"Color: {shape1.GetColor()}, Area: {shape1.GetArea()}");
       }
    }
}

