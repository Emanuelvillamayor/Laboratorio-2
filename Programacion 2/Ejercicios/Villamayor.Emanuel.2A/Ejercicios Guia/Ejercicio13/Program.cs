using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Ejercicio13
    {
        static void Main(string[] args)
        {
          
            String numero; //lo que le paso a la funcion


            String decimalBinario; //lo que devuelve la funcion
            Double binarioDecimal;


            Console.Write("Ingrese un numero:  ");
            numero = Console.ReadLine();

            decimalBinario = Conversor.DecimalBinario(Double.Parse(numero));
            Console.WriteLine("DecimalBinario : {0}", decimalBinario);

            if (Int32.Parse(numero)==0 || Int32.Parse(numero)==1)
            {
                binarioDecimal = Conversor.BinarioDecimal(numero);
                Console.WriteLine("BinarioDecimal : {0}", binarioDecimal);
            }
            

           
            



        }
    }
}
