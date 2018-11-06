using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades53
{
    public class Boligrafo :IAcciones
    {
        #region Atributos

        private ConsoleColor colorTinta;
        private float tinta;

        #endregion

        #region Propiedades

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        #endregion

        #region Constructores
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.UnidadesDeEscritura = unidades;
        }


        #endregion

        #region Metodos

        public EscrituraWrapper Escribir(string texto)
        {
            int lenght = texto.Length;
            this.tinta = this.tinta - (0.3f * lenght);
            if (this.tinta < 0)
            {
                this.tinta = 0;
            }
            //castearlo para que reconozca el color
            EscrituraWrapper escritura = new EscrituraWrapper(texto, this.colorTinta);
            return escritura;
        }

        public bool Recargar(int unidades)
        {
            bool retorno = false;
            if (unidades > 0)
            {
                this.tinta = this.tinta + unidades;
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region SobrecargaMetodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("BOLIGRAFO");
            sb.AppendFormat("Color de Escritura: {0}\n", this.Color);
            sb.AppendFormat("Nivel de Tinta: {0}\n", this.UnidadesDeEscritura);

            return sb.ToString();
        }

        #endregion
    }
}
