using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {

            Jugador j1 = new Jugador(42395106,"ema",10,5);
            Jugador j2 = new Jugador(5064452, "lucas", 2, 8);
            Jugador j3 = new Jugador(4523433, "pepe", 10, 5);
            Jugador j4 = new Jugador(42395106, "ema", 10, 5); //igual al primer jugador

            Equipo e1 = new Equipo(2, "quilme");

            //muestro datos de un jugador
            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine();

            //comparo jugadores
            Console.WriteLine("Comparo dos jugadores: ");
            Console.WriteLine(j1 == j2);
            Console.WriteLine(j1 != j2);

            Console.WriteLine();

            //agrego jugador al equipo

            if(e1 + j1)
            {
                Console.WriteLine(j1.MostrarDatos());
            }

            if(e1+j2)
            {
                Console.WriteLine(j2.MostrarDatos());
            }

            //aqui se excederia por la cantidad de jugadores maxima
            if(e1+j3)
            {
                Console.WriteLine(j3.MostrarDatos());
            }


            
            

            Console.ReadLine();

        }
    }
}
