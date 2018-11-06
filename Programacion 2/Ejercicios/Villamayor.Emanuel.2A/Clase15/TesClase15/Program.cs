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
           Comercial c1 = new Comercial(1000,1200, 300);
            Avion a1 = new Avion(100, 5000);
            

            //////AVION
            //Console.WriteLine(a1.CalcularImpuesto());
            //Console.WriteLine(((IARBA)a1).CalcularImpuesto());

            //Console.WriteLine(Gestion.MostrarImpuestoNacional(a1));
            //Console.WriteLine(Gestion.MostrarImpuestoProvincial(a1));

            ////COMERCIAL
            //Console.WriteLine(c1.CalcularImpuesto()); // VA AL METODO DE AVION YA QUE IMPLICITO NO TIENE EN LA CLASE COMERCIAL
            //Console.WriteLine(((IARBA)c1).CalcularImpuesto());//ACA VA AL METODO DE COMERCIAL YA QUE AGREGAMOS UN EXPLICITO QUE NO SEA EL MISMO DE AVION

            //Console.WriteLine(Gestion.MostrarImpuestoNacional(c1));
            //Console.WriteLine(Gestion.MostrarImpuestoProvincial(c1));

            //CARRETA
            Carreta cm1 = new Carreta(100);
            Console.WriteLine(cm1.CalcularImpuesto());
            Console.WriteLine(((IAFIP)cm1).CalcularImpuesto()); //Aca rompe porque no tiene un calcular impuesto de iafip



            Console.ReadKey();


        }
    }
}
