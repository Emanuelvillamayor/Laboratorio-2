using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            Int32 valor;
            Boolean flag=false;
            Boolean validar;
            Int32 rangoMax =100;
            Int32 rangoMin = -100;
            Int32 i;

            Int32 min=0;
            Int32 max=0;

            Console.Title = "Ejercicio 11";

            for(i=0;i<10;i++)
            {
                Console.Write("Ingrese un numero entre -100 y 100 : ");
                valor = Int32.Parse(Console.ReadLine());

                validar = Validacion.Validar(valor, rangoMin, rangoMax);

                if (validar == true)
                {

                    if ((valor < min) || flag == false)
                    {
                        min = valor;
                    }

                    if ((valor > max) || flag == false)
                    {
                        max = valor;
                        flag = true;
                    }
                }
                else
                {
                    Console.WriteLine("Error!.El valor ingrese no esta entre -100 y 100");
                }

            }

            Console.WriteLine("Min : {0}",min);
            Console.WriteLine("Max : {0}", max);

            Console.ReadLine();
        }
    }
}
