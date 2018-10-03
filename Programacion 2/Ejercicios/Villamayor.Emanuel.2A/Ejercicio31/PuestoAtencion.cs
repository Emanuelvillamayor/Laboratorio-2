using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio31
{
    class PuestoAtencion
    {
        #region Atributos

        private static int _numeroActual;
        private Puesto _puesto;

        #endregion

        #region Propiedades

        public static int NumeroActual
        {
            get
            {
                _numeroActual = _numeroActual + 1;
                return _numeroActual;
            }  
        }

        #endregion

        #region Constructores

        private PuestoAtencion()
        {
            _numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto) : this()
        {
            this._puesto = puesto;
        }

        #endregion

        #region Metodos
        public bool Atender(Cliente cli)
        {
            bool retorno = false;

            Thread.Sleep(2000);
            retorno = true;

            return retorno;
        }


        #endregion
    }
}
