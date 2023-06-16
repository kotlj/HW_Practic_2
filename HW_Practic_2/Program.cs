using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_Practic_2
{
    internal class Program
    {
        static void Task3()
        {
            Console.WriteLine("Enter 6-digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (num >= 100000 && num <= 999999)
            {
                result = num % 10 * 100000 + num / 10 % 10 * 10000 + num / 100 % 10 * 1000 + num / 1000 % 10 * 100 +
                    num / 10000 % 10 * 10 + num / 100000;
            }
            Console.WriteLine("Result: " + result);
        }
        static void Task4()
        {
            Console.WriteLine("Enter low border: ");
            int low = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hight border: ");
            int hight = Convert.ToInt32(Console.ReadLine());
            if (low > hight)
            {
                int temp = low;
                low = hight;
                hight = temp;
            }
            int fib0 = 0;
            int fib1 = 1;
            if (fib0 >= low)
            {
                Console.WriteLine(fib0);
                Console.WriteLine(fib1);
            }
            else if (fib1 >= low)
            {
                Console.WriteLine(fib1);
            }
            for (int i = 1; i <= hight; i++)
            {
                if (i == fib0 + fib1)
                {
                    fib0 = fib1;
                    fib1 = i;
                    if (i >= low)
                    {
                        Console.WriteLine(fib1);
                    }
                }
            }
        }
        static void Task5()
        {
            Console.WriteLine("Enter low border: ");
            int low = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hight border: ");
            int hight = Convert.ToInt32(Console.ReadLine());
            if (low > hight)
            {
                int temp = low;
                low = hight;
                hight = temp;
            }
            for (int i = low; i <= hight; i++)
            {
                for(int y = 0; y < i; y++)
                {
                    Console.Write(i);
                }
                Console.Write('\n');
            }
        }
        static void Main(string[] args)
        {
            Task3();
            Task4();
            Task5();
        }
    }
}
