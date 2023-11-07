using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> LhShapes = new List<Shape>();

        Square LhSquare = new Square(3, "Red");
        LhShapes.Add(LhSquare);

        Circle LhCircle = new Circle(3, "Blue");
        LhShapes.Add(LhCircle);

        Rectangle LhRectangle = new Rectangle(3, 4, "Green");
        LhShapes.Add(LhRectangle);

        foreach (Shape LhShape in LhShapes)
        {
            string LhColor = LhShape.GetColor();
            double LhArea = LhShape.GetArea();
            Console.WriteLine($"The shape is {LhColor} and has an area of {LhArea}.");
        }
    }
}