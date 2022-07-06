using System;

namespace Lektion1
{
    public class Circle : Shapes
    {
        public override double GetArea{get; set;}

        public override double GetCircumferenc{get; set;}

        public double radie = 2;

        public override string ToString() => $"{Shapes}, Area is {GetArea}, Circumferenc is {GetCircumferenc}, Radie is {radie}";

        public string Shapes = "Cirlce";
    }
}
