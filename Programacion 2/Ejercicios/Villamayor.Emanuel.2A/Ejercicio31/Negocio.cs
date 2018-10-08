using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
        #region Atributos

        private PuestoAtencion _caja; //clase
        private Queue<Cliente> _clientes; //coleccion
        private string _nombre;

        #endregion
        #region Propiedades

        /*   public Cliente Cliente
           {
               get
               {
                   return this._clientes.
               }

               set
           }
           */

        #endregion

        #region Constructores
        private Negocio()
        {
            this._clientes = new Queue<Cliente>();
            this._caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this._nombre = nombre;
        }
        #endregion

        
    }
}
