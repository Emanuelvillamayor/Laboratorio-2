using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region Atributos

        private bool _esCapitan;
        private int _numero;

        #endregion

        #region Propiedades

        public bool EsCapitan
        {
            get { return this._esCapitan; }

            set { this._esCapitan = value; }
        }

        public int Numero
        {
            get { return this._numero; }

            set { this._numero = value; }
        }

        #endregion

        #region Constructores
        public Jugador(string nombre , string apellido) : this(nombre,apellido,0,false)
        {

        }
        
        public Jugador(string nombre , string apellido , int numero , bool capitan) :base(nombre,apellido)
        {
            this.Numero = numero;
            this.EsCapitan = capitan;
        }


        #endregion

        #region Metodos

        protected override string FichaTecnica()
        {
            string retorno = "";

          if(this.EsCapitan==true)
            {
                retorno += base.NombreCompleto() + ",capitan del equipo,camiseta numero " + this.Numero.ToString();
            }
          else
            {
                retorno += base.NombreCompleto() + "camiseta numero " + this.Numero.ToString();
            }

            return retorno;
        }

        #endregion

        #region Operadores
        
        public static bool operator ==(Jugador j1 , Jugador j2)
        {
            bool retorno = false; 

            if(j1.Nombre==j2.Nombre && j1.Apellido==j2.Apellido && j1.Numero==j2.Numero)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int (Jugador j)
        {
            return j.Numero;
        }


        #endregion

        #region Sobreescritura
        public override string ToString()
        {
            return this.FichaTecnica();
        }


        #endregion

    }
}
