using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase14
{
    //agregar uno dentro del otro clase
    public class Auto
    {
        #region Atributos

        private string _color;
        private string _marca;

        #endregion

        #region Propiedades

        public string Color
        {
            get
            {
                return this._color;
            }

        }

        public string Marca
        {
            get
            {
                return this._marca;
            }
        }

        #endregion

        #region Constructores
        public Auto(string color, string marca)
        {
            this._marca = marca;
            this._color = color;
        }

        #endregion

        #region Metodos

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Auto)
            {
                retorno = this == (Auto)obj;
            }
            return retorno;
        }

        public override string ToString()
        {

            return string.Format("Marca: {0} - Color: {1}", this.Marca, this.Color);
        }

        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(Auto a , Auto b)
        {
            bool retorno = false;

            if(a._color == b._color && a._marca==b._marca)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        #endregion



    }
}
