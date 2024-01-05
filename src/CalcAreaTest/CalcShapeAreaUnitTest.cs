using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VumaCamAssessment;

namespace CalcAreaTest
{
    [TestClass]
    public class CalcShapeAreaUnitTest
    {
        //Unit Test method to calculate the area of a Square
        [TestMethod]
        public void TestCalculateSquareArea()
        {
          Square square = new Square(4);
          double squareArea = square.CalculateArea();
          Assert.AreEqual(16, squareArea);
        }
        //Unit Test method to calculate the area of a Circle
        [TestMethod]
        public void TestCalculateCircleArea()
        {
            Circle circle = new Circle(4);
            double circleArea = circle.CalculateArea();
            Assert.AreEqual(50,27, circleArea); //If the unit test fails it could be due to regional settings of the server.
        }
        //Unit Test method to calculate the area of a Triangle
        [TestMethod]
        public void TestCalculateTriangleArea()
        {
            Triangle triangle = new Triangle(4,4);
            double triangleAngle = triangle.CalculateArea();
            Assert.AreEqual(8, triangleAngle);
        }
    }
}
