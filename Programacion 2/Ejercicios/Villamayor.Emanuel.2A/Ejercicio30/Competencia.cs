using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Competencia
    {

        #region Atributos
        private short _cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> _competidores;

        #endregion

        #region Constructores

        private Competencia()
        {
            this._competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this._cantidadCompetidores = cantidadCompetidores;
        }

        #endregion
                
        #region Metodos

        public string MostrarDatos()
        {
            string retorno = "";

            foreach(AutoF1 item in this._competidores)
            {
                retorno += item.MostrarDatos();
                retorno += "\n\n";
            }

            return retorno;

        }
        #endregion

        #region Sobrecarga de Operadores

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            Random rn = new Random();

            if (c != a)
            {    
                    if (c._competidores.Count + 1 <= c._cantidadCompetidores)
                    {
                     a.EnCompetencia = true;
                     a.VueltasRestantes = c.cantidadVueltas;
                     a.CantidadCombustible = (short)rn.Next(15, 100);
                     c._competidores.Add(a);
                        retorno = true;
                    }              
            }

            return retorno;
        }

        public static bool operator -(Competencia c , AutoF1 a)
        {
            bool retorno = false;

            if(c==a)
            {
                c._competidores.Remove(a);
                retorno = true;
            }

            return retorno;

        }

     public static bool operator ==(Competencia c , AutoF1 a)
        {
            bool retorno = false;
            int i;

            for (i = 0; i < c._competidores.Count; i++)
            {
                if (a == c._competidores[i])
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
        #endregion

    }
}
