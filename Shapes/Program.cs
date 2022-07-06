using System;

namespace Lektion1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrerar metodanrop till metod på basklassen från instansen av subklass
            
            Triangle triangle = new Triangle() {GetArea=15, GetCircumferenc=10};
            Circle circle = new Circle(){GetArea=50, GetCircumferenc=40};
            Rectangle rectangle = new Rectangle(){GetArea=35, GetCircumferenc=20};
            
            // Prints
            Console.WriteLine(triangle.ToString());
            Console.WriteLine(circle.ToString());
            Console.WriteLine(rectangle.ToString());
        }
    }
}
