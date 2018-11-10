using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona Escribir = new Persona("Emanuel", "villamayor");

            Persona.Guardar(Escribir);


            Persona Leer = Persona.Leer("persona.xml");


            Console.ReadKey();
        }
    }
}
