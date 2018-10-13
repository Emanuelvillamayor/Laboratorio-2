using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        #region Constructor
        public Camion(Vehiculo movil, float tara) : this(tara,movil.Patente,movil.CantRuedas,movil.Marca)
        {

        }
         


    public Camion(float tara,string patente,byte ruedas,EMarcas marca) : base(patente,ruedas,marca)
        {
            this._tara = tara;
        }
        #endregion


        #region Metodos

        protected override string Mostrar()
        {
            return String.Format("{0} Tara: {1}", base.Mostrar(), this._tara);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}
