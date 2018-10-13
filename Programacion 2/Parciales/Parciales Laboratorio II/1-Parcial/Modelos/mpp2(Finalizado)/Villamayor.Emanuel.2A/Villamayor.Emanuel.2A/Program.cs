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
            /* List<Mascota> masco = new List<Mascota>();

              Perro p1 = new Perro("lucho", "dogo", 10, true);
              Perro p2 = new Perro("garflied", "acuaman", 11, false);
              int edadPerro;

              masco.Add(p1);
              masco.Add(p2);

              Console.WriteLine(p1.ToString());
              Console.WriteLine(p1 == p2);
              Console.WriteLine(p1 != p2);
              edadPerro = (int)p1;
              Console.WriteLine("Edad perro: {0}\r", edadPerro);

              Console.WriteLine("------------Gato---------\r");

              Gato g1 = new Gato("michi", "arabe");
              Gato g2 = new Gato("carla", "chui");

              masco.Add(g1);
              masco.Add(g2);

              Console.WriteLine(g1.ToString());
              Console.WriteLine(g1 == g2);
              Console.WriteLine(g1 != g2);

              Console.WriteLine("\n\n ------La posta-------\r\r\n");

              Grupo g = new Grupo("Rio", Grupo.TipoManada.mixta);

              g += p1;
              g += p2;
              g += g1;
              g -= p1;

              Console.WriteLine(g);

           //---------PRUEBO SOBRECARGA DEL EQUALS--------------

           Gato g5 = new Gato("michi", "pajjaro");
           Gato g6 = new Gato("loli", "pe");

         Console.WriteLine(  g5.Equals(g6));


           Perro p5 = new Perro("michi", "pajjaro");
           Perro p6 = new Perro("jorge", "panflim");

           Console.WriteLine(p5.Equals(p6));

           Console.WriteLine(p5.Equals(g5));
           */

            Gato g1 = new Gato("loco", "pito");
            Perro p1 = new Perro("acuaman", "longsdale");
            Perro p2 = new Perro("fi", "fo");

            Console.WriteLine(p1.Equals(p2));

            Console.WriteLine(p1.Equals(g1));



            Console.ReadLine();

        }
    }
}
