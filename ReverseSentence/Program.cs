using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            var seq = Console.ReadLine();
            string oldSeq = seq;
            char[] sep = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', ' ' };
            List<string> words = seq.Split(sep, StringSplitOptions.RemoveEmptyEntries).ToList();
            words.Reverse();

            string newString = null;
            int i = 0;
            int index = 0;

            do
            {
                newString = newString + words[index];
                index++;
                while (!(sep.Contains(seq[i])))
                {
                    i++;
                }
                while (sep.Contains(seq[i]))
                {
                    newString = newString + seq[i];
                    i++;
                    if (i >= seq.Length)
                    {
                        break;
                    }
                }
            } while (i < seq.Length);

            Console.WriteLine(newString);
        }
    }
}
