using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades47;
namespace Entidades47
{
    public abstract class Animal
    {
        #region Atributos

        protected int _patas;

        #endregion

        #region Constructor

        public Animal()
        {

        }

        public Animal(int patas)
        {
            this._patas = patas;
        }

        #endregion

        #region Metodos

        public virtual string Caminar()
        {
            return "Este animal camina sobre 4 patas";
        }


        public abstract string Comer();


        #endregion

    }
}
