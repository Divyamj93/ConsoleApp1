using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        //Task 4

        //1.Program to count the number of positive integers and negative integers in an array

        public static int CountPositiveIntegers(int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountNegativeIntegers(int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num < 0)
                {
                    count++;
                }
            }
            return count;
        }

        //2.Search vowels from a given character array

        public static void SearchVowels(char[] character)
        {
            var vowels = character.Where(c => "aeiouAEIOU".Contains(c));
            Console.WriteLine("Vowels found:");
            foreach (var vowel in vowels)
            {
                Console.WriteLine(vowel);
            }
        }

        // 3.Write a program, which reads two arrays from the console and checks whether they are equal
        public static bool EqualArray(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }

            return true;
        }

        //4. Sorting an array means to arrange its elements in an increasing (or decreasing) order
        public static void PrintArray(int[] arr)
        {
            foreach (Object array in arr)
            {
                Console.Write(array + " ");
            }
        }
    }
}
