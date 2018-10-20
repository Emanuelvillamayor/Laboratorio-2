using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        #region Atributos

        public short cantidadMarchas;
        public int cantidadPasajeros;

        #endregion

        #region Constructor

        public Automovil(short cantRuedas , short cantPuertas , EColores color , short cantMarchas , int cantPasajeros) :  base(cantRuedas,cantPuertas,color)
        {
            this.cantidadMarchas = cantMarchas;
            this.cantidadPasajeros = cantPasajeros;

        }


        #endregion




    }
}
