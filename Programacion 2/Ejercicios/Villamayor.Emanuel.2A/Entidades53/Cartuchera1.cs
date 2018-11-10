using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades53
{
   public class Cartuchera1
    {
        #region Atributos

       public List<IAcciones> acciones;

        #endregion

        #region Constructores
        public Cartuchera1()
        {
            this.acciones = new List<IAcciones>();
        }

        #endregion

        #region Metodos

        public bool ProbarElementos()
        {
            bool retorno = true;
            foreach (IAcciones item in this.acciones)
            {
                if (item.UnidadesDeEscritura - 1 > 0)
                {
                    item.UnidadesDeEscritura = -1;
                }
                else if (item.UnidadesDeEscritura - 1 == 0)
                {
                    item.UnidadesDeEscritura -= 1;
                    item.Recargar(5);
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        #endregion

    }
}
