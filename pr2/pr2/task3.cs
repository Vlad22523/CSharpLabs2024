using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class task3
    {

        public void start () {
            int[] X = new int[14]; 

            Random rand = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rand.Next(1, 101); 
            }

            Console.WriteLine("massif Х:");
            foreach (int num in X)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int min = X[0];
            int max = X[0];
            for (int i = 1; i < X.Length; i++)
            {
                if (X[i] < min)
                {
                    min = X[i];
                }
                if (X[i] > max)
                {
                    max = X[i];
                }
            }

            Console.WriteLine($"min: {min}");
            Console.WriteLine($"max: {max}");
        }
    }
}
