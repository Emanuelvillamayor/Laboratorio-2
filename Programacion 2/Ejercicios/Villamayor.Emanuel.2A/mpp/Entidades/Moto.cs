using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        #region Constructor
        public Moto(EMarcas marca,float cilindro,string patente,byte ruedas) : this(cilindro,patente,ruedas,marca)
        {

        }

        public Moto(float cilindro , string patente,byte ruedas,EMarcas marca) :base(patente,ruedas,marca)
        {
            this._cilindrada = cilindro;

        }

        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            return String.Format("{0} Cilindrada: {1}", base.Mostrar(), this._cilindrada);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}
