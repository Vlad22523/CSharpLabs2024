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
            Console.Write("Введіть перше ціле число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть друге ціле число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть третє ціле число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Перевірка умови для кожного числа і вибір чисел, що належать інтервалу [1, 24]
            Console.WriteLine("Цілі числа з заданих, які належать інтервалу [1, 24]:");
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
