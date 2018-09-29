using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Ejercicio19
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";

            Sumador suma1 = new Sumador();
            Sumador suma2 = new Sumador(5);

            Console.WriteLine("Suma de numeros: {0}", suma1.Sumar(2,3));
            Console.WriteLine("Suma concatenada: {0}",suma1.Sumar("1", "5"));
            Console.WriteLine("Cantidad de sumas suma1 : {0}",suma1.GetCantSumas());

            Console.WriteLine();

            Console.WriteLine("Suma de numeros: {0}", suma2.Sumar(5, 1));
            Console.WriteLine("Suma concatenada: {0}", suma2.Sumar("1", "23"));
            Console.WriteLine("Cantidad de sumas suma2 : {0}",suma2.GetCantSumas());

            Console.WriteLine();

            Console.WriteLine("Suma1 + Suma2 : {0}",suma1+suma2);

            Console.WriteLine();

            if(suma1|suma2)
            {
                Console.WriteLine("Los sumadores son iguales ");
            }
            else
            {
                Console.WriteLine("Los sumadores son distintos");
            }




            Console.ReadLine();



        }


    }
}
