using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
  public  class Carreta : Vehiculo,IARBA
    {

        #region Constructores

        public Carreta(double precio) : base(precio)
        {

        }

        
        #endregion

        #region Metodos

        public double CalcularImpuesto()
        {
            return this._precio * 0.18;
        }

        #endregion


    }
}
