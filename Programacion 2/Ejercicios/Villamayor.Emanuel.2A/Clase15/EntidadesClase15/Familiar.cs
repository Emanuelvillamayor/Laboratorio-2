using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
    public class Familiar : Auto
    {
        #region Atributos

        protected int _cantAsientos;

        #endregion

        #region Propiedades

        public int CantAsientos
        {
            get
            {
                return this._cantAsientos;
            }
            set
            {
                this._cantAsientos = value;
            }
        }

        #endregion
        #region Constructores

        public Familiar(double precio , string patente , int cantAsientos) : base(precio,patente)
        {
            this._cantAsientos = cantAsientos;
        }

        #endregion

    }
}
