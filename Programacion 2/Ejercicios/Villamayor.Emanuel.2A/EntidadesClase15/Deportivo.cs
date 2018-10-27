using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
    public class Deportivo : Auto, IAFIP,IARBA
    {
        #region Atributos

        protected int _caballosFuerza;

        #endregion

        #region Propiedaes

        public int CaballosFuerza
        {
            get
            {
                return this._caballosFuerza;
            }
            set
            {
                this._caballosFuerza = value;
           }
        }

        #endregion

        #region Constructoress

        public Deportivo(double precio , string patente , int cf) : base(precio,patente)
        {
            this._caballosFuerza = cf;
        }
       
        #endregion

 public double CalcularImpuesto()
        {
            return this.Precio * 0.28;
        }

        double IARBA.CalcularImpuesto()
        {
            return this.Precio * 0.23;
        }

    }
}
