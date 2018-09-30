using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Ejercicio27
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Ejercicio 27";

            //*************PILAS NO GENERICAS****************
            int numerito = 0;
            int i;
            bool esValido;

            System.Collections.Stack pila = new System.Collections.Stack();


            Console.WriteLine("----------PILAS NO GENERICAS--------\n");
            

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese numero {0} de 3  (distinto de cero): ", i + 1);
                esValido = int.TryParse(Console.ReadLine(), out numerito);

                while (esValido == false || numerito == 0)
                {
                    Console.WriteLine("ERROR!.Ingrese un valor Entero distinto de cero");
                    esValido = int.TryParse(Console.ReadLine(), out numerito);
                }
                pila.Push(numerito);
            }

            Console.WriteLine("\nMuestro los postivos: ");
            
            foreach(int item in pila)
            {
                if (item > 0)
                    Console.WriteLine(item);
            }

            Console.WriteLine("\nMuestro los negativos:");

            foreach(int item in pila)
            {
                if (item < 0)
                    Console.WriteLine(item);
            }


            //**********************COLAS NO GENERICAS****************

            System.Collections.Queue cola = new System.Collections.Queue();

            Console.WriteLine("\n\n---------COLAS NO GENERICAS----------\n");


            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese numero {0} de 3  (distinto de cero): ", i + 1);
                esValido = int.TryParse(Console.ReadLine(), out numerito);

                while (esValido == false || numerito == 0)
                {
                    Console.WriteLine("ERROR!.Ingrese un valor Entero distinto de cero");
                    esValido = int.TryParse(Console.ReadLine(), out numerito);
                }
                cola.Enqueue(numerito);
            }


            Console.WriteLine("\nMuestro los postivos: ");

            foreach (int item in cola)
            {
                if (item > 0)
                    Console.WriteLine(item);
            }

            Console.WriteLine("\nMuestro los negativos:");

            foreach (int item in cola)
            {
                if (item < 0)
                    Console.WriteLine(item);
            }



            //LISTAS DINAMICAS NO GENERICAS


            System.Collections.ArrayList vec = new System.Collections.ArrayList();

            Console.WriteLine("\n\n---------LISTA DINAMICA NO GENERICA------------ \n\n");


            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese numero {0} de 3  (distinto de cero): ", i + 1);
                esValido = int.TryParse(Console.ReadLine(), out numerito);

                while (esValido == false || numerito == 0)
                {
                    Console.WriteLine("ERROR!.Ingrese un valor Entero distinto de cero");
                    esValido = int.TryParse(Console.ReadLine(), out numerito);
                }
                vec.Add(numerito);
            }


            Console.WriteLine("\nMuestro los postivos: ");

            

            foreach (int item in vec)
            {
                if (item > 0)
                    Console.WriteLine(item);
            }

            Console.WriteLine("\nMuestro los negativos:");

            foreach (int item in vec)
            {
                if (item < 0)
                    Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
