using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Jugador
    {

        #region Atributos

        private long _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioGoles;
        private int _totalGoles;

        #endregion

        #region Constructores
        private Jugador() 
        {
            this._partidosJugados = 0;
            this._promedioGoles = 0;
            this._totalGoles = 0;
        }

        public Jugador(int dni , string nombre) :this()
        {
            this._dni = dni;
            this._nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni, nombre)
        {
            this._partidosJugados = totalPartidos;
            this._totalGoles = totalGoles;
        }

        #endregion

        #region Metodos

        public string MostrarDatos()
        {
            string retorno = "";
            retorno += "DNI: " + this._dni.ToString() + " Nombre: " + this._nombre.ToString() + "\n";
            retorno += "Partidos Jugados: " + this._partidosJugados.ToString() + "\n";
            retorno += "Promedio Goles: " + this.GetPromedioGoles().ToString() + "\n";
            retorno += "Total Goles: " + this._totalGoles.ToString();

            return retorno;
        }

        public float GetPromedioGoles()
        {
            return this._partidosJugados  / (float)this._totalGoles;
        }
        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (j1._dni == j2._dni)
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
