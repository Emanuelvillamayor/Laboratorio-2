using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Instrumento : IMusica
    {
       float IMusica.ValorTotalImpuesto() //Me deja implementarlo pero sin modificador de visibilidad ni de  comportamiento
        {
            return 22.5f;
        }

        public static void Mostrar()
        {
          //  ((IMusica)Instrumento).ValorTotalImpuesto(); no me permite llamarlo ya qe la clase es abstracta y no puedo instanciar un objeto de este tipo ni de manera estatica
          // Console.WriteLine( ((IMusica)Instrumento).ValorTotalImpuesto());
        }
    }
}
