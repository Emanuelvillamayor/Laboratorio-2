using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        
       

        public static Boolean Validar(Int32 valor, Int32 min, Int32 max )
        {
            Boolean retorno = false;


            if(valor>=min && valor<=max)
            {
                retorno = true;
            }

            return retorno;
        }

    }
}
