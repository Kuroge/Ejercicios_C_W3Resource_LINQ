using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data source
            Console.WriteLine("Introduce una frase");
            string phrase = Console.ReadLine();
            

            //Query Creation
            var letters = from o in phrase
                          group o by o into y
                          select y;

            //Query execution
            foreach (var item in letters)
            {
                Console.WriteLine($"La letra {item.Key} se repite {item.Count()} veces");
            }
            Console.ReadKey();
        }
    }
}
