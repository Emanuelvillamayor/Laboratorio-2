using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades47
{
    //where T : Equipo
    public class Torneo<T> where T : Equipo
    {
        #region Atributos

        private List<T> _equipos;
        private string _nombre;

        #endregion

        #region Propiedades
        public string JugarPartido
        {
            get
            {
                Random r = new Random();
                return this.CalcularPartido(this._equipos[r.Next(0, this._equipos.Count)], this._equipos[r.Next(0, this._equipos.Count)]);
            }
        }


        #endregion

        #region Constructor

       public Torneo(string nombre)
        {
            this._equipos = new List<T>();
            this._nombre = nombre;
        }
            

        #endregion

        #region Metodos

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre del Torneo: {0}\n", this._nombre);
            foreach(T item in this._equipos)
            {
                sb.AppendLine(item.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido(T t1, T t2)
        {
            Random r = new Random();

            return string.Format("{0} {1} - {2} {3}", t1.Nombre, r.Next(0, 10), t2.Nombre, r.Next(0, 10));
        }
        

        #endregion



        #region SobrecargaOperadores

        public static bool operator ==(Torneo<T> t ,T e)
        {
            bool retorno = false;

            foreach (T item in t._equipos)
            {
                if(item == e)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t,T e)
        {
       

            if(t!=e)
            {
                t._equipos.Add(e);
               
            }

            return t;
        }

        #endregion

    }
}
