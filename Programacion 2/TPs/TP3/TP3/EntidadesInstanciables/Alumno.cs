using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
namespace EntidadesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #endregion

        #region Constructores

        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,Universidad.EClases claseQueToma) :base(id, nombre, apellido, dni, nacionalidad)
        {
           this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad,claseQueToma)
        {
            
            this.estadoCuenta = estadoCuenta;
        }


        #endregion

        #region Metodos

       
        protected override string ParticiparEnClase()
        {
            return string.Format("TOMA CLASE DE {0}", this.claseQueToma);
        }

        #endregion

        #region SobrecargasMetodos

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
         
            switch(this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    sb.AppendLine("ESTADO DE CUENTA: Cuota al dia");
                    break;
                case EEstadoCuenta.Becado:
                    sb.AppendLine("ESTADO DE CUENTA:  cuota becada");
                    break;
                default:
                    sb.AppendLine("ESTADO DE CUENTA: cuota con deuda");
                    break;

            }
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(Alumno a,Universidad.EClases clase) //si toma esa clase y su estado de cuenta no es Deudor
        {
            bool retorno = false;

            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                retorno = true;
            }

            return retorno;
        }


        // Un Alumno será distinto a un EClase sólo si no toma esa clase / deja de lado el estadoCuenta
        public static bool operator !=(Alumno a,Universidad.EClases clase)
        {
            bool retorno = false;

            if (a.claseQueToma != clase)
            {
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region Enumerados

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        #endregion

    }
}
