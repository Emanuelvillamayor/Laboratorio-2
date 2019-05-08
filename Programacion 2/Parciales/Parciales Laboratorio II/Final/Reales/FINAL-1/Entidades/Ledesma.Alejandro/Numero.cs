using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private int _cantidad;

        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }

        public Numero()
            : this(0)
        { }
        public Numero(int cantidad)
        {
            this._cantidad = cantidad;
        }
    }
}
