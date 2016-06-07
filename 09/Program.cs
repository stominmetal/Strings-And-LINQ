using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (CheckIsPalindrome(word))
            {
                Console.WriteLine(-1);
            } else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    //word = word.Remove(i,1);
                    if (CheckIsPalindrome(word.Remove(i, 1)))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }

        private static bool CheckIsPalindrome(string word)
        {
            return (new string(word.Reverse().ToArray()) == word);
        }
    }
}
