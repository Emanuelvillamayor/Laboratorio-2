using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades48;
namespace TestEjercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 48";
            Recibo r = new Recibo(2);
            Factura f = new Factura(10);
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();

            c += r;
            c += f;


            Console.ReadKey();
        }
    }
}
