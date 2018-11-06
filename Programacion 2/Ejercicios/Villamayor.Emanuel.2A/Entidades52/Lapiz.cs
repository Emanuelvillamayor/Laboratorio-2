using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades52
{
    public class Lapiz : IAcciones
    {
        #region Atributos

        private float tamanioMina;

        #endregion

        #region Propiedades

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }

        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        #endregion

        #region Constructores

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        #endregion

        #region Metodos

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            int lenght = texto.Length;
            this.tamanioMina = this.tamanioMina - (0.1f * lenght);
            if (this.tamanioMina < 0)
            {
                this.tamanioMina = 0;
            }
            //castearlo para que reconozca el color
            EscrituraWrapper escritura = new EscrituraWrapper(texto, ((IAcciones)this).Color);
            return escritura;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region SobrecargaMetodos
        public override string ToString()
        {
        StringBuilder sb = new StringBuilder();
        
             sb.AppendLine("LAPIZ");
            sb.AppendFormat("Color de Escritura: {0}\n", ((IAcciones)this).Color);
            sb.AppendFormat("Nivel de Tinta: {0}\n",((IAcciones) this).UnidadesDeEscritura);

            return sb.ToString();
          }
        #endregion
    }
}
