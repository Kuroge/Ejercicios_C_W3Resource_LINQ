using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            Console.WriteLine("Introduce el tamaño de la lista");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int number;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Introduce el valor {i+1}");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Query Creation
            Console.WriteLine("Introduce el número para filtrar los resultados. Se mostrarán los datos mayores a dicho número.");
            number = Convert.ToInt32(Console.ReadLine());
            var filter = from o in array
                         where o > number
                         select o;

            //Query Execution
            Console.WriteLine($"Los resultados mayores de {number} son: {string.Join(", ",filter)}");
            Console.ReadKey();

        }
    }
}
