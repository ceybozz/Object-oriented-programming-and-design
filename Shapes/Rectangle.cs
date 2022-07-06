using System;

namespace Lektion1
{
    public class Rectangle : Shapes
    {
        public override double GetArea{get; set;}
        public override double GetCircumferenc{get; set;}

        public double width = 5;

        public override string ToString() => $"{Shapes}, Area is {GetArea}, Circumferenc is {GetCircumferenc}, Width is {width}";
   
        public string Shapes ="Rectangle";
    }
}
