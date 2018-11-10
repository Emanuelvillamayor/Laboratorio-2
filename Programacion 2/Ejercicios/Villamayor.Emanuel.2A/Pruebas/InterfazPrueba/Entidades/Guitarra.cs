using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Guitarra : Instrumento
    {


        public void MostrarHija()
        {
           Console.WriteLine( ((IMusica)this).ValorTotalImpuesto());
        }
       

    }
}
