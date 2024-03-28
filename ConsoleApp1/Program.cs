using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void reference(ref string message)
        {
            message = message.ToUpper();
            Console.WriteLine("Value inside the show function " + message);
        }

        public void SumOfDigits(int val)
        {
            string value = val.ToString();
            int total = 0;
            for(int s = 0; s < value.Length; s++)
            {
                total = total+ int.Parse(value[s].ToString());
            }
            Console.WriteLine("Sum of number is " + total);
        }
        static void Main(string[] args)
        {
            //task

            // 1. .Define variable with var and assign different data type values
            var variable1 = 10;
            var variable2 = 3.14;
            var variable3 = "Hello";
            var variable4 = true;
            Console.WriteLine("Data type of variable1: " + variable1.GetType());
            Console.WriteLine("Data type of variable2: " + variable2.GetType());
            Console.WriteLine("Data type of variable3: " + variable3.GetType());
            Console.WriteLine("Data type of variable4: " + variable4.GetType());

            //2. Accept 3 numbers

            Console.WriteLine("Enter three numbers:");

            Console.WriteLine("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int greatest = num1;
            if (num2 > greatest)
            {
                greatest = num2;
            }
            if (num3 > greatest)
            {
                greatest = num3;
            }

            Console.WriteLine($"The greatest number is: {greatest}");

            //3.Accept an alphabet and print whether it is vowel or not.(use switch...case)

            Console.WriteLine("Enter an alphabet:");
            char alphabet = Console.ReadLine().ToLower()[0];

            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine("The entered alphabet is a vowel.");
                    break;
                case 'e':
                    Console.WriteLine("The entered alphabet is a vowel.");
                    break;
                case 'i':
                    Console.WriteLine("The entered alphabet is a vowel.");
                    break;
                case 'o':
                    Console.WriteLine("The entered alphabet is a vowel.");
                    break;
                case 'u':
                    Console.WriteLine("The entered alphabet is a vowel.");
                    break;
                default:
                    Console.WriteLine("The entered alphabet is not a vowel.");
                    break;
            }

            //Task 2

            //1. find the sum of the first n natural numbers

            Class1.NaturalNumbers();

            //2. check given number is prime or not using while loop

            Class1.PrimeOrNot();

            //3.print the multiplication table of a given number using do....while

            Class1.MultiplicationTable();

            // Task 3

            //1. Define a function which takes reference string variable as an argument and convert it to upper case

            string name ="divya";
            Program program = new Program();
            Console.WriteLine("Value before calling the function " + name);
            program.reference(ref name);
            Console.WriteLine("Value after calling the function " + name);

            //2.Write a function to display sum of digits

            int val = 5678;
            Program program1 = new Program();
            program1.SumOfDigits(val);

            Console.ReadLine();
        }
    }
}
