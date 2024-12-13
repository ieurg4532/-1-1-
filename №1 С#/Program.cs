using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y = Pow((cx-a), 1/3)) + lnx/(2sin(π/3+x))");

            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x: "); 
            double x = Convert.ToDouble(Console.ReadLine());

            if (x >= 0) {

                double part1 = Math.Pow(c * x - a, 1.0 / 3.0);
                double part2 = Math.Log(x) / (2 * Math.Sin(Math.PI / 3 + x));

                double y = part1 + part2;

                Console.WriteLine($"Function values f(x) = {y}");
                return;
            }
            else {

                Console.WriteLine("Error: The value of x must be greater than 0 to calculate the logarithm.");
                return;

            }

        }

    }

}