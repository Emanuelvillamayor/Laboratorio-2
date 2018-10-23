using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades37
{
    class Centralita
    {
        #region Atributos

        private List<Llamada> _listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region Propiedades


        #endregion

        #region Constructores

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion

        #region Metodos

        private float CalcularGanancia( ETipoLlamada tipo)
        {
            float retorno = 0;

            foreach(Llamada item in this._listaDeLlamadas)
            {
                switch (tipo)
                {
                    case ETipoLlamada.Local:
                        if(item is Local)
                        {
                            retorno += ((Local)item).CostoLlamda;
                        }
                        break;

                    case ETipoLlamada.Provincial:

                        if (item is Provincial)
                        {
                            retorno += ((Provincial)item).CostoLlamada;
                        }
                        break;

                    default:
                        if(item is Local)
                        {
                            retorno += ((Local)item).CostoLlamda;
                        }

                        if(item is Provincial)
                        {
                            retorno += ((Provincial)item).CostoLlamada;
                        }
                        break;
                       
                }             
            }
    return retorno;
        }

        #endregion

    }
}
