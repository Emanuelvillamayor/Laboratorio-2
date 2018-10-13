using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace TestLavadero_pp_
{
    class Program
    {
        static void Main(string[] args)
        {

            Moto m1 = new Moto(EMarcas.Ford, 22.5f, "abc 234", 2);
            Camion c1 = new Camion(45.70f, "ghk 232", 8, EMarcas.Honda);
            Auto a1 = new Auto("plo 457", EMarcas.Ford, 5);

            

            Lavadero l1 = new Lavadero("Limpiarlos");

            l1 += m1;
            l1 += c1;
            l1 += a1;

            Console.WriteLine(l1 == m1); //si esta o no
            Console.WriteLine(m1 == l1);// indice

            Console.WriteLine(l1 == c1); //si esta o no
            Console.WriteLine(a1 == l1);// indice
           
            Console.WriteLine("\r\n\n");
            Console.WriteLine(l1.LavaderoToString);


            Console.WriteLine(l1.MostrarTotalFacturado());

            l1.Vehiculos.Sort(l1.OrdenarVehiculosPorMarca); //ordeno por marca

            Console.WriteLine(l1.LavaderoToString); //muestro ordenado

            Console.ReadLine();

        }
    }
}
