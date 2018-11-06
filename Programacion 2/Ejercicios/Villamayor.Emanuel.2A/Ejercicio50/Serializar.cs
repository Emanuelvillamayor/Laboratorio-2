using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            //tres formas de hacerlo

            // return (V)Convert.ChangeType("Objeto Leido", typeof(V));
            //return (V)Convert.ChangeType("Objeto Leido", typeof(string));
            return (V)Convert.ChangeType("Texto Leido", TypeCode.String);
        }
    }
}
