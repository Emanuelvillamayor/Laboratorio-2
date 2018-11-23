using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;
using Entidades.Externa.Sellada;
namespace EntidadesClase20
{
   public class PersonaExternaHeredada : PersonaExterna
    {
        #region Propiedades

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public int Edad
        {
            get
            {
                return this._edad;
            }
        }

        public Entidades.Externa.ESexo Sexo
        {
            get
            {
                return this._sexo;
            }
        }


        #endregion

        #region Constructores

        public PersonaExternaHeredada(string nombre , string apellido , int edad , Entidades.Externa.ESexo sexo): base(nombre,apellido,edad,sexo)
        {

        }

        #endregion

        #region Metodos

        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}\n", this._nombre);
            sb.AppendFormat("Apellido: {0}\n",this._apellido);
            sb.AppendFormat("Edad: {0}\n", this._edad);
            sb.AppendFormat("Sexo: {0}\n", this._sexo);

            return sb.ToString();
        }

        #endregion
    }
}
