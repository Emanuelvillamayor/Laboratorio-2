using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Banda : IMusica
    {
          float  IMusica.ValorTotalImpuesto() // no lo puedo sobreescribir en las clase hijas pero si puedo llamarlo
        {
            return 22.5f;
        }

        void Mostrar()
        {
            Console.WriteLine(((IMusica)this).ValorTotalImpuesto()); // puedo implementar el metodo explicito
        }
    }
}
