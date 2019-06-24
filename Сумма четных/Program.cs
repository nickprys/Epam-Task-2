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

            Console.Write("Введите число: ");
            string namesec = Console.ReadLine();
            var numbersec = int.Parse(namesec);
            int sum = 0;

            for (int i = 0; i <= numbersec; i = i + 2)
            {

                sum += i;

            }
            Console.Write("Сумма четных чисел от 0 до {0} :  {1}", namesec, sum);
            Console.ReadLine();
        }


    }
}

