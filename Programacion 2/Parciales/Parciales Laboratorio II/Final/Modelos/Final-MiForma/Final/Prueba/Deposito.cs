using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Deposito
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

        //Se debe poder sumar los Array de los dos depósitos (con la sobrecarga de un operador en la clase Deposito) y guardar 
        //el valor que retorna en un Array de Productos, recordar que si un producto está en los dos Arrays, 
        //se debe sumar el stock y no agregar dos veces al mismo producto.
        //Mostrar el contenido del array resultante (nombre y stock)

        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            Producto[] retorno = new Producto[3];
          

            foreach(Producto item in d1.productos)
            {
                for (int i = 0; i < retorno.Count(); i++)
                {
                    if (item == retorno[i])
                    {
                        retorno[i].stock = retorno[i].stock + 1;
                        continue;
                    }        
                    else
                    {
                        retorno[i] = item;
                        break;
                    }
                }
             
            }

            return retorno;
        }

        #endregion
    }
}
