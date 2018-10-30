using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract  class Persona
    {
        #region Atributos

        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #endregion

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                try
                {

                    this.dni = this.ValidarDni(this.Nacionalidad,value);
                }
               catch(DniInvalidoException e)
                {
                    throw e;
                }
                catch(NacionalidadInvalidadException e)
                {
                    throw e;
                }
            }
        }

    
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

             set
            {
                try
                {
                    this.nombre = this.ValidarNombreAppelido(value);
                }
                catch(NacionalidadInvalidadException e)
                {
                    throw e;
                }
            }
        }

        public string StringToDni
        {
            set
            {
                try
                {
                    this.dni = this.ValidarDni(this.Nacionalidad, value);
                }
                catch(DniInvalidoException e)
                {
                    throw e;
                }
                catch(NacionalidadInvalidadException e)
                {
                    throw e;
                }
            }
        }

        #endregion

        #region Constructores

        public Persona() : this("nombre","apellido",ENacionalidad.Argentino)
        {

        }

        public Persona(string nombre , string apellido , ENacionalidad nacionalidad) : this(nombre , apellido,1,nacionalidad)
        {
       
        }

        public Persona(string nombre , string apellido , int dni , ENacionalidad nacionalidad)
        { 
          
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) 
        {
            
            this.Nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
           this.StringToDni = dni;
        }
    #endregion

    #region Metodos

    private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno = -1;

            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato > 0 && dato < 90000000)
                    {
                        retorno = dato;
                    }
                    else
                    {
                        throw new DniInvalidoException("Error de formato");
                    }

                    break;

                case ENacionalidad.Extranjero:

                    if(dato>89999999 && dato<=99999999)
                    {
                        retorno = dato;
                    }
                    else
                    {
                        throw new DniInvalidoException("Error de formato");
                    }

                    break;

                default:

                    throw new NacionalidadInvalidadException("Nacionalidad Erronea");
            }
            return retorno;

        }


        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            return this.ValidarDni(nacionalidad, Convert.ToInt32(dato));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\n", this.apellido, this.nombre);
            sb.AppendFormat("NACIONALIDAD: {0}\n", this.nacionalidad);

            return sb.ToString();
        }

        private string ValidarNombreAppelido(string dato)
        {
            if(dato is string)
            {

            }
            else
            {
                throw new NacionalidadInvalidadException("nombre erroneo");
            }

            return dato;
        }

        #endregion
    }
}
