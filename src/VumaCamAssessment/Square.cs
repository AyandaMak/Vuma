using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VumaCamAssessment
{
    //Square class to declare the diameters required for a Square. Single use principle
    public class Square : Shape
    {
        public int SideLength;

        //Overloaded constructor to pass the value for the Square
        public Square(int sideLength)
        {
            SideLength = sideLength;
        }
        //Function to calculate the area of a Square
        public override double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}
