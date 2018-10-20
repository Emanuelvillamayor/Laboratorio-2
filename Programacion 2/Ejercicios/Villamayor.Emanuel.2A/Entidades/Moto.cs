using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Moto :  VehiculoTerrestre
    {
        #region Atributos

        public short cilindrada;

        #endregion

        #region Constructores

        public Moto(short cantRuedas, short cantPuertas, EColores color, short cilin) : base(cantRuedas, cantPuertas, color)
        {
            this.cilindrada = cilin;
        }
        #endregion
    }
}
