using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {

       public static Boolean ValidaS_N(char opcion)
        {
            Boolean retorno = false;

            if(opcion == 's')
            {
                retorno = true;

            }
            return retorno;
        }
    }
}
