using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Deposito
    {
        #region Atributos

        public Producto[] productos;

        #endregion

        #region Constructores

        public Deposito() : this(3)
        {
           
        }
        public Deposito(int cant)
        {
            this.productos = new Producto[cant];
        }

        #endregion

        #region SobrecargaOperadores

        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            Producto[] retorno = new Producto[3];
            bool flag = false;

            foreach (Producto item in d1.productos)
            {
                for (int i = 0; i < retorno.Length; i++)
                {
                    if (item == retorno[i])
                    {
                        retorno[i].stock = retorno[i].stock + 1;
                        flag = true;
                    }
                }

            }

            return retorno;
        }

        #endregion
    }
}
