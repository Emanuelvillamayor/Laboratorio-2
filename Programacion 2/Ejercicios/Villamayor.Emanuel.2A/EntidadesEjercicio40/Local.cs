using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEjercicio40
{
    public class Local : Llamada
    {

        #region Atributos

        protected float costo;

        #endregion

        #region Propiedades

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

      

        #endregion

        #region Constructores

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion,destino,origen)
        {
            this.costo = costo;

        }


        #endregion

        #region Metodos

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LOCAL\n");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Costo : {0}\n", this.CostoLlamada);

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Local)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion



    }
}
