using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {

        public short cantidadRuedas;
        public short cantidadPuertas;
        public EColores color;
       


        public VehiculoTerrestre(short cantRuedas, short cantPuertas, EColores color)
        {
            this.cantidadPuertas = cantPuertas;
            this.cantidadRuedas = cantRuedas;
            this.color = color;





        }



    }
}
