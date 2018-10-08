using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : Animal
    {
        #region Atributos

        private string _nombre;
        private static int _patas;

        #endregion

        #region Constructores

        static Caballo()
        {
            Caballo._patas = 4;
        }

        public Caballo(string nombre , int velocidadMaxima) : base(Caballo._patas,velocidadMaxima)
        {
            this._nombre = nombre;
        }

        #endregion

        #region Metodos

        #endregion


    }
}
