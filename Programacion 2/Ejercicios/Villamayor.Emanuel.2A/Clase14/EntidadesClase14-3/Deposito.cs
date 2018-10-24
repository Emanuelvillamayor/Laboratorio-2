using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase14_3
{
    public class Deposito<T>
    {
        #region Atributos

        private int _capacidadMaxima;
        private List<T> _lista;

        #endregion

        #region Constructores

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        #endregion

        #region Metodos

        public int GetIndice(T a)
        {
            int retorno = -1;
            int tam;
            int i;

            tam = this._lista.Count;

            for (i = 0; i < tam; i++)
            {

                if (this._lista[i].Equals(a)) //el equales como se le pasa un object me permito hacer la comparacion
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }

        public bool Agregar(T a)
        {

            return this + a;
        }

        public bool Remover(T a)
        {

            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capaciad maxima: {0}\n", this._capacidadMaxima);
            sb.AppendFormat("Listado de {0} :",typeof(T).Name);

            foreach (T item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region SobrecargaOperadores

        public static bool operator +(Deposito<T> d,T a)
        {
            bool retorno = false;

            if(d._lista.Count+1<=d._capacidadMaxima )
            {
                d._lista.Add(a);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(Deposito<T> d,T a)
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
