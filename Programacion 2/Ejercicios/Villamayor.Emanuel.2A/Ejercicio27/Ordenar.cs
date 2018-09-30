using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Ordenar
    {
       public static int OrdenarPositivoDescendente(int a , int b)
        {
            int retorno = 0;
            if(a>b)
            {
                retorno = 1;
            }

            if(a<b)
            {
                retorno = -1;
            }
            return retorno;
        }

    }
}
