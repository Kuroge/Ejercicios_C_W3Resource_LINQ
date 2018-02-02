using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            int[] numbers = new int[] { 123, 65, 123, 65, 4, 78, 9, 23, 76, 98, 35, 4315, 756, 23, 6, 89, 546, 2456, 867 };


            //Query Creation
            var ngte = from o in numbers
                       where o > 80
                       select o;

            //Query execution
            Console.WriteLine($"Los números mayores de 80 son: {string.Join(", ",ngte.ToArray())}");
            Console.ReadKey();


        }
    }
}
