using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;
            double sum = 0;
            double sum1;
            for (double i = a; i <= b; i++)
            {
                sum = (sum + i);
            }
            sum1 = sum / (b - a + 1);

            Console.WriteLine("Среднее арифметическое чисел от 10 до 20:");
            Console.WriteLine(sum1);
            Console.ReadLine();
        }

    }
}
