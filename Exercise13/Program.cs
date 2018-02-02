using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int size;
            Console.WriteLine("Indica el tamaño del array");
            size = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Introduce el valor {i+1}");
                array[i] = Console.ReadLine();
            }

            string newstring = string.Join(", ", array);
            Console.WriteLine(newstring);
            Console.ReadKey();
        }
    }
}
