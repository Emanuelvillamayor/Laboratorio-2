using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades50
{
    public class ColectivoNormal : Colectivo
    {
        #region Constructor

        public ColectivoNormal(int linea , int movil): base(linea,movil)
        {

        }

        #endregion


        public override void SacarBoleto(Pasajero p)
        {
            if(p.TipoDePasajero=eTipoPasajero.PasajeroConDiscapacidadMotriz)
            {
                throw new Exception("No se puede subir pasajero discapacitado en colectivo normal");
            }

        }

        public override void SolicitanBajar(Pasajero p)
        {
            throw new NotImplementedException();
        }
    }
}
