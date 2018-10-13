using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos

        private string _apellido;
        private string _documento;
        private string _nombre;

        #endregion

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }

     /*   public string Documento
        {
            get
            
            set
            {

            }
        }


    */
        #endregion


    }
}
