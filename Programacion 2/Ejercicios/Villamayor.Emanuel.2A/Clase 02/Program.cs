using System;
using Entidades; // Çon este using no hace falta acceder a "Sello" anteponiendole el "Entidades"
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Sello.mensaje = "";
            Sello.color = ConsoleColor.DarkBlue;
            
            Console.WriteLine(Sello.Imprimir());

            Sello.ImprimirEnColor();

            Sello.borrar();



            Console.ReadLine();

        }
    }
}
