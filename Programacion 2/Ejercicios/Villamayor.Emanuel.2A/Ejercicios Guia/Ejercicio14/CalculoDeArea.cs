using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static Double CalcularCuadrado(Double numero)
        {
            Double retorno;
            retorno = Math.Pow(numero, 2);
            return retorno;
        }

        public static Double CalcularTriangulo(Double basee,Double altura)
        {
            Double retorno;

            retorno = (basee * altura) / 2f;

            return retorno;
        }

        public static Double CalcularCirculo(Double numero)
        {
            Double retorno;

            retorno = Math.PI * (CalcularCuadrado(numero));

            return retorno;
        }

    }
}
