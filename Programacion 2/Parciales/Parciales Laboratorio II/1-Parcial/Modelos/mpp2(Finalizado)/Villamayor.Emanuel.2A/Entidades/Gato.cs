using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        #region Constructores
        public Gato(string nombre , string raza) : base(nombre,raza)
        {

        }


        #endregion

        #region Metodos
        protected override string Ficha()
        {
            string retorno = "";

            retorno += base.DatosCompletos();

            return retorno;
        }
        #endregion

        #region Operadores

        public static bool operator ==(Gato g1 , Gato g2)
        {
            bool retorno = false;
            if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
                retorno = true;

            return retorno;
        }


        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        #endregion

        #region Sobrescribir

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Gato)
            {
                if(this == (Gato)obj)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        #endregion

    }
}
