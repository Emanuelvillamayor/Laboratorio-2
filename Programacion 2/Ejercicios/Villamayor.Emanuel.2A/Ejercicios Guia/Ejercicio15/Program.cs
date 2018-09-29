using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Ejercicio15
    { 
        static void Main(string[] args)
        {
            Single numero1;
            Single numero2;
            Char opcion;
            Char operacion;
            Single resultado;

            Console.Title = "Ejercicio 15";
            do
            {
                Console.Write("Ingrese un numero: ");
                numero1 = Single.Parse(Console.ReadLine());

                Console.Write("Ingrese otro numero: ");
                numero2 = Single.Parse(Console.ReadLine());

                Console.Write("+ (suma)\n - (resta)\n * (multiplicacion)\n / (division)\n ¿Que operacion desea realizar?: \n");
                operacion = char.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(numero1, numero2, operacion);

                Calculadora.Mostrar(resultado);

                Console.Write("¿Desea continuar?: ");
                opcion = char.Parse(Console.ReadLine());
            } while (opcion != 'n');



        }
    }
}
