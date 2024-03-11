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
            int[] X = new int[14]; // оголошення масиву X довжиною 14
            int[] Y; // оголошення масиву Y

            // Заповнення масиву X випадковими значеннями (включаючи негативні, позитивні та нуль)
            Random rand = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rand.Next(-100, 101); // випадкове ціле число в діапазоні від -100 до 100
            }

            // Виведення масиву X на екран
            Console.WriteLine("Масив Х:");
            foreach (int num in X)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Введення значення М
            Console.Write("Введіть значення М: ");
            int M = Convert.ToInt32(Console.ReadLine());

            // Формування масиву Y, що містить елементи з X, більші по модулю за М
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

            // Виведення числа М та масиву Y на екран
            Console.WriteLine($"Число М: {M}");
            Console.WriteLine("Масив Y:");
            foreach (int num in Y)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
