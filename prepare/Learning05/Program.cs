using System;

class Program
{
    static void Main(string[] args)
    {

    
    List<Shape> shapes = new List<Shape>();


    Square s1 = new Square("green", 3);
    shapes.Add(s1);

    Rectangle s2 = new Rectangle("red", 3, 4);
    shapes.Add(s2);




    foreach (Shape i in shapes)
    {
        string color = i.GetColor();

        double area = i.GetArea();

        Console.WriteLine($"Shape color: {color} \\ Shape Area: {area}.");
    }
    }

}


