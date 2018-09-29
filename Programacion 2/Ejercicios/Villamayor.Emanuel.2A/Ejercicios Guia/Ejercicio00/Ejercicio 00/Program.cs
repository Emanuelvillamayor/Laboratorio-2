using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ingresar nombre 

namespace Ejercicio00
{
    class Ejercicio_00
    {
        static void Main(string[] args)
        {
            string nombre;
            Int32 edad;
            
            Console.WriteLine("Ingrese nombre : ");

            nombre=Console.ReadLine();

            Console.WriteLine("Ingrese edad : ");

            edad =int.Parse (Console.ReadLine()); //Hay que castearlo de manera explicita utilizando la libreria
            
            Console.WriteLine("Su nombre es {0} ",nombre);
            Console.WriteLine("Su edad es {0} ", edad);

        }
    }
}
