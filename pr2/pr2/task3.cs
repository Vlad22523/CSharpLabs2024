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
            int[] X = new int[14]; // оголошення масиву X довжиною 14

            // Заповнення масиву X випадковими значеннями
            Random rand = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rand.Next(1, 101); // випадкове ціле число в діапазоні від 1 до 100
            }

            // Виведення масиву на екран
            Console.WriteLine("Масив Х:");
            foreach (int num in X)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Знаходження мінімального та максимального значень в масиві
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

            // Виведення мінімального та максимального значень на екран
            Console.WriteLine($"Мінімальне значення: {min}");
            Console.WriteLine($"Максимальне значення: {max}");
        }
    }
}
