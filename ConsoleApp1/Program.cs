using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Members;
using Task7a;
using Task7b;
using Task7c;
using Abstract;
using Interfaces;

namespace ConsoleApp1
{
    //class Employee with fields id,name,email,department
    public class Employee
    {
        private int id;
        private string name;
        private string email;
        private string department;

        //the fields using private modifier and define getter and setter methods
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Department { get => department; set => department = value; }

        //constructor and create object of employee
        public Employee(int id, string name, string email, string department)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.department = department;
        }
    }
    public class Program
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
      public static void Main(string[] args)
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

            // Task 4

            //1.Program to count the number of positive integers and negative integers in an array

            Console.WriteLine("Enter the size of the array:");
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            Console.WriteLine("Enter the array values:");
            for (int i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int positiveCount = Class2.CountPositiveIntegers(array);
            int negativeCount = Class2.CountNegativeIntegers(array);

            Console.WriteLine($"Number of positive integers: {positiveCount}");
            Console.WriteLine($"Number of negative integers: {negativeCount}");

            //2.Search vowels from a given character array

            char[] vowels = { 'a', 'b', 'c', 'd', 'e', 'f', 'i', 'l' };
            Class2.SearchVowels(vowels);

            // 3.Write a program, which reads two arrays from the console and checks whether they are equal

            Console.WriteLine("\nEnter the size of the arrays:");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            int[] b = new int[size];
            Console.WriteLine("Enter the first array:");
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the second array:");
            for (int i = 0; i < size; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            bool equal = Class2.EqualArray(a, b);
            if (equal)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            //4. Sorting an array means to arrange its elements in an increasing (or decreasing) order

            int[] arr = { 8, 2, 4, 9, 3, 5, 1 };
            Array.Sort(arr);
            Console.WriteLine("Array sorting in asc order");
            Class2.PrintArray(arr);
            Array.Reverse(arr);
            Console.WriteLine("\nArray sorting in desc order");
            Class2.PrintArray(arr);

            //Task 5 

            //1.Check whether a string is palindrome or not 

            string value = "radar,level,madam,amma,appa";
            bool Palindrome = Class3.Ispalindrome(value);
            if (Palindrome)
            {
                Console.WriteLine("\nstring is palindrome");
            }
            else
            {
                Console.WriteLine("\nstring is not palindrome");
            }

            //2.Find the unique characters in a string(This can be done using HashSet class from Collection)

            string s1 = "Hello unique character string";
            HashSet<char> uniqueChars = new HashSet<char>();
            char[] ch = s1.ToCharArray();
            foreach (char c in ch)
            {
                if (!uniqueChars.Contains(c))
                {
                    uniqueChars.Add(c);
                }
                
            }
            foreach(char c in uniqueChars)
            {
                Console.WriteLine(c);
            }

            //3.Pgm to count the number of words in a sentance

            string sentence = "\nHai, Welcome to dotnet lets enjoy";
            int wordCount = Class3.CountWords(sentence);
            Console.WriteLine(wordCount);

            //Task 6

            // Define a class Employee with fields id,name,email,department
            Class4.search();
            Employee emp = new Employee(25, "Divya", "divyamj@xminds.com", "CSE");
            Console.WriteLine("Employee Id : " + emp.Id);
            Console.WriteLine("Employee Name : " + emp.Name);
            Console.WriteLine("Employee Email : " + emp.Email);
            Console.WriteLine("Employee Department : " + emp.Department);

            //Task 7

            //7a.Define a class Person with some fields and method display and show

            Person person = new Person("Manju",20,"Trivandrum","Female");
            person.Display();

            //7b.Define display method as virtual method and override it inside Employee

            Employee1 emp1 = new Employee1("Saranya", 25, "Kollam", "Female", "Chinakada", "Kerala");
            emp1.Display();

            //7c.Reimplement show method using new keyword inside Employee

            Employee2 emp2 = new Employee2("Raj", 20, "Trivandrum", "Female", "eedede", "Kerala");
            emp2.Display();

            //Task 8

            SavingsAccount svc = new SavingsAccount("SBI2233098898988", "Anu", 20000);
            svc.Deposit(5000);
            svc.Withdraw(2000);
            svc.AddInterest();
            CurrentAccount cvc = new CurrentAccount("SBI22330988984563", "Anju", 30000,10000);
            cvc.Deposit(8000);
            cvc.Withdraw(2000);

            Console.WriteLine("\nSavings Account Balance:");
            svc.DisplayBalance();

            Console.WriteLine("\nCurrent Account Balance:");
            cvc.DisplayBalance();

            //Task 9

            Logger lg = new Logger();

            lg.Log("Error occurred!");
            lg.Log("ClassName", "MethodName", "Error occurred in method!");
            lg.Log("ClassName", "Error occurred in class!");
            lg.Log("ClassName", "MethodName", DateTime.Now, "Error occurred at specific time!");

            //Task 10

            MobileAuthenticationInterface mai;

            mai= new FaceRecognitionAuthentication();
            bool isFaceAuthenticated = mai.authenticate();
            Console.WriteLine("Face Recognition Authentication Result: " + isFaceAuthenticated);
            mai = new FingerPrintAuthentication();
            bool isFingerAuthenticated = mai.authenticate();
            Console.WriteLine("Finger Recognition Authentication Result: " + isFingerAuthenticated);
            mai = new PasswordAuthentication();
            bool isPasswordAuthenticated = mai.authenticate();
            Console.WriteLine("Password Recognition Authentication Result: " + isPasswordAuthenticated);

            //Task 11

            // Write a program which will take as input two numbers and display the quotient as o / p
            // by handling the division by zero exception and number format exceptiontry{
            try
            {
                Console.WriteLine("Enter the first number");
                string n1 = Console.ReadLine();
                double number1 = double.Parse(n1);
                Console.WriteLine("Enter the second number");
                string n2 = Console.ReadLine();
                double number2 = double.Parse(n2);

                if (number2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero");
                }
                double quotient = number1 / number2;
                Console.WriteLine("Quotient: " + quotient);
            }catch(FormatException e)
            {
                Console.WriteLine("Error : " + e.Message);
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("Error : " + e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}