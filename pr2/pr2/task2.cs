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
            Console.WriteLine("Введіть довжини сторін трикутника:");
            Console.Write("Сторона A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            // Перевірка на коректність введених даних
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Введені довжини сторін повинні бути більшими за 0.");
                return;
            }

            // Перевірка на дійсність трикутника за теоремою про нерівність сторін
            if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
            {
                Console.WriteLine("Трикутник з такими сторонами не існує.");
                return;
            }

            // Обчислення периметру трикутника
            double perimeter = sideA + sideB + sideC;
            Console.WriteLine($"Периметр трикутника: {perimeter}");

            // Обчислення площі трикутника за формулою Герона
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            Console.WriteLine($"Площа трикутника: {area}");

            // Визначення виду трикутника
            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine("Трикутник є рівностороннім.");
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                Console.WriteLine("Трикутник є рівнобедреним.");
            }
            else
            {
                Console.WriteLine("Трикутник є різностороннім.");
            }
        }
    }
}
