using System;
using System.Threading;

namespace AreaofCircleStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius: ");

            double radius = double.Parse(Console.ReadLine());
            double area = Circle.GetArea(radius);
            Console.WriteLine("The area of the circle is: " + area);

            double diameter = Circle.GetDiameter(radius);
            double circumference = Circle.GetCircumference(radius);
            Console.WriteLine("The circumference of the circle is: " + circumference +'\n' + "The diameter of the circle is: " + diameter);

            Console.WriteLine("How many miles can your car travel per gallon? ");
            double mpg = double.Parse(Console.ReadLine());
            double gallonsNeeded = circumference / mpg;
            Console.WriteLine("You will need " + gallonsNeeded + " gallons to travel the circumference of the circle.");
        }
    }
}
