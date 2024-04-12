using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Members;
using Task7a;
using Task7b;
using Task7c;
using Abstract;
using Interfaces;
using Form;

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
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

            //Task 12

            // Create object of class user.If any of the fields are not valid a custom exception InvalidDataException should be thrown.

            try
            {
                User user = new User(1, "Divya", "divya@gmail.com", "9837677623");
                Console.WriteLine("User created successfully");
            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            //Task 13

            //ArrayList Assignment
            List<User1> users = new List<User1>();

            // Create user objects and add them to the list

            users.Add(new User1(1, "Raki"));
            users.Add(new User1(2, "Manju"));
            users.Add(new User1(3, "Chinju"));

            // Display properties of each user
            foreach (User1 user in users)
            {
                Console.WriteLine(user.ToString());
            }
            //Create a Queue and add objects of user

            Queue<User1> userQueue = new Queue<User1>();
            userQueue.Enqueue(new User1(1, "Dinesh"));
            userQueue.Enqueue(new User1(2, "Deepak"));
            userQueue.Enqueue(new User1(3, "Divya"));

            while (userQueue.Count > 0)
            {
                User1 user = userQueue.Dequeue();
                Console.WriteLine(user.ToString());
            }

            // Task 14

            // Create a Dictionary which contains book and author as key value pair

            Dictionary<string, string> bookDictionary = new Dictionary<string, string>();
            bookDictionary.Add("Author1", "Book1");
            bookDictionary.Add("Author2", "Book2");
            bookDictionary.Add("Author3", "Book3");
            foreach (var pair in bookDictionary)
            {
                Console.WriteLine($"Book: {pair.Value}, Author: {pair.Key}");
            }
            string book = "Book2";
            string author = "Author1";

            if (bookDictionary.ContainsValue(book))
            {
                Console.WriteLine($"The dictionary contains the {book}");
            }
            else
            {
                Console.WriteLine($"This dictionary not having the {book}");
            }
            if (bookDictionary.ContainsKey(author))
            {
                Console.WriteLine($"The dictionary contains the {author}");
            }
            else
            {
                Console.WriteLine($"This dictionary not having the {author}");
            }
            Parallel.ForEach(bookDictionary, pair =>
            {
                Console.WriteLine($"Book: {pair.Value}, Author: {pair.Key}");
            });

            //Task 15

            //Create a HashTable with country and capital as key value pair

            Hashtable hashvalue = new Hashtable();
            hashvalue.Add("Afghanistan", "Kabul");
            hashvalue.Add("Albania", "Tirana");
            hashvalue.Add("Algeria", "Algiers");
            hashvalue.Add("Andorra", "Andorra la Vella");

            string check = "Algeria";
            if (hashvalue.ContainsKey(check))
            {
                Console.WriteLine($"{check} country is available in this hash");
            }
            else
            {
                Console.WriteLine($"{check} is not available");
            }
            string check1 = "Tirana";

            if (hashvalue.ContainsValue(check1))
            {
                Console.WriteLine($"{check1} capital is available in this hash");
            }
            else
            {
                Console.WriteLine($"{check1} is not available");
            }
            string remove = "Albania";

            if (hashvalue.ContainsKey(remove))
            {
                hashvalue.Remove(remove);
                Console.WriteLine($"{remove} is removed from hash");
            }
            else
            {
                Console.WriteLine("not removed");
            }

            string update = "Algiers";

            if (hashvalue.ContainsKey(update))
            {
                hashvalue[update] = "Kabul (Updated)";
                Console.WriteLine("Capital can be updated");
            }
            else
            {
                Console.WriteLine("capital not updated");
            }
            foreach (DictionaryEntry entry in hashvalue)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            //Task 16

            // Create a stack and add some names to it.

            Stack<string> nameStack = new Stack<string>();
            nameStack.Push("dinesh");
            nameStack.Push("deepak");
            nameStack.Push("divya");
            Console.WriteLine("Stack elements after adding:");
            foreach (var names in nameStack)
            {
                Console.WriteLine(names);
            }
            string topName = nameStack.Peek();
            Console.WriteLine($"\nTop element of the stack (Peek): {topName}");

            Console.WriteLine("\nPop elements from the stack:");
            while (nameStack.Count > 0)
            {
                string poppedName = nameStack.Pop();
                Console.WriteLine(poppedName);
            }
            Console.ReadLine();

            //Task 17

            //1.Create a file test.txt add some content and save it

            FileStream f = new FileStream("C:\\Users\\Xminds\\text.txt", FileMode.Create);
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes("FileStream insert");
            f.Write(bytes, 0, bytes.Length);
            f.Close();
            Console.WriteLine("Content created successfully...");

            //Task 18

            //2.Read the content of a file and display it in the console.

            FileStream f1 = new FileStream("C:\\Users\\Xminds\\text.txt", FileMode.OpenOrCreate);
            int n = 0;
            while ((n = f1.ReadByte()) != -1)
            {
                Console.Write((char)n);
            }

            f1.Close();

            //Task 19

            //1.Create a file  write the user i/p data to the newly created file.

            Console.WriteLine("\nEnter the user input");
            string values = Console.ReadLine();
            FileStream f2 = new FileStream("C:\\Users\\Xminds\\userText.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f2);
            sw.WriteLine(values);
            sw.Close();
            f2.Close();
            Console.WriteLine("User Input Created Successfully...");

            //Task 20

            //2.Using StreamReader read the content of a file and print it in the console.
            FileStream f3 = new FileStream("C:\\Users\\Xminds\\userText.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f3);
            string data = sr.ReadToEnd();
            Console.WriteLine(data);
            sr.Close();
            f3.Close();
            //Task 21

            int[] numbers = { 9, 2, 6, 8, 15, 3, 7, 18, 4, 1 };

            var result = from number in numbers
                         where number % 3 == 0
                         select (number);
            foreach(var res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}