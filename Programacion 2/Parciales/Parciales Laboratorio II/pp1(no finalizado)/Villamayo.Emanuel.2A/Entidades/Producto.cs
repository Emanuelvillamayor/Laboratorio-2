using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {             
        #region Atributos

        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;


        #endregion

        #region Propiedades
        public abstract float CalcularCostoDeProduccion
        {
            get;
        }

        public EMarcaProducto Marca
        {
            get { return this._marca; }
        }

        public float Precio
        {
            get { return this._precio; }
        }

        #endregion


        #region Metodos

        private static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Codigo de Barras: {0}\r\n", p._codigoBarra);
            sb.AppendFormat("MARCA: {0}\r\n", p._marca);
            sb.AppendFormat("PRECIO: {0}\r\n", p._precio);
            sb.AppendLine("---------------------------------");

            return sb.ToString();

        }

        public virtual string Consumir()
        {
            return (string)this;
        }

        #endregion


        #region Sobrecarga Operadores
        public static bool operator ==(Producto p1,EMarcaProducto m)
        {
            bool retorno = false;

            if (p1._marca == m)
                retorno = true;

            return retorno;     
        }

        public static bool operator !=(Producto p1, EMarcaProducto m)
        {
            return !(p1 == m);
        }


        public static explicit operator int (Producto p)
        {
            return p._codigoBarra;
        }

        public static implicit operator string(Producto p)
        {
            return Producto.MostrarProducto(p);
        }
        #endregion

        public enum EMarcaProducto
        {
            Manaos,
            Pitusas,
            Naranjú,
            Diversión,
            Swift,
            Favorita

        }
    }
}
