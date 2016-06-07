using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var text = str.Split(new char[] { '.', ',', '?', '!', ';', ' ', ':', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);

            while (str.Contains("<upcase>"))
            {
                var startPos = str.IndexOf("<upcase>") + 8;
                var endPos = str.IndexOf("</upcase>");
                var trim = str.Substring(startPos, endPos-startPos).ToUpper();
                var start = str.Substring(0, startPos - 8);
                var end = str.Substring(endPos + 9, str.Length - (endPos + 9));
                str = start + trim + end;
            }
            Console.WriteLine(str);
        }
    }
}
