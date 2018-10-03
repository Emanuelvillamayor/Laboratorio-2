using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Equipo
    {
        #region Atributos

        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string nombre;

        #endregion

        #region Constructores
        private Equipo()
        {
            this._jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this._cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        #endregion

        #region Sobrecarga Operadores
        public static bool operator +(Equipo e , Jugador j)
        {
            bool retorno = false;
            int flag = 0;      
            int i;

            for (i=0;i<e._jugadores.Count();i++)
            {
                if(j==e._jugadores[i])
                {
                    flag=1;
                    break;
                }
            }

            if(flag==0)
            {
               if(e._jugadores.Count+1<=e._cantidadDeJugadores)
                {
                    e._jugadores.Add(j);
                    retorno = true;
                }
            }


            return retorno;
        }



        #endregion

    }
}
