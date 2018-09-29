using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static Single Calcular(Single numeroUno, Single numeroDos, Char cuenta)
        {
            Single retorno = 0;

            if (cuenta == '+')
            {
                retorno = numeroUno + numeroDos;
            }
            else if (cuenta == '-')
            {
                retorno = numeroUno - numeroDos;
            }
            else if (cuenta == '*')
            {
                retorno = numeroUno * numeroDos;
            }
            else if (cuenta == '/')
            {
                if (Validar(numeroDos))
                {
                    retorno = numeroUno / numeroDos;
                }
                else
                {
                    Console.WriteLine("Error, no se puede dividir por 0");
                }

            }

            return retorno;
        }

        private static Boolean Validar(Single numeroDos)
        {
            Boolean retorno = false;
            if (numeroDos != 0)
            {
                retorno = true;
            }
            return retorno;
        }

        public static void Mostrar(Single resultado)
        {
          Console.WriteLine("El resultado de la operacion es : {0:#,###.00}\n", resultado);
        }

    }
}
