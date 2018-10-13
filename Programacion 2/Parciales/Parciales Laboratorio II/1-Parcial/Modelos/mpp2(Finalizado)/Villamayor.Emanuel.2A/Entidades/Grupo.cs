using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Grupo
    {
        #region atributos

        private List<Mascota> _manada;
        private string _nombre;
        private  TipoManada _tipo;

        #endregion

        #region Propiedades

        public  TipoManada Tipo
        {
            set { this._tipo = value; }
        }

        #endregion

        #region Constructores

      

        private Grupo()
        {
            this._manada = new List<Mascota>();
            this.Tipo = TipoManada.única;
        }

        public Grupo(string nombre) :this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre , TipoManada tipo) :this(nombre)
        {
            this.Tipo = tipo;
        }
        #endregion

        #region Operadores

        public static bool operator == (Grupo e ,Mascota j)
        {
            bool retorno = false;

            foreach(Mascota item in e._manada)
            {
                if(item==j)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }


        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static Grupo operator + (Grupo e , Mascota j)
        {
            if(e!=j)
            {
                e._manada.Add(j);
            }

            return e;
        }

        public static Grupo operator - (Grupo e, Mascota j)
        {
            if(e==j)
            {
                e._manada.Remove(j);
            }

            return e;
        }


        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("**{0} {1}**\n",e._nombre,e._tipo);
            sb.AppendLine("Integrantes");

            foreach (Mascota item in e._manada)
            {
                sb.AppendLine(item.ToString());             
            }

            return sb.ToString();
        }
        #endregion

        #region Enumerado

        public enum TipoManada
        {
            única,
            mixta
        }

        #endregion
    }
}
