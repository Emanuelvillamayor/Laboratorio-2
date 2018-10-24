using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    public abstract class Sobreescrito
    {
        #region Atributos

        protected string miAtributo;

        #endregion

        #region Propiedades
        public abstract string MiPropiedad
        {
            get;
          
        }
   
        #endregion

        #region Constructores

        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            return string.Format("¡Este es mi metodo ToString sobreescrito!");
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Sobreescrito)
            {
                retorno = true;
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }

        public abstract string MiMetodo();



        #endregion
    }
}
