using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades36
{
   public class Competencia
    {
        #region Atributos

        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<VehiculoDeCarrera> _competidores;
        private ETipoCompetencia _tipo;


        #endregion

        #region Propiedades

        public short CantidadCompetidores
        {
            get
            {
                return this._cantidadCompetidores;
            }
            set
            {
                this._cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this._cantidadVueltas;
            }
            set
            {
                this._cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int indice]
        {
            get
            {
                if (indice >= this._competidores.Count || indice < 0)
                    return null;
                else
                    return this._competidores[indice];
            }
        }

        public ETipoCompetencia Tipo
        {
            get
            {
                return this._tipo;
            }
            set
            {
                this._tipo = value;
            }
        }

        #endregion

        #region Constructores

        private Competencia()
        {
            this._competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantVueltas, short cantCompetidores , ETipoCompetencia tipo ) : this()
        {

            this._cantidadVueltas = cantVueltas;
            this._cantidadCompetidores = cantCompetidores;
            this._tipo = tipo;

        }

        #endregion

        #region Metodos

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            int i;
            int cant = this._competidores.Count;

            for (i = 0; i < cant; i++)
            {

                sb.AppendLine(this[i].MostrarDatos());
            }

            return sb.ToString();
        }

        #endregion

        #region SobrecargaOperadores

        public static bool operator == (Competencia c , VehiculoDeCarrera v)
        {
            bool retorno = false;

            if(c._tipo == ETipoCompetencia.F1 &&  v is AutoF1)
            {
                foreach(VehiculoDeCarrera item in c._competidores)
                {
                    if(item is AutoF1)
                    {
                        if((AutoF1)item == (AutoF1)v )
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            
            if (c._tipo == ETipoCompetencia.MotoCross && v is MotoCross)
            {

                foreach (VehiculoDeCarrera item in c._competidores)
                {
                    if (item is MotoCross)
                    {
                        if ((MotoCross)item == (MotoCross)v)
                        {
                            retorno = true;
                            break;
                        }
                    }
                }

            }
            return retorno;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c , VehiculoDeCarrera v)
        {
            bool retorno = false;
            Random rn = new Random();
            
            if(c!=v)
            {
                if (c._competidores.Count + 1 <= c._cantidadCompetidores)
                {
                    v.EnCompetencia = true;
                    v.VuletasRestantes = c._cantidadVueltas;
                    v.CantidadCombustible = (short)rn.Next(15, 100);
                    c._competidores.Add(v);
                    retorno = true;
                }
            }


            return retorno;
        }

        public static bool operator -(Competencia c , VehiculoDeCarrera v)
        {
            bool retorno = false;
         
            int i;
            int tam = c._competidores.Count;

            if (c._tipo == ETipoCompetencia.F1 && v is AutoF1)
            {
                for (i=0; i<tam;i++)
                {
                    if (c[i] is AutoF1)
                    {
                        if ((AutoF1)c[i] == (AutoF1)v)
                        {
                            retorno = true;
                            c._competidores.RemoveAt(i);
                            break;
                        }
                    }
                }
            }



            if (c._tipo == ETipoCompetencia.MotoCross && v is MotoCross)
            {

                for (i = 0;i<tam;i++)
                {

                    if (c[i] is MotoCross)
                    {
                        if ((MotoCross)c[i] == (MotoCross)v)
                        {
                            retorno = true;
                            c._competidores.RemoveAt(i);
                            break;
                        }
                    }
                }

            }

            return retorno;
        }


        #endregion
    }
}
