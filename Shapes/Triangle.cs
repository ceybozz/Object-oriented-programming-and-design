using System;

namespace Lektion1
{
    public class Triangle : Shapes
    {
        public override double GetArea{get; set;}
        public override double GetCircumferenc{get; set;}

        public double height = 10;

        public override string ToString() => $"{Shapes}, Area is {GetArea}, Circumferenc is {GetCircumferenc}, Height is {height}";

        public string Shapes = "Triangle";
    }
}
