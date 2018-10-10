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

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.Parse("13/11/2018");

            TimeSpan ts;
            ts = d2 - d1;

            
            int dias;
            dias = ts.Days;

            Console.WriteLine("Dias " + dias);

            Console.ReadLine();
        }
    }
}
