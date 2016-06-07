using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            if (text.Length > 20)
            {
                text = text.Substring(0, 20);
            }
            else
            {
                text = text.PadRight(20, '*');
            }

            Console.WriteLine(text);
        }
    }
}
