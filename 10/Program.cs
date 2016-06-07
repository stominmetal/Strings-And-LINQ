using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstWord = Console.ReadLine().ToCharArray();
            char[] secondWord = Console.ReadLine().ToCharArray();
            int count = 0;

            if (firstWord.Length > secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    for (int j = 0; j < secondWord.Length; j++)
                    {
                        if (secondWord[i] == firstWord[j])
                        {
                            count++;
                        }
                    }
                }
            } else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    for (int j = 0; j < firstWord.Length; j++)
                    {
                        if (firstWord[i] == secondWord[j])
                        {
                            count++;
                        }
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("no");
            }else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
