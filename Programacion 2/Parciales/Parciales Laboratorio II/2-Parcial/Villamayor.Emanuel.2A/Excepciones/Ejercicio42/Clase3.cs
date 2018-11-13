using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.Ejercicio42
{
    class Clase3
    {
        public void MetodoInstancia()
        {
            try
            {
                new Clase2();
            }
            catch (Exception e)
            {
                throw new MiException(e.Message + "Se genero un error en el metodo instancia de la clase 3 (cuando llama  a la clase 2)\n", e);

                //se pasa todo el mensaje anterior junto con el nuevo error que aparece en esta clase
            }
        }
    }
}
