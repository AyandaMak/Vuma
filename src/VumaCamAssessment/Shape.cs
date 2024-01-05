using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VumaCamAssessment
{
    //An abstract shape class which inherits from IShape interface for the Open and Closed principle
    public abstract class Shape : IShape
    {
        //CalculateArea function returns the area of a shape.
        public abstract double CalculateArea();
    }
}
