using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            int[] numbers = new int[] { 2, 4, 5, 6, 7, 8, 9, 3, 4, 5 };

            //Query creation

            var sqrNumber = from o in numbers
                            let sqrNo = o * o
                            select new { o, sqrNo };
            //Query execution

            foreach (var item in sqrNumber)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
