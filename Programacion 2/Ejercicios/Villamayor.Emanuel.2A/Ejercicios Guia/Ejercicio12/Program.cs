using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Ejercicio12
    {
        static void Main(string[] args)
        {
            Int32 acumulador = 0;
            Int32 numero;
            Boolean flag;

            Console.Title = "Ejercicio 12";

            do
            {
                Console.Write("Ingrese un numero a sumar : ");
                numero = Int32.Parse(Console.ReadLine());

                acumulador = numero + acumulador;

                Console.Write("¿Desea continuar?");
                flag = ValidarRespuesta.ValidaS_N(char.Parse(Console.ReadLine()));
                
            } while (flag != false);

            Console.WriteLine("El resultado es : {0}", acumulador);
            Console.ReadLine();
            
        }
    }
}
