using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Menor : Comensal
    {
        #region Atributos

        private eMenu _menu;

        #endregion


        #region Propiedades

        public eMenu Menu
        {
            get
            {
                return this._menu;
            }
            set
            {
                this._menu = value;
            }
        }

        #endregion

        #region Constructores

        public Menor(string nombre , string apellido) : this(nombre,apellido,eMenu.Hamburguesa) //le agrego el default
        {

        }

        public Menor(string nombre , string apellido , eMenu menu) : base(nombre,apellido)
        {
            this._menu = menu;
        }
        #endregion

        #region Enumerado

        public enum eMenu
        {
            Milanesa,
            Hamburguesa
        }

        #endregion
    }
}
