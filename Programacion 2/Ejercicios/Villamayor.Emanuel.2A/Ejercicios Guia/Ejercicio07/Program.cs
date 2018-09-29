using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Ejercicio07
    {
        static void Main(string[] args)
        {
            DateTime fechaLocal = DateTime.Now;
            DateTime fechaPersona;
            TimeSpan tiempoVivido;
            Int32 dias;
            


            Console.Title = "Ejercicio 07";

            Console.Write("Ingrese fecha de nacimiento : ");
            fechaPersona = DateTime.Parse(Console.ReadLine());

            tiempoVivido= fechaLocal - fechaPersona;

            dias = tiempoVivido.Days;

            Console.WriteLine("{0}",dias );

            Console.ReadLine();

        }
    }
}
