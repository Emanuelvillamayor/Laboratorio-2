using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Tinta
    {
        #region ATRIBUTOS
        public ConsoleColor _color;
        public ETipoTinta _tipo;

        #endregion


        #region METODOS
        public static String Mostrar(Tinta tinta)
        {
            string retorno = "error";
            if (!(Object.Equals(tinta, null)))
            {
               retorno =tinta.Mostrar();
            }
            return retorno;
        }


        private  String Mostrar()
        {
            string retorno = "";
            {
                
                retorno += this._color;
                retorno += "-";
                retorno += this._tipo;
            }

            return retorno;
        }


        #endregion


        #region CONSTRUCTORES

        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.ConBrillito;
        }

        public Tinta(ConsoleColor color) : this()
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color,ETipoTinta tipo) : this(color)
        {
            this._tipo = tipo;
        }

        #endregion


        public static bool operator == (Tinta t1,Tinta t2)
        {
            bool retorno = false;
            if ((!(Object.Equals(t1,null)))  && (!(Object.Equals(t1, null))))
            {
                if (t1._color == t2._color && t1._tipo == t2._tipo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {      
            return !(t1==t2);
        }

    }
}
