using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Clase04
    {
        static void Main(string[] args)
        {
            Cosa objeto = new Cosa(); //constructor por defecto editado
            Cosa objeto2 = new Cosa("Hola"); //constructor que se puede hardcodear solo con string


             Int32 numero = 2;
             DateTime fecha = DateTime.Parse("12/5/4");
             String nombre = "lucas";
            

             Console.Title = "Ejercicio clase 04";

             objeto.cadena = nombre;
             objeto.fecha = fecha;
             objeto.numero = numero;

            Console.WriteLine("Ingrese un valor : ");
            objeto2.EstablecerValor(Console.ReadLine());
             
             Console.WriteLine("Concatenado: {0}", Cosa.Mostrar(objeto));
             Console.WriteLine("Concatenado: {0}", Cosa.Mostrar(objeto2));

            Console.ReadLine();



        }
    }
}
