using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class task1
    {
        public void start () {
            Console.Write("the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("third integer: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("interval [1, 24]:");
            if (1 <= num1 && num1 <= 24)
            {
                Console.WriteLine(num1);
            }
            if (1 <= num2 && num2 <= 24)
            {
                Console.WriteLine(num2);
            }
            if (1 <= num3 && num3 <= 24)
            {
                Console.WriteLine(num3);
            }
        }
    }
}
