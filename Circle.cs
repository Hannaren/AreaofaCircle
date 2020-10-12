using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AreaofCircleStudio
{
    public class Circle
    {
        public static double GetArea(double radius)
        {
            double area = Math.Pow(radius, 2) * Math.PI;
            return area;
        }
        public static double GetDiameter(double radius)
        {
            double diameter = 2 * radius;
            return diameter;
        }

        public static double GetCircumference(double radius)
        {
            double diameter = 2 * radius;
            double circumference = diameter * Math.PI;
            return circumference;
        }
    }
}
