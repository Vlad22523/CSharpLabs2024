using System;

namespace pr2
{

class Program
    {
        static void Main(string[] args)
        {
            var task1 = new task1();
            task1.start();
            var task2 = new task2();
            task2.start();
            var task3 = new task3();
            task3.start();
            var task4 = new task4();
            task4.start();
        }

    }
}  
