using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto a = new Auto(5, 4, 2, 22.5f);
            //Console.WriteLine( a.MostrarPrecio());

            Guitarra g = new Guitarra();

            g.MostrarHija();

        }
    }
}
