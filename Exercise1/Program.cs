using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source.
            int[] dividers = new int[] { 1,2,3,4,5,6,7,8,9 };

            //Define the query
            IEnumerable<int> result = from o in dividers
                                      where (o%2) == 0
                                      select o;


            //Execute the query
            foreach (int item in result)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
