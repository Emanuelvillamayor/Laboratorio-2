using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades37
{
    class Provincial : Llamada
    {
        #region Atributos

        protected EFranja franjaHoraria;

        #endregion

        #region Propiedades

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
         }

        #endregion

        #region Constructores

        public Provincial(EFranja miFranja , Llamada llamada) : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen , EFranja miFranja, float duracion , string destino): this(miFranja,new Llamada(duracion,destino,origen))
        {

        }

        #endregion

        #region Metodos

        private float CalcularCosto()
        {
            float retorno = 0;

            if(this.franjaHoraria == EFranja.Franja_1)
            {
                retorno = 0.99f * base.duracion;
            }
            
           else if(this.franjaHoraria == EFranja.Franja_2)
            {
                retorno = 1.25f * base.duracion;
            }
            else if (this.franjaHoraria == EFranja.Franja_3)
            {
                retorno = 0.66f * base.duracion;
            }

            return retorno;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("PROVINCIAL");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Franja Horaria : {0}\n", this.franjaHoraria);
            sb.AppendFormat("Costo: {0}", this.CostoLlamada);

            return sb.ToString();    
        }
        #endregion

    }
}
