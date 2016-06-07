using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().TrimEnd();
            var text = Console.ReadLine().Split(new char[] { '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < text.Length; i++)
            {
                string temp = string.Copy(text[i]);
                string t = null;

                for (int j = 0; j < temp.Length; j++)
                {
                    if (!(temp[j] >= 'a' && temp[j] <= 'z' || temp[j] >= 'A' && temp[j] <= 'Z'))
                    {
                        temp = temp.Replace(temp[j], ' ');
                    }
                }

                var w = temp.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                for (int j = 0; j < w.Length; j++)
                {
                    if (w[j] == word)
                    {
                        Console.WriteLine(text[i].TrimStart().TrimEnd());
                    }
                }            
            }
        }
    }
}
