using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades43
{
  public  class AutoF1 : VehiculoDeCarrera
    {
        #region Atributos

        private short _caballosDeFuerza;

        #endregion

        #region Propiedades


        public short CaballosDeFuerza
        {
            get
            {
                return this._caballosDeFuerza;
            }
            set
            {
                this._caballosDeFuerza = value;
            }
        }

        #endregion


        #region Constructor
        public AutoF1(short numero, string escuderia) : this(numero, escuderia, 0)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosFuerza) : base(numero, escuderia)
        {
            this._caballosDeFuerza = caballosFuerza;
        }
        #endregion

        #region Metodos
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("Caballos de Fuerza", this.CaballosDeFuerza);

            return sb.ToString();
        }


        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;

            if ((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.CaballosDeFuerza == a2.CaballosDeFuerza)
                retorno = true;


            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion



    }
}
