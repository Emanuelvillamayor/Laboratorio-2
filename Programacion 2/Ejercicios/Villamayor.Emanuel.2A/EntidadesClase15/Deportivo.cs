using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
    public class Deportivo : Auto, IAFIP
    {
        #region Atributos

        protected int _caballosFuerza;

        #endregion


        #region Constructors

        public Deportivo(double precio , string patente , int cf) : base(precio,patente)
        {
            this._caballosFuerza = cf;
        }

        public double CalcularImpuesto()
        {
            return this.Precio * 0.28;
        }

        #endregion

    }
}
