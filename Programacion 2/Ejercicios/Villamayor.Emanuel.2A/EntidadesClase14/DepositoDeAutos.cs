using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase14
{
   public class DepositoDeAutos
    {
        #region Atributos

        private int _capacidadMaxima;
        private List<Auto> _lista;

        #endregion

        #region Constructor

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        #endregion

        #region Metodos

        public bool Agregar(Auto a)
        {
   
            return this + a;
        }

        public bool Remover(Auto a)
        {

            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capaciad maxima: {0}\n", this._capacidadMaxima);
            sb.AppendLine("Listado de Autos:");

            foreach(Auto item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion

        #region SobrecargaOperadores

        public static bool operator +(DepositoDeAutos d , Auto a)
        {

            bool retorno = false;

            if (d._lista.Count + 1 <= d._capacidadMaxima)
            {
               d._lista.Add(a);
                retorno = true;
            }

            return retorno;
        }

        private int GetIndice(Auto a)
        {
            int retorno = -1;
            int tam;
            int i;

            tam = this._lista.Count;

            for(i=0;i<tam;i++)
            {

                if(this._lista[i]== a)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator - (DepositoDeAutos d , Auto a)
        {
            
            bool retorno = false;
            int indice;

            indice = d.GetIndice(a);

            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }

            return retorno;
        }




        #endregion

    }
}
