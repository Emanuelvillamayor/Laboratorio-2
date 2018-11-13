using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.Ejercicio42
{
    class Clase2
    {
        public Clase2()
        {
            try
            {
                new Clase1();
            }
            catch (Exception e)
            {
                throw new UnaException(e.Message + "\nSe genero un error en el constructor de clase 2 (cuando llama a clase 1 en el try) 2\n", e);

                // se almacena el mensaje anterior que provieme de clase 1(divide por cero)  junto con lo que le paso de error
            }
        }
    }
}
