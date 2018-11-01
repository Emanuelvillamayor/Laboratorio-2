using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//xmlSerializer -> tiene metodo serialize  y metodo deserealize  transformar objeto vivo en memoria para volverlo a utilizarlo
//dos parametros uno que sepa escribir en xml y el tipo a serializar , para deserealizar solo el parametro para leer

//xmlTextWriter ->ademas del path necesita en el otro parametro un enumerado que establece el juego de caracteres a escribir encoding.UTF-8
//xmlTextReader ->solo necesita el path completo
namespace Entidades
{
   public abstract class Universitario : Persona
    {
        #region Atributos

        private int legajo;

        #endregion

        #region Constructores

        public Universitario() 
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

         if (obj is Universitario)   
           {
                if(this == (Universitario)obj)
                {
                    retorno = true;
                }             
            }
            return retorno;
        }

        public static bool operator ==(Universitario pg1,Universitario pg2) //si son del mismo Tipo y su Legajo o DNI son iguales
        {
            bool retorno = false;
          
                if(pg1.legajo==pg2.legajo || pg1.DNI == pg2.DNI)
                {
                    retorno = true;
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
