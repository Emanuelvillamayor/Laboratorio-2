using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Perros : Animal
    {
        #region Atributos

        private static int _patas;
        private Razas _raza;

        #endregion

        #region Constructores
        static Perros()
        {
            Perros._patas = 4;
        }

        public Perros(int velocidadMaxima): this(Razas.OvejeroAleman,10) //por default agregue raza ovejeroaleman
        {

        }

        public Perros(Razas raza , int velocidadMaxima) : base(Perros._patas,velocidadMaxima)
        {
            this._raza = raza;
        }

        #endregion

        #region Metodos
        public string MostrarPerro()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Perro");
            sb.AppendFormat("Raza : {0}\n", this._raza);
           
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }


        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(Perros p1 , Perros p2)
        {
            bool retorno = false;

            if(p1._raza==p2._raza && p1._velocidadMaxima==p2._velocidadMaxima)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Perros p1, Perros p2)
        {
            return !(p1 == p2);
        }
        #endregion


        #region Enumerados
        public enum Razas
        {
            Galgo,
            OvejeroAleman
        }


        #endregion
    }
}
