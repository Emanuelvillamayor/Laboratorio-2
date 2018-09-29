using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Ejercicio06
    {
        static void Main(string[] args)
        {
            Int32 año;
            

            Console.Title = "Ejercicio 06";

            Console.Write("Ingrese un año : ");
            año = Int32.Parse( Console.ReadLine() );
           
            if (año%4==0 && (año % 100 != 0 || año % 400 ==0))
            {
                Console.WriteLine("El año ingresado es bisiesto ");
            }
            else
            {
                Console.WriteLine("El año ingresado no es bisiesto ");
            }

            Console.ReadLine();
        }
    }
}
