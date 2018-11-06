using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades51
{
    public interface IGuardar<T>
    {
        #region Propiedades

        string RutaDeArchivo
        {
            get;
            set;
        }

        #endregion

        #region Metodos

        bool Guardar();

        T Leer();


        #endregion
    }
}
