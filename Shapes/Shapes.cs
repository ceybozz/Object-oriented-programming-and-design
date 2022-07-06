using System;

namespace Lektion1
{
    public abstract class Shapes : IShapes
    {   
        /// <summary>
        /// Gets Area
        /// </summary>
        /// <value>Inforamtion returns the Shapes Area</value>
        public virtual double GetArea{get; set;}

        /// <summary>
        /// Gets Circumferenc
        /// </summary>
        /// <value>Inforamtion returns the Shapes Circumferenc</value>
        public virtual double GetCircumferenc{get; set;}

        /// <summary>
        /// Gets Shapes Info
        /// </summary>
        /// <returns>Returns the Shapes values</returns>
        public override string ToString()
        {
            string inforamtion = $"Area = {GetArea}, Circumferenc = {GetCircumferenc}";
            return inforamtion;
        }
    }
}
