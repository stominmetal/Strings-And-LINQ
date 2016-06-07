using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
         {
            char[] separators = new char[] {'.', ',', '?', '!', ';', ' ', ':', '-', '_'};
            string[] text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> res = new List<string>();

            foreach (string i in text)
            {
                char[] cArray = i.ToCharArray();
                string reverse = String.Empty;
                for (int j = cArray.Length - 1; j > -1; j--)
                {
                    reverse += cArray[j];
                }
                if (i == reverse)
                {
                    res.Add(i);
                }
            }

            res.Sort();
            int a = 0;
            while (a < res.Count - 1)
            {
                if (res[a].Equals(res[a + 1]))
                {
                    res.RemoveAt(a);
                    a = 0;
                }
                else a++;
            }

            if (res.Count > 0)
            {
                Console.WriteLine(String.Join(", ", res));
            }
            
        }
    }
}
