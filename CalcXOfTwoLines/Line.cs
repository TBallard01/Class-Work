using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateXOfTwoLines
{
    class Line
    {
        public double Slope { get; set; }
        public double YInt { get; set; }
    }
    class FindX
    {
        public static double XValue()
        {
            double x;
            Line lineA = new Line();
            Line lineB = new Line();

            Console.Write("Enter the Slope of line A: ");
            lineA.Slope = double.Parse(Console.ReadLine());
            Console.Write("Enter the Y-Intercept of line A: ");
            lineA.YInt = double.Parse(Console.ReadLine());
            Console.Write("Enter the Slope of line B: ");
            lineB.Slope = double.Parse(Console.ReadLine());
            Console.Write("Enter the Y-Intercept of line B: ");
            lineB.YInt = double.Parse(Console.ReadLine());

            if (lineA.Slope == lineB.Slope)
            {
                Console.Write("You are trying to determine the value of the x-intercept of the point where the lines intersect for two parallel lines. There is no point of intersect, so x cannot be determined: ");
                x = 0;
                return x;
            }
            if (lineA.Slope == lineB.Slope && lineA.YInt == lineB.YInt)
            {
                Console.Write("You are trying to determine the value of the x-intercept of the point where the lines intersect for two of the same lines. There is no point of intersect, so x cannot be determined: ");
                x = 0;
                return x;
            }
            else
            {
                x = (lineB.YInt - lineA.YInt) / (lineB.Slope - lineA.Slope);
                Console.Write("X equals: ");
                return x;
            }        
        }
        static void Main(string[] args)
        {
            Console.WriteLine(XValue());
            Console.ReadKey();
        }
    }   
}
