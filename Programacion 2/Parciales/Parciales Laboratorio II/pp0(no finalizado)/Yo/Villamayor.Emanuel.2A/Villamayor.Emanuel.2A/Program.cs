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
            Menor men = new Menor("Lucas", "Villalba",Menor.eMenu.Milanesa);

            Console.WriteLine( men.ToString());


            Mayor may = new Mayor("Pepe", "Mujica", Mayor.eBebidas.Gaseosa);

            Console.WriteLine(may.ToString());

            Console.ReadLine();

        }
    }
}
