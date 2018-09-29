using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Ejercicio03
    {

        static void Main(string[] args)
        {

            Int32 numero;
            Int32 i;
            Ejercicio03 funct = new Ejercicio03();

            Console.Title = "Ejercicio 03";

            Console.Write("Ingrese un numero : ");

            numero = int.Parse(Console.ReadLine());

            for (i = 0; i <= numero; i++)
            {

                funct.CalcularMostrarPrimo(i);
            }

            
            Console.ReadLine();

        }
        
        //FUNCION DE CALCULAR Y MOSTRAR PRIMO

        public void CalcularMostrarPrimo(Int32 numero)
        {
            Int32 i;
            Int32 final = 0;

            for (i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {

                    final++;
                }
            }

            if (final == 2)
            {
                Console.WriteLine("{0}", numero);
            }

        }
    }
}
