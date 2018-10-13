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
            int numCamiseta;

            DirectorTecnico dt = new DirectorTecnico("jorge", "mostaza");
            Equipo e = new Equipo("racin", dt);

            Jugador j1 = new Jugador("lucas", "poncio", 10, true);
            Jugador j2 = new Jugador("rodri", "vele");

            Console.WriteLine(dt.ToString());
            Console.WriteLine(j1.ToString());
            Console.WriteLine(j2.ToString());

            numCamiseta = (int)j1;
            Console.WriteLine("Numero camiseta: {0}\r\n", numCamiseta);

            e += j1;
            e += j2;
            e += j1;

            Console.WriteLine(e);

            Console.ReadLine();

        }
    }
}
