using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCampus5
{
    class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;


        #region Metodos
        public string GetMarca()
        {
            return this._marca;
        }
        public float GetPrecio()
        {
            return this._precio;
        }

         public  string MostrarProducto(Producto p)
        {
            string retorno = "";
            retorno += p._marca.ToString() + p._codigoDeBarra.ToString() + p._precio.ToString();
            return retorno;
        }
        #region Sobrecarga operadores
        public static bool operator ==(Producto p , string marca)
        {
            bool retorno = false;
            if (p._marca == marca)
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Producto p , string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p, Producto p2)
        {
            bool retorno = false;
            if (!Object.Equals(p, null) && !Object.Equals(p2, null))
            {
                if (p._marca == p2._marca && p._codigoDeBarra == p2._codigoDeBarra)
                    retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Producto p, Producto p2)
        {
            return !(p == p2);
        }

        public static explicit operator string (Producto p)
        {
            return p._codigoDeBarra;
        }
        #endregion

        #endregion


        #region Constructor
        public Producto(string marca, string codigo, float precio)
        {
            this._codigoDeBarra = codigo;
            this._marca = marca;
            this._precio = precio;

        }
        #endregion

    }
}
