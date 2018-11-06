using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    class Ejercicio50
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 50";

            //int string 
            GuardarTexto<int, string> guardarTexto = new GuardarTexto<int, string>();
            Console.WriteLine(guardarTexto.Guardar(2));
            Console.WriteLine(guardarTexto.Leer());

            Serializar<int, string> serializar = new Serializar<int, string>();
            Console.WriteLine(serializar.Guardar(2));
            Console.WriteLine(serializar.Leer());


            //int int PARA ESTO PINCHA YA QUE NO PUEDE PASAR DE INT A STRING AL MOSTRAR Y UN ENTERO ES LO QUE DEVUELVE LA FUNCION
            //Serializar<int, int> s1 = new Serializar<int, int>();
            //Console.WriteLine(s1.Guardar(2));
            //Console.WriteLine(s1.Leer());

            //GuardarTexto<int, int> gt1 = new GuardarTexto<int, int>();
            //Console.WriteLine(gt1.Guardar(2));
            //Console.WriteLine(gt1.Leer());

            Console.ReadKey();

        }
    }
}
