using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades37
{
    public class Local : Llamada
    {
        #region Atributos

        protected float costo;

        #endregion

        #region Propiedades

        public float CostoLlamda
        {
            get
            {
              return  this.CalcularCosto();
            }
        }


        #endregion

        #region Constructores

        public Local(Llamada llamada, float costo) : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : this (new Llamada(duracion,destino,origen),costo)
        {
        

        }


        #endregion

        #region Metodos

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LOCAL\n");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Costo : {0}\n", this.CostoLlamda);

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }

        #endregion
    }
}
