using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        //Task 5

        //1.Check whether a string is palindrome or not

        public static bool Ispalindrome(string val)
        {
            string[] str = val.Split(',');
            foreach (string value in str)
            {
                if (!IsWordPalindrome(value.Trim()))
                    return false;
            }
            return true;
        }
        public static bool IsWordPalindrome(string word)
        {
            word = word.ToLower();
            int first = 0;
            int last = word.Length - 1;
            while (first < last)
            {
                if (word[first] != word[last])
                {
                    return false;
                }
                first++;
                last--;
            }
            return true;
        }
        //3.Pgm to count the number of words in a sentance.

        public static int CountWords(string sentence)
        {
            int wordCount = 0;
            bool word = false;
            foreach(char count in sentence)
            {
                if (!char.IsWhiteSpace(count))
                {
                    word = true;
                }
                else
                {
                    wordCount++;
                    word = false;
                }
            }
            if (word)
            {
                wordCount++;
            }
            return wordCount;
        }
    }
}
