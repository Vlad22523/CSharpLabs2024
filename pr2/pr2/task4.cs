using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class task4
    {

        public void start()
        {
            int[] X = new int[14]; 
            int[] Y; 

            Random rand = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rand.Next(-100, 101);
            }

            Console.WriteLine("massif Х:");
            foreach (int num in X)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.Write("Enter value: ");
            int M = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            foreach (int num in X)
            {
                if (Math.Abs(num) > M)
                {
                    count++;
                }
            }

            Y = new int[count];
            int index = 0;
            foreach (int num in X)
            {
                if (Math.Abs(num) > M)
                {
                    Y[index] = num;
                    index++;
                }
            }

            Console.WriteLine($"number М: {M}");
            Console.WriteLine("massif Y:");
            foreach (int num in Y)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
