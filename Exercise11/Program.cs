using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            List<int> array = new List<int> { 23, 5, 11, 3, 54, 7, 1, 23, 54, 57, 33, 12 };

            //Query Creation
            Console.WriteLine("Introduce cuantos registros quieres visualizar");
            int size = Convert.ToInt32(Console.ReadLine());

            //Query execution
            array.Sort();
            array.Reverse();

            Console.WriteLine($"Los registros son: {string.Join(", ", array.Take(size))}");
            Console.ReadKey();
            
        }
    }
}
