using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Producto
    {
        #region Atributos

        public string nombre;
        public int stock;

        #endregion

        #region Constructores

        public Producto(string nombre, int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }

        #endregion

    }
}
