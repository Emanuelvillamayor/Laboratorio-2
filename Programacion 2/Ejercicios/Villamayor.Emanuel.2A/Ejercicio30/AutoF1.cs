using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class AutoF1
    {
        #region Atributos

        private short _cantidadCombustible;//prop
        private bool _enCompetencia; //prop
        private string _ecuderia;
        private short _numero;
        private short _vueltasRestantes; //prop

        #endregion

        #region Propiedades

        public short CantidadCombustible
        {
            get { return this._cantidadCombustible; ; }
                
            set { this._cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this._enCompetencia; }

            set { this._enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return this._vueltasRestantes; }

            set { this._vueltasRestantes = value; }
        }

        #endregion
        

        #region Constructor
        public AutoF1(short numero , string escuderia)
        {
            this._enCompetencia = false;
            this._cantidadCombustible = 0;
            this._vueltasRestantes = 0;
            this._ecuderia = escuderia; //parametro
            this._numero = numero; //parametro
        }
        #endregion
                
        #region Metodos
        public string MostrarDatos()
        {
            string retorno = "";
            retorno += "Numero: " + this._numero.ToString() + " Escuderia: " + this._ecuderia.ToString()+"\n";
            retorno += "En Competencia: " + this._enCompetencia.ToString()+ "\n";
            retorno += "Cantidad Combustible: " + this._cantidadCombustible.ToString() + "\n";
            retorno += "Vueltas Restantes : " + this._vueltasRestantes.ToString();
            retorno += "Escuderia : " + this._ecuderia.ToString();
            return retorno;
        }


        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;

            if (a1._numero == a2._numero && a1._ecuderia == a2._ecuderia)
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
