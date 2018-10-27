using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades48
{
   public class Contabilidad <T,U>

        where U : new() //indica que U debe tener un constructor por defecto
    {
        #region Atributos

        private List<T> _egresos;
        private List<U> _ingresos;

        #endregion

        #region Constructor

        public Contabilidad()
        {
            this._egresos = new List<T>();
            this._ingresos = new List<U>();
        }

        #endregion

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c,T egreso)
        {
            c._egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c._ingresos.Add(ingreso);
            return c;
        }


    }
}
