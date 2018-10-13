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

        #region Metodos

        public override string Mostrar()
        {

            return string.Format("{0} {1} Menor", base.Mostrar(), this.Menu);

        }

        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(Menor m1 , Menor m2)
        {
            bool retorno = false;

            if(m1.Nombre==m2.Nombre && m1.Apellido == m2.Apellido && m1.Menu==m2.Menu)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Menor m1, Menor m2)
        {
            return !(m1 == m2);
        }

        #endregion

        #region Sobreescritura

        public override string ToString()
        {
            return this.Mostrar();
        }

        //FALTA EL EQUALS

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
