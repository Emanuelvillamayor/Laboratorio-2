using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades35
{
    class Jugador : Persona
    {

        #region Atributos

     
        private int _partidosJugados;
        private int _totalGoles;

        #endregion

        #region Propiedades
        public int PartidosJugados
        {
            get
            {
                return this._partidosJugados;
            }

        }

        public int TotalGoles
        {
            get
            {
                return this._totalGoles;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return this._partidosJugados / (float)this._totalGoles;
            }

        }
        #endregion

        #region Constructores
  
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : base(dni,nombre)
        {
            this._partidosJugados = totalPartidos;
            this._totalGoles = totalGoles;
        }

        #endregion

        #region Metodos

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JUGADOR");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("Partidos Jugados : {0}\n",this.PartidosJugados);
            sb.AppendFormat("Total Goles : {0}\n", this._totalGoles);
            sb.AppendFormat("Promedio goles : {0}", this.PromedioGoles);

            return sb.ToString();
        }


        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (j1.Dni == j2.Dni)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        #endregion


    }
}
