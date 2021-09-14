using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class LineCompare
    {
        static void Main(string[] args)
        {
            // UC-1: To calculate the length of the line between the given endpoints
            // Taking inputs
            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            // Calculating line length
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            // Displaying line length
            Console.WriteLine("Length of the line = {0} units", length);
            Console.ReadLine();
        }
    }
}
