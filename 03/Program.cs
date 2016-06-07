using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine().Split('@');
            var newEmail = new string('*', email[0].Length) + "@" + email[1];
            var text = Console.ReadLine();
            text = text.Replace(email[0] + "@" + email[1], newEmail);
            Console.WriteLine(text);
        }
    }
}
