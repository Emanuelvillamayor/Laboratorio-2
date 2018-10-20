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

         
          /*  if(tipo == ETipoLlamada.Local)
            {
                foreach(Local item in this._listaDeLlamadas)
                {
                    if (item is Local)
                    {
                        retorno += item.CostoLlamda;
                    }
                }
            }*/

    return retorno;
        }

        #endregion

    }
}
