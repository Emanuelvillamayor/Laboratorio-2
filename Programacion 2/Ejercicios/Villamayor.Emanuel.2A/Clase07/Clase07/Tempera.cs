using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class Tempera
    {
        #region ATRIBUTOS

        private sbyte _cantidad;
        private ConsoleColor _color;
        private string _marca;

        #endregion

        #region METODOS
     

        private string mostrar()
        {
            string retorno ="";
            retorno += this._color + " " + this._marca + " " + this._cantidad;
            return retorno;
        }

        #region SOBRECARGAS

        public static implicit operator string (Tempera temp)
        {
            return temp.mostrar();
        }

        public static explicit operator sbyte(Tempera temp)
        {
            return temp._cantidad;
        }

        public static  bool operator ==(Tempera temp1,Tempera temp2)
        { 
          bool retorno = false;

            if (temp1._color == temp2._color && temp1._marca == temp2._marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Tempera temp1, Tempera temp2)
        {
            return !(temp1 == temp2);
        }

        public static Tempera operator +(Tempera temp1 , sbyte cant)
        {                
            temp1._cantidad +=cant;
            return temp1;
        }

        public static Tempera operator +(Tempera temp1 , Tempera temp2)
        {
            Tempera retorno = new Tempera(temp1._cantidad,temp1._color,temp1._marca);
          
            if(temp1==temp2)
            {
                retorno._cantidad += temp2._cantidad;
            }

            return retorno;
        }


        #endregion

        #endregion

        #region CONSTRUCTORES
        public Tempera(sbyte cant,ConsoleColor color,string marca)
        {
            this._cantidad = cant;
            this._color = color;
            this._marca = marca;           
        }



        #endregion

       
    }
}
