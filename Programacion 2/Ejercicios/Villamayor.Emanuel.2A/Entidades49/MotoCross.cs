using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades49
{
   public class MotoCross : VehiculoDeCarrera
    {
        #region Atributos

        private short _cilindrada;

        #endregion

        #region Propiedades
        public short Cilindrada
        {
            get
            {
                return this._cilindrada;
            }
            set
            {
                this._cilindrada = value;
            }
        }

        #endregion

        #region Constructores

        public MotoCross(short numero, string escuderia) : this(numero, escuderia, 0)
        {

        }
        public MotoCross(short numero, string escuderia, short cilindrada) : base(numero, escuderia)
        {
            this._cilindrada = cilindrada;
        }

        #endregion

        #region Metodos

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("Cilindrada: {0}\n", this._cilindrada);

            return sb.ToString();
        }

        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool retorno = false;

            if ((VehiculoDeCarrera)m1 == (VehiculoDeCarrera)m2 && m1._cilindrada == m2._cilindrada)
            {
                retorno = true;
            }

            return retorno;
        }


        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
        #endregion
    }
}
