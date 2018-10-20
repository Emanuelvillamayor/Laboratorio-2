using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades35
{
    class DirectorTecnico : Persona
    {
        #region Atributos

        private DateTime _fechaNacimiento;

        #endregion

        #region Propiedades

        public DateTime FechaNacimiento
        {
            get
            {
                return this._fechaNacimiento;
            }
            set
            {
                this._fechaNacimiento = value;
            }
        }

        #endregion

        #region Constructores

        public DirectorTecnico(string nombre): this(nombre,DateTime.Now)
        {

        }

        public DirectorTecnico(string nombre , DateTime fechaNacimiento) : base(nombre)
        {
            this._fechaNacimiento = fechaNacimiento;
        }

        #endregion

        #region Metodos

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DIRECTOR TECNICO");
           sb.AppendLine( base.MostrarDatos());
           sb.AppendFormat("Fecha Nacimiento : {0}\n", this._fechaNacimiento);

            return sb.ToString();
        }

        #endregion


        #region SobrecargaOperadores

        public static bool operator ==(DirectorTecnico d1 , DirectorTecnico d2)
        {

            bool retorno = false;

            if(d1.Dni== d2.Dni)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
        #endregion
    }
}
