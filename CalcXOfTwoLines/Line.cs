using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateXOfTwoLines
{
    class Line
    {
        public double ASlope { get; set; }
        public double AYInt { get; set; }
        public double BSlope { get; set; }
        public double BYInt { get; set; }
    }
    class FindX
    {
        public static double XValue()
        {
            double x;
            Line lineA = new Line();
            Line lineB = new Line();

            Console.Write("Enter the Slope of line A: ");
            lineA.ASlope = double.Parse(Console.ReadLine());
            Console.Write("Enter the Y-Intercept of line A: ");
            lineA.AYInt = double.Parse(Console.ReadLine());
            Console.Write("Enter the Slope of line B: ");
            lineB.BSlope = double.Parse(Console.ReadLine());
            Console.Write("Enter the Y-Intercept of line B: ");
            lineB.BYInt = double.Parse(Console.ReadLine());

            if (lineA.ASlope == lineB.BSlope && lineA.AYInt != lineB.BYInt)
            {
                Console.Write("You are trying to determine the value of the x-intercept of the point where the lines intersect for two parallel lines. There is no point of intersect, so x cannot be determined: ");
                x = 0;
                return x;
            }
            else
            {
                x = (lineA.ASlope - lineB.BSlope) / (lineA.AYInt - lineB.BYInt);
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
