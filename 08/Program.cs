using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split(new char[] {' ', '.', ',', '?', '!', ';'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < name.Length; i++)
            {
                var charS = name[i].ToCharArray();
                charS[0] = char.ToUpper(charS[0]);
                name[i] = null;
                for (int j = 0; j < charS.Length; j++)
                {
                    name[i] = name[i] + charS[j];
                }
            }

            Console.WriteLine(String.Join(" ", name));
        }
    }
}
