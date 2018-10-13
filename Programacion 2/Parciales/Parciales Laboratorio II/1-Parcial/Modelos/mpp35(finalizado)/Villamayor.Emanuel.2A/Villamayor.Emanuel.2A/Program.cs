using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Villamayor.Emanuel._2A
{
    class Program
    {
        static void Main(string[] args)
        {
            double importeDouble;
            Auto[] autos = new Auto[5];


            Auto a1 = new Auto(EMarcas.Ferrari, "rosa");
            Auto a2 = new Auto(EMarcas.Ferrari, "verde");

            Auto a3 = new Auto(EMarcas.Ford, "naranja", 22.5);
            Auto a4 = new Auto(EMarcas.Lotus, "amarillo", 45, DateTime.Now);
            Auto a5 = new Auto("negro", EMarcas.Lotus, 235.67, DateTime.Now);

            a3.AgregarImpuestos(1000);
            a4.AgregarImpuestos(1000);
            a5.AgregarImpuestos(1000);

            importeDouble = a1 + a2;

            Console.WriteLine("Importe a1+a2 : " + importeDouble);
            Console.WriteLine(a1 == a2);
            Console.WriteLine(a1 == a5);




            Console.ReadLine();

        }
    }
}
