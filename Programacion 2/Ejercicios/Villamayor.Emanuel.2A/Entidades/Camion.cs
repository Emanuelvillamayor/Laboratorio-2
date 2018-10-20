using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Camion : VehiculoTerrestre
    {

        #region Atributos

        public short cantidadMarchas;
        public int pesoCarga;
        #endregion

        #region Constructores

        public Camion(short cantRuedas, short cantPuertas, EColores color,short cantMarchas,int pesocarga) : base(cantRuedas,cantPuertas,color)
        {
            this.cantidadMarchas = cantMarchas;
            this.pesoCarga = pesocarga;
        }

        #endregion

    }
}
