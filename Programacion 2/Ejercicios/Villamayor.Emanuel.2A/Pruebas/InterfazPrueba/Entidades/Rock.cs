using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Rock : Banda
    {
      
       void MostrarRock()
        {
           Console.WriteLine(((IMusica)this).ValorTotalImpuesto()); // estoy llamando al metodo explicito que esta en mi clase padre
        }
    }
}
