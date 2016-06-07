using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            for (int i = 1; i <= text.Length; i++)
            {
                Console.Write(text[text.Length - i]);
            }
        }
    }
}
