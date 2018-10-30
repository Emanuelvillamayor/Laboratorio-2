using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public sealed class Alumno : Universitario
    {
        #region Atributos

        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #endregion




        #region Constructores

        public Alumno() : this(0,"nombre","apellido","1",ENacionalidad.Argentino,EClases.Laboratorio)
        {

        }
        public Alumno(int id , string nombre , string apellido , string dni , ENacionalidad nacionalidad , EClases claseQueToma) : this(id,nombre,apellido,dni,nacionalidad,claseQueToma,EEstadoCuenta.Deudor)
        {

        }
        public Alumno(int id , string nombre , string apellido , string dni , ENacionalidad nacionalidad , EClases claseQueToma,EEstadoCuenta estadoCuenta) : base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = estadoCuenta;
        }
       

        #endregion

        #region Metodos

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("ESTADO DE CUENTA: {0}\n", this.estadoCuenta);
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            return string.Format("TOMA CLASE DE {0}", this.claseQueToma);
        }

        #endregion

        #region Sobrecargas

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator ==(Alumno a , EClases clase) //si toma esa clase y su estado de cuenta no es Deudor
        {
            bool retorno = false;

            if(a.claseQueToma==clase && a.estadoCuenta!= EEstadoCuenta.Deudor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Alumno a, EClases clase)
        {
            return !(a == clase);
        }

        #endregion
    }
}
