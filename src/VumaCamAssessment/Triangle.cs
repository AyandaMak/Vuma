using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VumaCamAssessment
{
    //Triangle class declare the diameters required for a triangle. Single use principle
    public class Triangle : Shape
    {

        public int BaseLength;
        public int Height;

        //Overloaded constructor for the Triangle class to pass the values for the Triangle
        public Triangle(int baseLength, int height)
        {
            BaseLength = baseLength;
            Height = height;
        }
        //Function to calculate the area of a Triangle
        public override double CalculateArea()
        {
            return 0.5 * Height * BaseLength;
        }
    }
}
