using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_четных_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            string namefirst = Console.ReadLine();
            var numberfirst = int.Parse(namefirst);

            Console.Write("Введите число: ");
            string namesec = Console.ReadLine();
            var numbersec = int.Parse(namesec);

            int sum = 0;
            for (int i = numberfirst; i <= numbersec; i++)
            {
                if (i % 2 == 0) 

                sum += i;
            }

            Console.WriteLine("Сумма четных от {0} до {1} : {2}", namefirst, namesec, sum);
            Console.ReadKey();
        }
    }
}
