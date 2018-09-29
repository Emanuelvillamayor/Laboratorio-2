using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Ejercicio26
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 26";
            int[] num = new int[20];
            bool esValido;
            int numerito = 0;
            int i;

            //CARGO DATOS
            
            for(i=0;i<num.GetLength(0);i++)    
            {
                Console.WriteLine("Ingrese numero {0} de 20  (distinto de cero): ", i+1);
                esValido = int.TryParse(Console.ReadLine(), out numerito);

                while (esValido==false || numerito==0)
                {
                    Console.WriteLine("ERROR!.Ingrese un valor entero distinto de cero");
                    esValido = int.TryParse(Console.ReadLine(), out numerito);
                }
                num[i] = numerito;
            }

            Console.WriteLine();

            //MUESTRO DATOS CARGADOS
            Console.WriteLine("A-Mostrar vector tal como fue ingresado: ");
            foreach (int item in num)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine();



            //Mostrar positivos ordenados decendiente
            Console.WriteLine("B-Mostrar positivos ordenaos decreciente");

            Array.Sort(num);//ordeno ascendente
            Array.Reverse(num);//lo paso al reves de ascendente es decir a descendente
            foreach (int item in num)
            {
                if(item>0)
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine();

            //Mostrar negativos ordenados creciente
            Console.WriteLine("C-Mostrar negativos ordenaos creciente");
            Array.Sort(num);
            foreach (int item in num)
            {
                if (item <0)
                    Console.WriteLine("{0}", item);
            }

            Console.ReadLine();

        }
    }
}
