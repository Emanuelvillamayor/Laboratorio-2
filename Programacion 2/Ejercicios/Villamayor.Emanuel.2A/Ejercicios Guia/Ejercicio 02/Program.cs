using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            Double numero;
            Double cuadrado;
            Double cubo;

            Console.Title = "Ejercicio 02";

            Console.WriteLine("Ingrese un numero : ");

            numero = Int32.Parse(Console.ReadLine());

            if(numero>0)
            {
                cuadrado = Math.Pow(numero,2);
                cubo = Math.Pow(numero, 3);

                Console.WriteLine("Numero Original {0}", numero);
                Console.WriteLine("Numero al cuadrado : {0}", cuadrado);
                Console.WriteLine("Numero al cubo : {0}", cubo);

            }
            else
            {

                Console.WriteLine("ERROR.¡Reingresar Numero!");
            }

            Console.ReadLine();
        }
    }
}
