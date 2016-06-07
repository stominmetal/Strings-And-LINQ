using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            List<string> end = new List<string>();
            List<string> end2 = new List<string>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] coms = command.Split(' ');

                switch (coms[0])
                {
                    case "A":
                        if (phonebook.ContainsKey(coms[1]))
                        {
                            phonebook.Remove(coms[1]);
                            phonebook.Add(coms[1], coms[2]);
                        } else
                        {
                            phonebook.Add(coms[1], coms[2]);
                        }
                        break;
                    case "S":
                        if (phonebook.ContainsKey(coms[1]))
                        {
                            end.Add($"{coms[1]} -> {phonebook[coms[1]]}");
                        } else
                        {
                            end.Add($"Contact {coms[1]} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var item in phonebook)
                        {
                            end.Add($"{item.Key} -> {item.Value}");
                        }
                        break;                                               
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join("\n", end));
        }
    }
}
