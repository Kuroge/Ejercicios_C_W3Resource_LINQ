using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            string[] cities = new string[] { "rome", "london", "nairobi", "california", "zurich", "new delhi",
                                                "amsterdam", "abu dhabi", "paris" };

            Console.WriteLine("Introduce una letra de inicio");
            string start = Console.ReadLine();

            Console.WriteLine("Introduce una letra de fin");
            string end = Console.ReadLine();

            //Query Creation
            var result = from o in cities
                         where o.StartsWith(start) && o.EndsWith(end)
                         select o;

            //Query execution

            foreach (var item in result)
            {
                Console.WriteLine($"La ciudad deseada es {item}");
            }
            Console.ReadKey();
        }
    }
}
