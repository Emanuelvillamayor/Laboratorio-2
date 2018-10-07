using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Jugo : Producto
    {
        #region Atributos

        protected ESaborJugo _sabor;
        protected bool DeConsumo;

        #endregion

        #region Propiedades

        public override float CalcularCostoDeProduccion
        {
            get { return (base.Precio * 40) / 100; }

        }

        #endregion



        #region Constructores
        private Jugo

        #endregion



        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico
        }


    }
}
