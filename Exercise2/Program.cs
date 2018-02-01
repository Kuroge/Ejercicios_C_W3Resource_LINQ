using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            int[] numbers = new int[] { 1, 8, 4, 6, 9, 12, 54, -8, 5, -6, -7, -78 };

            //Query creation
            IEnumerable<int> positivos = from o in numbers
                                          where o > 0 && o < 12
                                          select o;

            //Query Execution
            Console.WriteLine(string.Join(",",positivos.ToArray<int>()));
            Console.ReadKey();
        }
    }
}
