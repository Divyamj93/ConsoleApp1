using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public static void NaturalNumbers()
        {
            Console.WriteLine("Enter the natural Numbers");
            int number = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            for (int i = 1; i <= number; i++)
            {
                Sum = Sum + i;
            }
            Console.WriteLine(Sum);
        }
        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter the number for multiplication table");
            int num = Convert.ToInt32(Console.ReadLine());
            int j = 1;
            do
            {
                Console.WriteLine($"{num}*{j} = {num * j}");
                j++;
            }
            while (j <= 12);
        }
        public static void PrimeOrNot()
        {
            Console.WriteLine("Enter the number");
            int prime = Convert.ToInt32(Console.ReadLine());
            int k = 2;
            bool isPrime = true;
            while (k <= prime / 2)
            {
                if (prime % k == 0)
                {
                    isPrime = false;
                    break;
                }
                k++;
            }
            if (isPrime && k > 1)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }

        }
    }
}
