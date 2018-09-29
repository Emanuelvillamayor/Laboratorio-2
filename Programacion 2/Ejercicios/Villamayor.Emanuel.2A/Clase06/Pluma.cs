using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Pluma //
    {
        #region  ATRIBUTOS
        private string _marca;
        private int _cantidad;
        private Tinta _tinta;  //este atributo se supone que ya tendria que venir inicializado

        #endregion

        #region CONSTRUCTOR

        public Pluma()
        {
            this._marca = "Sin Marca";
            this._cantidad = 0;
            this._tinta = null;
        }

        public Pluma(string marca) : this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, int cant) : this(marca)
        {
            this._cantidad = cant;
        }

        public Pluma(string marca, int cant,Tinta tint) : this(marca,cant)
        {
            this._tinta= tint;
        }

        #endregion

        #region METODOS

        private string Mostrar() //llama a la funcion mostrar tinta para concatenar todo
        {
            string retorno = "";
            retorno += Tinta.Mostrar(this._tinta);
            retorno += "-"+ this._marca.ToString() + "-" + this._cantidad.ToString();

            return retorno;
         
        }

        #region SOBRECARGA OPERADORES

        public static implicit operator string (Pluma plum) //lo llamamos desde el main y muestra directamente
       {
            return plum.Mostrar();
       }

        public static bool operator ==(Pluma plum, Tinta tint)
        {
            bool retorno = false;         
           
                if (plum._tinta == tint)
                {
                    retorno = true;
                }
            
            return retorno;
        }

        public static bool operator !=(Pluma plum, Tinta tint)
        {
            return !(plum == tint);
        }

        public static Pluma operator +(Pluma plum, Tinta tint)
        {
            
            if(plum==tint)
            {
                plum._cantidad += 10;
                if(plum._cantidad >100)
                {
                    plum._cantidad = 100;
                }
            }

            return plum;
        }

        public static Pluma operator -(Pluma plum, Tinta tint)
        {
         
            if (plum == tint)
            {
                plum._cantidad -= 10;
                if (plum._cantidad <0 )
                {
                    plum._cantidad = 0;
                }
            }

            return plum;
        }
        #endregion

        #endregion


    }
}
