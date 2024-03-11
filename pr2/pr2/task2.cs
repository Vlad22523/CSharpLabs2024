using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class task2
    {
        public void start () {
            Console.WriteLine("enter sides of the triangle:");
            Console.Write("side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("side C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Entered side lengths must be greater than 0.");
                return;
            }

            if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
            {
                Console.WriteLine("the triangle does not exist");
                return;
            }

            double perimeter = sideA + sideB + sideC;
            Console.WriteLine($"perimeter: {perimeter}");

            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            Console.WriteLine($"Area: {area}");

            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine("The triangle is equilateral");
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                Console.WriteLine("The triangle is isosceles");
            }
            else
            {
                Console.WriteLine("A triangle is versatile");
            }
        }
    }
}
