using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Carrera 
    {
        #region Atributos

        private List<Animal> _animales;
        private int _corredoresMax;

        #endregion

        #region Constructores

        private Carrera()
        {
            this._animales = new List<Animal>();
        }

        public Carrera(int corredoresMax):this()
        {
            this._corredoresMax = corredoresMax;
        }

        #endregion

        #region Mostrar
        public static string MostrarCarrera(Carrera c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CARRERA");

            sb.AppendFormat("Maximo de corredores: {0}\n", c._corredoresMax);
           
            foreach(Animal item in c._animales)
            {
                sb.AppendLine(item.MostrarDatos());
                
            }

            return sb.ToString();
        }


        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(Carrera c, Animal a)
        {
            bool retorno = false;

            foreach(Animal item in c._animales)
            {
                if(item.GetType() ==a.GetType() && item==a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Carrera c, Animal a)
        {
            return !(c == a);
        }

        public static Carrera operator +(Carrera c , Animal a)
        {
            if(c!=a)
            {
                if(c._animales.Count+1 <= c._corredoresMax)
                {
                    c._animales.Add(a);
                }
            }

            return c;
        }
        #endregion
    }
}
