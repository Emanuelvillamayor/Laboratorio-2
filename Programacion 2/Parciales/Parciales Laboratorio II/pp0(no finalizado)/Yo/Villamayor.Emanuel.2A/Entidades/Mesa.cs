using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Mesa
    {

        #region Atributos

        private List<Comensal> _comensales;
        private int _numero;
        private static int capacidad;

        #endregion

        #region Propiedades

        public int Numero
        {
            get
            {
                return this._numero;
            }
        }

        public List<Comensal> Comensales
        {
            get
            {
                return this._comensales;
            }
        }

        public int Cantidad
        {
            get
            {
                return this._comensales.Count; //cantidad de comensales que hay
            } 
        }

        #endregion

        #region Constructores
        static Mesa()
        {
            Mesa.capacidad = 12;
        }

        private Mesa()
        {
            this._comensales = new List<Comensal>();
        }

        public Mesa(int numero) : this()
        {
            this._numero = numero;
        }

        #endregion



        #region SobrecargaOperadores

        public static bool operator ==(Mesa m1 , Mesa m2)
        {
            bool retorno = false;

            if(m1.Numero==m2.Numero)
            {
                retorno = true;
            }

            return retorno;
        }


        public static bool operator !=(Mesa m1, Mesa m2)
        {
            return !(m1 == m2);
        }


        public static Mesa operator +(Mesa m1 , Menor m2)
        {
            int flag = 0;
            

            foreach (Menor item in m1.Comensales)
            {
                if(item==m2)
                {
                    flag = 1;
                    break;
                }
            }

            if(flag==0)
            {
                if(m1.Comensales.Count+1 <= Mesa.capacidad)
                {
                    m1.Comensales.Add(m2);
                }
            }

           return m1;

        }

        public static Mesa operator +(Mesa m1, Mayor m2)
        {
            int flag = 0;


            foreach (Mayor item in m1.Comensales)
            {
                if (item == m2)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                if (m1.Comensales.Count + 1 <= Mesa.capacidad)
                {
                    m1.Comensales.Add(m2);
                }
            }

            return m1;

        }

        public static implicit operator string (Mesa m)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Mesa:{0} Comensales:{1}", m.Numero, m.Comensales);

            foreach(Comensal item in m.Comensales)
            {
                sb.AppendLine(item.ToString());  
              
            }

            return sb.ToString();
        }

        #endregion


        #region Sobreescritura

        public override string ToString()
        {
            return this;
        }

        #endregion
    }
}
