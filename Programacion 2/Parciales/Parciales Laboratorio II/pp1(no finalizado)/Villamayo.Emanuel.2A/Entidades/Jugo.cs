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
        protected static bool DeConsumo;

        #endregion

        #region Propiedades

        public override float CalcularCostoDeProduccion
        {
            get { return (base.Precio * 40) / 100; }

        }

        #endregion



        #region Constructores
       static Jugo()
        {
            Jugo.DeConsumo = true;
        }

        public Jugo(int codigoBarra,float precio , EMarcaProducto marca,ESaborJugo sabor) :base(codigoBarra,marca,precio)
        {
            this._sabor = sabor;
        }
        #endregion

        #region Metodos
        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            sb += base.;

        }

        #endregion


        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico
        }


    }
}
