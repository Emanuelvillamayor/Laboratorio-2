using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEjercicio40
{
    public abstract class Llamada
    {
        #region Atributos

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region Propiedades

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }


        public abstract float CostoLlamada
        { get;  }

        #endregion

        #region Constructores 

        public Llamada(float duracion, string nDestino, string nOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nOrigen;
            this.nroDestino = nDestino;
        }

        #endregion

        #region Metodos

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Duracion : {0}\n", this.Duracion);
            sb.AppendFormat("Numero Origen : {0}\n", this.nroOrigen);
            sb.AppendFormat("Numero Destino : {0}\n", this.nroDestino);

            return sb.ToString();
        }


        public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            return String.Compare(l1.duracion.ToString(), l2.duracion.ToString());
        }

        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(Llamada l1 , Llamada l2)
        {
            bool retorno = false;

            if(l1.Equals(l2) && l1.nroDestino==l2.nroDestino && l1.nroOrigen==l2.nroOrigen)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }


        #endregion

    }
}
