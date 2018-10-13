using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Equipo
    {
        private Deportes _deporte;
        private DirectorTecnico _dt;
        private List<Jugador> _jugadores;
        private string _nombre;

        #region Propiedades

        public Deportes Deporte
        {
            set { this._deporte = value; }
        }

        #endregion

        #region Constructores

        private Equipo()
        {
            this._jugadores = new List<Jugador>();
        }

        public Equipo(string nombre , DirectorTecnico dt): this()
        {
            this._nombre = nombre;
            this._dt = dt;
        }

        public Equipo(string nombre , DirectorTecnico dt , Deportes deporte) : this(nombre,dt)
        {
            this._deporte = deporte;
        }

        #endregion

        #region Operadores

        public static bool operator == (Equipo e ,Jugador j)
        {
            bool retorno = false;

            foreach (Jugador item in e._jugadores)
            {
                if(item ==j)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e!=j)
            {
                e._jugadores.Add(j);
            }
            return e;
        }

        public static Equipo operator -(Equipo e , Jugador j)
        {
            if(e==j)
            {
                e._jugadores.Remove(j);
            }
            return e;
        }


        public static implicit operator string (Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("**{0} {1}**\n", e._nombre, e._deporte);
            sb.AppendLine("Nomina Jugadores: ");

            foreach(Jugador item in e._jugadores)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendFormat("Dirigido por: {0}\r\n", e._dt);
            return sb.ToString();
        }

        #endregion



        #region Enumerado 

        public enum Deportes
        {
            Basquet,
            Futbol,
            Handball,
            Rugby
        }

        #endregion
    }
}
