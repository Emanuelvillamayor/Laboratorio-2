using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace EntidadesAbstractas
{
    public abstract class Persona
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
                this.apellido = this.ValidarNombreAppelido(value);
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
                this.dni = this.ValidarDni(this.Nacionalidad, value);
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
                this.nombre = this.ValidarNombreAppelido(value);
            }
        }

        public string StringToDni
        {
            set
            {
                this.dni = this.ValidarDni(this.Nacionalidad, value);
            }
        }

        #endregion

        #region Constructores

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nacionalidad = nacionalidad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDni = dni;
        }

        #endregion

        #region Metodos

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = -1;
            if (dato.Length <= 8 && Int32.TryParse(dato, out dni))
            {
                int dni = Int32.Parse(dato);
                switch (nacionalidad)
                {
                    case ENacionalidad.Argentino:


                        if (dni > 0 && dni < 90000000)
                        {
                            retorno = dni;
                        }
                        else
                        {
                            throw new NacionalidadInvalidaException("La Nacionalidad no se coincide con el numero de DNI");
                        }

                        break;

                    case ENacionalidad.Extranjero:


                        if (dni > 89999999 && dni <= 99999999)
                        {
                            retorno = dni;
                        }
                        else
                        {
                            throw new NacionalidadInvalidaException("La Nacionalidad no se coincide con el numero de DNI");
                        }

                        break;

                    default:
                        break;
                }
            }
            else
            {
                throw new DniInvalidoException("dni no formato correcto");
            }
            return retorno;
        }


        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            return this.ValidarDni(nacionalidad, dato.ToString());
        }



        private string ValidarNombreAppelido(string dato)
        {
            bool validar = true;

            foreach (char item in dato)
            {
                if (!(char.IsLetter(item)))
                {
                    validar = false;
                    break;
                }
            }

            if (validar != true)
            {
                //Caso contrario, no se cargará

                throw new Exception("no se pudo cargar ,error en el nombre");
            }

            return dato;
        }

        #endregion

        #region SobrecargasMetodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\n", this.apellido, this.nombre);
            sb.AppendFormat("NACIONALIDAD: {0}\n", this.nacionalidad);

            return sb.ToString();
        }


        #endregion

        #region Enumerados

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }


        #endregion
    
    }

}

