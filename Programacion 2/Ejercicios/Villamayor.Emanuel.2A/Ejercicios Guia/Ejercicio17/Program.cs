using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Ejercicio17
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            string dibujo;

            Bolígrafo pen = new Bolígrafo(100,ConsoleColor.Blue);
            Bolígrafo pen2 = new Bolígrafo(50, ConsoleColor.Red);

            if(pen.Pintar(10, out dibujo))
            {
                Console.WriteLine("Cantidad de tinta restante : {0}", pen.GetTinta());
                Console.WriteLine("{0}", dibujo);

            }
            else
            {
                Console.WriteLine("No pudo pintar , no hay tinta");
            }



            if (pen2.Pintar(40, out dibujo))
            {
                Console.WriteLine("Cantidad de tinta restante : {0}", pen2.GetTinta());
                Console.WriteLine("{0}", dibujo);
                

            }
            else
            {
                Console.WriteLine("No pudo pintar , no hay tinta");
            }




            Console.ReadLine();


            
            

        }
    }
}
