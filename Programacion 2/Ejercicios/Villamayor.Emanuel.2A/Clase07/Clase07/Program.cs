using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class clase07
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 07";

            Tempera t1 = new Tempera(2,ConsoleColor.Blue,"pandin");
            Tempera t2 = new Tempera(2,ConsoleColor.Blue,"pandin");
            Tempera t3 = new Tempera(5, ConsoleColor.Green, "bro");
            sbyte cantidad=21;

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 != t2);

            Console.WriteLine(t2);

            cantidad = (sbyte)t1;

            Console.WriteLine(cantidad);

            t1 = t1 + cantidad;
            Console.WriteLine(t1);

            t3 = t1 + t2;
            Console.WriteLine(t3);

            Console.ReadLine();

        }
    }
}
