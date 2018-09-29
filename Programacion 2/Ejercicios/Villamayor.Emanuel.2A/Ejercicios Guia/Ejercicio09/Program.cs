using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Ejercici09
    {
        static void Main(string[] args)
        {
            Int32 len;
            Int32 i;
            Int32 j;
            Console.Title = "Ejercicio 09";

            Console.Write("Ingrese la cantidad de filas : ");
            len = Int32.Parse(Console.ReadLine());

            for(i=0;i<len;i++)
            {
                Console.Write("*");
                for(j=0;j<i;j++)
                {
                    Console.Write("**");
                }
                Console.Write("\n");
            }

            Console.ReadLine();

        }
    }
}
