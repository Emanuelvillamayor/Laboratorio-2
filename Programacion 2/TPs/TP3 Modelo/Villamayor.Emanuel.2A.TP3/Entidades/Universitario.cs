using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public abstract class Universitario : Persona
    {
        #region Atributos

        private int legajo;

        #endregion

        #region Constructores
        public Universitario() : this(0,"nombre","apellido","1",ENacionalidad.Argentino)
        {

        }
        public Universitario(int legajo ,string nombre , string apellido,string dni,ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());         
            sb.AppendFormat("LEGAJO NúMERO: {0}\n", this.legajo);

            return sb.ToString();
        }

        protected abstract string ParticiparEnClase();

        

        #endregion

        #region SobrecargaOperadores

        public override bool Equals(object obj)
        {
            bool retorno = false;

          //  if(obj is Universitario && this is Universitario)
                if (obj is Universitario)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Universitario pg1,Universitario pg2) //si son del mismo Tipo y su Legajo o DNI son iguales
        {
            bool retorno = false;

            if(pg1.Equals(pg2))
            {
                if(pg1.legajo==pg2.legajo || pg1.DNI == pg2.DNI)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion


    }
}
