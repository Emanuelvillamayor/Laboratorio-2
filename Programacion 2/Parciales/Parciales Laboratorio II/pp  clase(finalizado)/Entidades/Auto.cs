using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Auto :Vehiculo
    {
        protected int _cantidadAsientos;


        #region Constructores

        public Auto(string patente , EMarcas marca , int asientos) :this(asientos,patente,4,marca)
        {

        }



        public Auto(int asientos,string patente,byte ruedas,EMarcas marca): base(patente,ruedas,marca)
        {
            this._cantidadAsientos = asientos;
        }

        #endregion

        #region metodos

        protected override string Mostrar()
        {
            return String.Format("{0} Cantidad Asientos: {1}", base.Mostrar(), this._cantidadAsientos);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion

    }
}
