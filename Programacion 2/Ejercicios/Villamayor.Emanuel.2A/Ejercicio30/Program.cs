using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Ejercicio30
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 30";

            AutoF1 a1 = new AutoF1(10, "Ford");
            AutoF1 a2 = new AutoF1(34, "Ferrari");
            AutoF1 a3 = new AutoF1(81, "Porche");

            Competencia c1 = new Competencia(4, 2);

            //muestro un auto

            Console.WriteLine(a1.MostrarDatos());
            Console.WriteLine();

            //comparo autos 
            Console.WriteLine("Comparo dos autos: ");
            Console.WriteLine(a1 == a2);
            Console.WriteLine(a1 != a2);
            Console.WriteLine();

            //agrego autos a competencia
            Console.WriteLine("Agrego autos a la competencia: \n");

            if(c1+a1)
            {
                //muestro desde la clase Competencia

                Console.WriteLine(c1.MostrarDatos());
            }

            if(c1+a2)
            {
                //muestro desde la clase Competencia

                Console.WriteLine(c1.MostrarDatos());
            }

            Console.WriteLine();

            //intento agregar uno de mas 
            Console.WriteLine("Intento agregar uno de mas excediendo cant de jugadores: \n");

            if(c1+a3)
            {
                Console.WriteLine(c1.MostrarDatos());
            }


            Console.WriteLine();

            Console.WriteLine("Remuevo un jugador: \n");

            if(c1-a1)
            {
                Console.WriteLine(c1.MostrarDatos());
            }




            Console.ReadLine();



        }
    }
}
