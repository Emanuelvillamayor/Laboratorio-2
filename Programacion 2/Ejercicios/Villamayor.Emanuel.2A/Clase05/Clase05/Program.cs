using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 05";
           

            Tinta tinta1 = new Tinta(ConsoleColor.Black,ETipoTinta.China);
            Tinta tinta2 = new Tinta(ConsoleColor.Cyan);

            Pluma pluma1 = new Pluma();
            Pluma pluma2 = new Pluma("lopez", 99, tinta2);

            Console.WriteLine("Comparacion == dos tintas diferentes : ");
            Console.WriteLine(tinta1 == tinta2);

            Console.WriteLine(" ");

            Console.WriteLine("Comparacion != dos tintas diferentes : ");
            Console.WriteLine(tinta1 != tinta2);

            Console.WriteLine(" ");

            Console.WriteLine("Tinta 1 {0}  ", Tinta.Mostrar(tinta1));
            Console.WriteLine("Tinta 2 {0}  ", Tinta.Mostrar(tinta2));

            Console.WriteLine(" ");

            Console.WriteLine("Datos de pluma2 :" );
            Console.WriteLine(pluma2);

            Console.WriteLine(" ");

            Console.WriteLine("Comparacion == deuna pluma con una tinta distitnos :");
            Console.WriteLine(pluma2 == tinta1);  //comparar valores de tinta dentro de pluma con tinta

            Console.WriteLine(" ");

            Console.WriteLine("Comparacion != deuna pluma con una tinta distitnos :");
            Console.WriteLine(pluma2 != tinta1); //comparar valores de tinta dentro de pluma con tinta

            Console.WriteLine(" ");

            Console.WriteLine("Resta entre pluma y una tinta con valores distintos ");
            Pluma pluma3 = pluma2 - tinta1;
            Console.WriteLine(pluma3);

            Console.WriteLine(" ");

            Console.WriteLine("Suma entre pluma y una tinta con valores distintos ");
            Pluma pluma4 = pluma1 + tinta2;
            Console.WriteLine(pluma4);











            Console.ReadLine();
        }
    }
}
