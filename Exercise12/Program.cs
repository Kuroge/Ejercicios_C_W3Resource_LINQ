using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase para saber que palabras están en mayúscula");
            List<string> palabras = Console.ReadLine().Split(' ').ToList();
            
            Console.WriteLine(string.Join(" ,", palabras.Where(x => x == x.ToUpper())));
            Console.ReadKey();
        }
    }
}
