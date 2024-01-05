using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VumaCamAssessment
{
    //Circle class to declare the diameters required for a circle. Single use principle
    public class Circle : Shape
    {
        public int Radius;

        //Overloaded constructor to pass the value for the Circle
        public Circle(int radius)
        {
            Radius = radius;
        }
        //Function to calculate the area of a Circle
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
