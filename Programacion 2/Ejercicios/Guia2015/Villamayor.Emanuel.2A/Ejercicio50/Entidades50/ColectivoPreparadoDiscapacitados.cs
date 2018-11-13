using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades50
{
    public class ColectivoPreparadoDiscapacitados : Colectivo
    {
        #region Atributos

        private bool _lugarDiscapacitadosDisponible;

        #endregion

        #region Constructores

    public ColectivoPreparadoDiscapacitados() : this(false,0,0)
        {

        }

        public ColectivoPreparadoDiscapacitados(bool dispon,int linea , int movil):base(linea,movil)
        {
            this._lugarDiscapacitadosDisponible = dispon;
        }

        #endregion


        #region Sobrecarga Metodos

        public override void SacarBoleto(Pasajero p)
        {
            bool retorno = false;

            if(this is ColectivoPreparadoDiscapacitados && p.TipoDePasajero==eTipoPasajero.PasajeroConDiscapacidadMotriz)
            {
                this._lugarDiscapacitadosDisponible = true;
            }
            else
            {
                throw new Exception("No se puede subir pasajero discapacitado en colectivo normal");
            }
        }

        public override void SolicitanBajar(Pasajero p)
        {
           if(p.TipoDePasajero == eTipoPasajero.PasajeroConDiscapacidadMotriz)
            {
                Console.WriteLine("bajar rampa discapacitados y desciende pasajero");
                this._lugarDiscapacitadosDisponible = true;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
           
            sb.AppendFormat("Lugar discapacitado disponible: {0}", this._lugarDiscapacitadosDisponible);

            return sb.ToString();
        }
        #endregion
    }
}
