using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.Ejercicio42
{
    class Clase1
    {
        public static void LanzarExecpcion()
        {
            throw new DivideByZeroException();
        }

        public Clase1()
        {
            try
            {
                Clase1.LanzarExecpcion();
            }
            catch (Exception e)
            {
                throw e; //ya se guarda que intenta divir por cero el mensaje en "e"
            }
        }

    }
}
