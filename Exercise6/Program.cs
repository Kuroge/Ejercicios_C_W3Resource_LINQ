using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            string[] weekDays = new string[] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

            //Query Creation

            var days = from o in weekDays
                       select o;

            //Query Execution
            Console.WriteLine(string.Join(", ",days.ToArray()));
            Console.ReadKey();
        }
    }
}
