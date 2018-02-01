using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            int[] numbers = new int[] { 1, 4, 5, 5, 4, 3, 2, 3, 4, 6, 7, 34, 4, 3, 3, 2, 4, 5, 46, 5, 5, 4 };

            //Query Creation
            var group = from n in numbers
                        group n by n into y
                        select y;




            //Query Execution
            foreach (var item in group)
            {
                Console.WriteLine($"Número {item.Key} se repite {item.Count()} veces");
            }
            Console.ReadKey();

        }
    }
}
