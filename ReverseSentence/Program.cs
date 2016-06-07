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
            string seq = Console.ReadLine();
            char[] sep = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', ' ' };
            List<string> words = seq.Split(sep, StringSplitOptions.RemoveEmptyEntries).ToList();
            words.Reverse();

            string newString = null;
            int i = 0, index = 0;

            do
            {
                newString += words[index++];
                while (!(sep.Contains(seq[i]))) i++;
                while (i < seq.Length && sep.Contains(seq[i])) newString += seq[i++];
            } while (i < seq.Length);

            Console.WriteLine(newString);
        }
    }
}
