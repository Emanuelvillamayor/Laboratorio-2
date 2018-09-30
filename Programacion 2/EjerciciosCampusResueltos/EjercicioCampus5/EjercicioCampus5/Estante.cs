using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCampus5
{
    class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        #region Metodos
        public Producto[] GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante e)
        {
            int i;
            string retorno = "";
            retorno += e._ubicacionEstante.ToString() + "\n";
            for (i = 0; i < e._productos.Length; i++)
            {
                retorno += e._productos[i].MostrarProducto(e._productos[i]);
                retorno += "\n";
            }

            return retorno;
        }

        #region sobrecarga operadores
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            int i;
            for (i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
            {
            bool retorno = false;
            int contador = 0;
            int i;
            int capacidad = e._productos.Length;
            if(e!=p)
            {
                for(i=0;i<capacidad;i++)
                {
                    if(!(Object.Equals(e._productos[i],null)))
                    {
                        contador++;
                    }
                }
                if(contador+1<=capacidad)
                {
                    e._productos[contador] = p;
                    retorno = true;
                }
                
            }

            return retorno;
            }

      /*  public static Estante operator -(Estante e , Producto p)
        {
            if(e==p)
            {

            }
        }*/

        #endregion
        #endregion

        #region Constructor
        private Estante(int capacidad)
        {
            this._productos = new Producto[capacidad];
        }
        public Estante(int capacidad , int ubicacion):this(capacidad)
        {
            this._ubicacionEstante = ubicacion;
        }

        #endregion
    }
}
