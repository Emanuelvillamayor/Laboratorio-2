using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Ejercicio14
    {
        static void Main(string[] args)
        {
            Double numero;
            Double basee;
            Double altura;
             

            Console.Title = "Ejercicio 14";

            Console.Write("Ingrese un numero a calcular area al cuadrado: ");
            numero = Double.Parse(Console.ReadLine());           
            Console.WriteLine("El area al cuadrado del numero ingresado es: {0:#,###.00} ", CalculoDeArea.CalcularCuadrado(numero) );


            Console.Write("Ingrese base de triangulo: ");
            basee = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese altura del triangulo: ");
            altura = Double.Parse(Console.ReadLine());
            Console.WriteLine("El area del triangulo es : {0:#,###.00}", CalculoDeArea.CalcularTriangulo(basee, altura));

            Console.Write("Ingrese el numero a calcular area del circulo : ");
            numero = Double.Parse(Console.ReadLine());
            Console.Write("El area del circulo ingresado es : {0:#,###.00}", CalculoDeArea.CalcularCirculo(numero));





            Console.ReadLine();

        
        }
    }
}
