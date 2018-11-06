using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades51;
namespace Test51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 51";


            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", EFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(EFranja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            try
            {
                c += l1;
                Console.WriteLine(c);
                c += l2;
                Console.WriteLine(c);
                c += l3;
                Console.WriteLine(c);
                c += l4;
                Console.WriteLine(c);
                c.OrdenarLlamadas();
                Console.WriteLine(c);

                //lanzo excepcion
                c += l1;

                Console.ReadKey();

            }
            catch (CentralitaException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
