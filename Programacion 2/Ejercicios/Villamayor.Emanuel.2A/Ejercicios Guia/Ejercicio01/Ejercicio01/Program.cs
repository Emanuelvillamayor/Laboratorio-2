using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";

            Int32 i;
            Int32 numero;
            Boolean flag = false;
            Int32 mayor=0;
            Int32 menor=0;
            Int32 acumulador = 0;
            Single promedio = 0;

            for (i = 0; i < 5; i++)
            {
                Console.Write("Ingrese 5 numeros : ");

                numero=int.Parse(Console.ReadLine());

                if (numero > mayor || flag==false )
                {
                    mayor = numero;
                }
               
                if (numero < menor || flag == false)
                {
                    menor = numero;
                    flag = true;
                }
                acumulador = acumulador + numero;
            }

            //promedio = acumulador / 5f; EN este caso se utiliza la "f" al lado del 5 para que se single y no doble
            //promedio = acumulador / (float)i;
            promedio = (float)(acumulador / 5.0);

            Console.WriteLine("El numero mayor es  : {0} y el menor es {1}", mayor, menor);
            Console.WriteLine("El promedio  es : {0:#,###.00}", promedio);
            Console.ReadLine();
        }
    }
}
