using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase15;

namespace TesClase15
{
    class Program
    {
        static void Main(string[] args)
        {
           Comercial c1 = new Comercial(2, 5, 20);
            Avion a1 = new Avion(2, 6);
            Console.WriteLine(a1.CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestoNacional(a1));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(a1));

            Console.WriteLine(Gestion.MostrarImpuestoNacional(c1));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(c1));


            Console.ReadKey();


        }
    }
}
