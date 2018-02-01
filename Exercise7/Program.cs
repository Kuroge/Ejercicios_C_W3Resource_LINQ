using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            int[] numbers = new int[] { 1, 4, 5, 6, 1, 2, 3, 5, 5, 4, 34, 4, 1, 3, 56, 7, 8, 6, 4, 3, 2, 4, 5, 6, 78, 8, 56, 5, 54, 5, 5 };

            //Query Creation

            var querynumb = from o in numbers
                            group o by o into y
                            select y;

            //Query execution

            foreach (var item in querynumb)
            {
                Console.WriteLine($"El número {item.Key} se repite {item.Count()} y la multiplicacion de si mismo por su frecuencia es {item.Sum()}");
            }
            Console.ReadKey();
        }
    }
}
