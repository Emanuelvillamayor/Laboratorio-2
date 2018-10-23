using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase14_2
{
  public  class DepositoDeCocinas
    {
        #region Atributos

        private int _capacidadMaxima;
        private List<Cocina> _lista;

        #endregion

        #region Constructores

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        #endregion

        #region Metodos
        public bool Agregar(Cocina c)
        {
            return this + c;
        }
        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad maxima: {0}\n", this._capacidadMaxima);
            sb.AppendLine("Listado de Cocinas");
            
            foreach(Cocina item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        #endregion

        public static bool operator +(DepositoDeCocinas d , Cocina c)
        {
            bool retorno = false;

            if (d._lista.Count + 1 <= d._capacidadMaxima)
            {
                d._lista.Add(c);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Cocina c)
        {
            int retorno = -1;
            int tam;
            int i;

            tam = this._lista.Count;

            for (i = 0; i < tam; i++)
            {

                if (this._lista[i] == c)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;

        }

        public static bool operator -(DepositoDeCocinas d , Cocina c)
        {
            bool retorno = false;
            int indice;

            indice = d.GetIndice(c);

            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }

            return retorno;
        }

  

    }
}
