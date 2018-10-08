using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Humano : Animal
    {
        #region Atributos

        private string _apellido;
        private string nombre;
        private static int _piernas;

        #endregion

        #region Constructores

        static Humano()
        {
            Humano._piernas = 2;
        }

        public Humano(int velocidadMaxima) : this("","",velocidadMaxima) //por defecto no sabia que poner en nombre y apellido
        { }

        public Humano(string nombre , string apellido , int velocidadMaxima) : base(Humano._piernas,velocidadMaxima)
        {
            this.nombre = nombre;
            this._apellido = apellido;
        }

        #endregion

        #region Metodos

        public string MostrarHumano()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("HUMANO");
            sb.AppendFormat("Nombre : {0}\n", this.nombre);
            sb.AppendFormat("Apellido: {0}\n", this._apellido);
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }

        #endregion

        #region Sobrecarga Operadores

        public static bool operator ==(Humano h1 , Humano h2)
        {
            bool retorno = false;

            if(h1.nombre==h2.nombre && h1._apellido==h2._apellido )
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Humano h1, Humano h2)
        {
            return !(h1 == h2);
        }

        #endregion

    }
}
