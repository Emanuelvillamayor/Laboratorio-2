using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Ejercicio05
    {
        static void Main(string[] args)
        {
            Int32 numero;
            Int32 i;
            Int32 j;
            Int32 acumMenos = 0;
            Int32 acumMas = 0;

            Console.Title = "Ejercicio 05";

            Console.Write("Ingrese un numero para calcular los centros numericos : ");
            numero = Int32.Parse( Console.ReadLine() );

            for(i=1;i<numero;i++)
            {
                acumMenos = 0;
                acumMas = 0;
                for(j=1;j<i;j++)
                {
                    acumMenos = acumMenos + j;
                }
                for (j = i + 1; j < 500; j++)
                {
                    acumMas = acumMas + j;
                    if (acumMenos == acumMas)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
