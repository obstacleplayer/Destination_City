using System;
using System.Collections;
using System.Collections.Generic;

namespace Destination_City
{
    class Program
    {
         

        static void Main(string[] args)
        {
            IList<IList<string>> pathss = new List<IList<string>>();

            pathss.Add(new List<string> {"London", "New York"});
            pathss.Add(new List<string> {"New York", "Lima"});
            pathss.Add(new List<string> {"Lima", "Sao Paulo"});
            
            string DestCity(IList<IList<string>> paths)
            {
                string destination = string.Empty;

                HashSet<string> hash = new HashSet<string>();
                foreach (var citys in paths)
                {
                    string start = citys[0];

                    if (hash.Contains(start) == false)
                    {
                        hash.Add(start);
                    }
                }

                foreach (IList<string> citys in paths)
                {
                    string end = citys[1];

                    if (hash.Contains(end) == false)
                    {
                        destination = end;
                        break;
                    }
                }

                return destination;
            
            
            }
            
            Console.WriteLine($"{DestCity(pathss)}");
           
        }
    }
}