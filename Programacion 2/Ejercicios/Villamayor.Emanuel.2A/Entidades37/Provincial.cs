using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades37
{
   public  class Provincial : Llamada
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

        public Provincial(EFranja miFranja , Llamada llamada) : this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroOrigen)
        {
            
        }

        public Provincial(string origen , EFranja miFranja, float duracion , string destino): base(duracion,destino,origen)
        {
          this.franjaHoraria = miFranja;
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
