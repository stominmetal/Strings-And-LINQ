using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace URLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            string protocol = null;
            string server = null;
            string resource = null;

            if (url.Contains("://"))
            {                
                protocol = url.Substring(0, url.IndexOf("://"));
                url = url.Substring(url.IndexOf("://")+3, url.Length - (url.IndexOf("://") + 3));
            } 

            if (url.Contains("/"))
            {
                server = url.Substring(0, url.IndexOf("/"));
                resource = url.Substring(url.IndexOf("/") + 1, url.Length - (url.IndexOf("/") + 1));
            } else
            {
                server = url;
            }

            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }
}
