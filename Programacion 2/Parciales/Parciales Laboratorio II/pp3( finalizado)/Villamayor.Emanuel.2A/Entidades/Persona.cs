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
        private string _nombre;

        #endregion

        #region Propiedades

        public string Apellido
        {
            get { return this._apellido; }
            
        }

        public string Nombre
        {
            get { return this._nombre; }
           
        }

        #endregion

        #region Constructor
        public Persona(string nombre,string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        #endregion

        #region Metodos

        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto()
        {
            return string.Format("{0} {1}", this.Nombre, this.Apellido);
        }
     


        #endregion



    }
}
