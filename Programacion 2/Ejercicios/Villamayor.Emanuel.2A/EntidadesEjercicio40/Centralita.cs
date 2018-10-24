using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEjercicio40
{
    public class Centralita
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
                            retorno += ((Local)item).CostoLlamda;
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
                            retorno += ((Local)item).CostoLlamda;
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

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Razon Social: {0}\n", this.razonSocial);

            sb.AppendFormat("Ganancia Total: {0}\n", this.GananciaPorTotal);
            sb.AppendFormat("Ganancia llamadas Locales: {0}\n", this.GananciaPorLocal);
            sb.AppendFormat("Ganancia llamadas Provinciales: {0}\n", this.GananciaPorProvincial);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        //private void AgregarLlamada(Llamada nuevaLlamada)
        //{

        //    this._listaDeLlamadas.Add(nuevaLlamada);

        //}

        #endregion

        #region SobrecargaOperadores

        //public static bool operator == (Centralita c , Llamada l)
        //{
        //    bool retorno = false;

        //    foreach(Llamada item in c._listaDeLlamadas)
        //    {

        //        if((Llamada)item == (Llamada)l)
        //        {
        //            retorno = true;
        //        }

        //    }

        //    return retorno;
        //}


        //public static bool operator !=(Centralita c, Llamada l)
        //{
        //    return !(c == l);
        //}

        //public static Centralita operator +(Centralita c, Llamada l)
        //{
        //    if(c!=l)
        //    {
        //        c.AgregarLlamada(l);
        //    }

        //    return c;
        //}

        #endregion



    }
}
