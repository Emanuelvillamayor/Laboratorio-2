using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades35
{
    public class Persona
    {
        #region Atributos

        private long _dni;
        private string _nombre;

        #endregion

        #region Propiedades

        public long Dni
        {
            get
            {
                return Dni;
            }
            set
            {
                this._dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        #endregion

        #region Constructores

        public Persona(string nombre) : this(00000000,nombre)
        {
            
        }

        public Persona( long dni , string nombre )
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }

        #endregion

        public virtual string MostrarDatos()
        {
            return string.Format("Nombre : {0} \nDni: {1}\n", this.Nombre, this.Dni);
        }


    }
}
