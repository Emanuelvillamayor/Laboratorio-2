using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades47;

namespace Ejercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Pez p = new Pez("Ramiro", 0);
            Araña a = new Araña(8);
            Gato g = new Gato("Carla", 4);

            Console.WriteLine(p.Caminar());
            Console.WriteLine(p.Comer());
            p.Jugar();

            Console.WriteLine(g.Caminar());
            Console.WriteLine(g.Comer());
            g.Jugar();

            Console.WriteLine(a.Caminar());
            Console.WriteLine(a.Comer());
            a.Jugar();

            Console.ReadKey();

        }
    }
}
