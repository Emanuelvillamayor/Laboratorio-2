using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        #region ATRIBUTOS

        private int cantidadSumas;

        #endregion

        #region METODOS

        public long Sumar(long a, long b)
        {
            long retorno;

            this.cantidadSumas++;

            retorno = a + b;
            return retorno;
        }

        public string Sumar(string a, string b)
        {
            string retorno = "";

            this.cantidadSumas++;

            retorno += a += b;
            return retorno;
        }

        public int GetCantSumas()
        {
            return this.cantidadSumas;
        }

        #region SOBRECARGAR OP.
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }


        public static long operator  +(Sumador sumador1, Sumador sumador2)
        {
            long retorno = sumador1.GetCantSumas() + sumador2.GetCantSumas();

            return retorno;

        }

        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            bool retorno = false;

            if(sumador1.GetCantSumas()==sumador2.GetCantSumas())
            {
                retorno = true;
            }

            return retorno;
        }

        #endregion
        #endregion

        #region CONSTRUCTORES

        public Sumador(int cantSumas)
        {
            this.cantidadSumas = cantSumas;
        }

        public Sumador() : this(0) //reutiliza al otro constructor para ahorrar codigo
        {
          
        }


        #endregion
    }
}
