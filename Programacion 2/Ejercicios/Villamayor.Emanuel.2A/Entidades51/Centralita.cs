using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades51
{
    /*a. Implementar la interfaz en la clase Centralita para datos del tipo String:
          i. Guardar tomará el objeto y consultará todos sus datos, luego retornará true.
          ii. Leer lanzará la excepción NotImplementedException.
      b. Implementar la interfaz en las llamadas del tipo Local y Provincial para los tipos de datos
          Local y Provincial respectivamente.
          i. Tanto Leer como Guardar lanzarán la excepción NotImplementedException.
     
     */

    public class Centralita : IGuardar<string>
    {
        #region Atributos

        private List<Llamada> _listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region Propiedades

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(ETipoLlamada.Local);
            }

        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(ETipoLlamada.Provincial);

            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return this.CalcularGanancia(ETipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;

            }
        }

        public string RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        #endregion

        #region Constructores

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion

        #region Metodos

        private float CalcularGanancia(ETipoLlamada tipo)
        {
            float retorno = 0;

            foreach (Llamada item in this._listaDeLlamadas)
            {
                switch (tipo)
                {
                    case ETipoLlamada.Local:
                        if (item is Local)
                        {
                            retorno += ((Local)item).CostoLlamada;
                        }
                        break;

                    case ETipoLlamada.Provincial:

                        if (item is Provincial)
                        {
                            retorno += ((Provincial)item).CostoLlamada;
                        }
                        break;

                    default:
                        if (item is Local)
                        {
                            retorno += ((Local)item).CostoLlamada;
                        }

                        if (item is Provincial)
                        {
                            retorno += ((Provincial)item).CostoLlamada;
                        }
                        break;

                }
            }
            return retorno;
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Razon Social: {0}\n", this.razonSocial);

            sb.AppendFormat("Ganancia Total: {0}\n", this.GananciaPorTotal);
            sb.AppendFormat("Ganancia llamadas Locales: {0}\n", this.GananciaPorLocal);
            sb.AppendFormat("Ganancia llamadas Provinciales: {0}\n", this.GananciaPorProvincial);

            foreach (Llamada item in this._listaDeLlamadas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {

            this._listaDeLlamadas.Add(nuevaLlamada);

        }

        public bool Guardar()
        {
            return true;
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }



        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool retorno = false;

            foreach (Llamada item in c._listaDeLlamadas)
            {

                if ((Llamada)item == (Llamada)l)
                {
                    retorno = true;
                }

            }

            return retorno;
        }


        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if (c != l)
            {
                c.AgregarLlamada(l);
            }
            else
            {
                throw new CentralitaException("La llamada se encuentra registrada en el sistema", "Clase Centralita", "Metodo Sobrecarga +");
            }

            return c;
        }

        #endregion

    }
}
