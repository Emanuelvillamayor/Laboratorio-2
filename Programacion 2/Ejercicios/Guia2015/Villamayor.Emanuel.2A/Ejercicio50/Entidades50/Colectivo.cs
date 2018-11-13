using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades50
{
    public abstract class Colectivo
    {
        #region Atributos

        protected List<Pasajero> _listPasajeros;
        private int _numeroDeLinea;
        private int _numeroDeMovil;

        #endregion

        #region Constructores

        public Colectivo(int linea , int movil)
        {
            this._listPasajeros = new List<Pasajero>();
            this._numeroDeLinea = linea;
            this._numeroDeMovil = movil;
        }

        #endregion

        #region Metodos

        public abstract void SacarBoleto(Pasajero p);
        public abstract void SolicitanBajar(Pasajero p);

        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Numero de Linea: {0}\n", this._numeroDeLinea);
            sb.AppendFormat("Numero de Movil : {0}\n", this._numeroDeMovil);
            sb.AppendFormat("Cantidad Pasajeros  a bordo: {0}\n", this._listPasajeros.Count);

            return sb.ToString();
        }

    }
}
