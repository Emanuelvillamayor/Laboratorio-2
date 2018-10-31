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
                try
                {
                    this.apellido = this.ValidarNombreAppelido(value);
                }
                catch (Exception e)
                {
                    throw e;
                }
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

                    this.dni = this.ValidarDni(this.Nacionalidad, value);

                }
                catch (DniInvalidoException e)
                {
                    throw e;
                }
                catch (NacionalidadInvalidadException e)
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
                catch (Exception e)
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
                catch (DniInvalidoException e)
                {
                    throw e;
                }
                catch (NacionalidadInvalidadException e)
                {
                    throw e;
                }
            }
        }

        #endregion

        #region Constructores

        public Persona() : this("nombre", "apellido", ENacionalidad.Argentino)
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this(nombre, apellido, 1, nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre,apellido,dni.ToString(),nacionalidad)
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
                            throw new NacionalidadInvalidadException("La Nacionalidad no se coincide con el numero de DNI");
                        }

                        break;

                    case ENacionalidad.Extranjero:


                        if (dni > 89999999 && dni <= 99999999)
                        {
                            retorno = dni;
                        }
                        else
                        {
                            throw new NacionalidadInvalidadException("La Nacionalidad no se coincide con el numero de DNI");
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\n", this.apellido, this.nombre);
            sb.AppendFormat("NACIONALIDAD: {0}\n", this.nacionalidad);

            return sb.ToString();
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
    }

    #endregion
}

