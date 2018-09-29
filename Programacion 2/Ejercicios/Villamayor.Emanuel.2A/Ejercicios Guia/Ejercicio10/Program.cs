using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class ejercicio10
    {
        static void Main(string[] args)
        {
            Int32 len;
            Int32 i;
            Int32 j;
            Int32 x;
            Int32 aux;

            Console.Title = "Ejercicio 10";

            Console.Write("Ingrese cantidad de filas : ");
            len = Int32.Parse(Console.ReadLine());
            aux = len;
            for(i=0;i<len;i++)
            {
                for(j=aux;j>0;j--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                aux--;

                for(x=0;x<i;x++)
                {

                    Console.Write("**");
                }
                Console.Write("\n");
            }

            Console.ReadLine();

        }
    }
}
