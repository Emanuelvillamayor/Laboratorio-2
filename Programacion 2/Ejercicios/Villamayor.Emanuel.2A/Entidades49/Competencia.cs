using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades49
{
  public  class Competencia <T> where T: VehiculoDeCarrera 

    {
        #region Atributos

        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<T> _competidores;
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

        public T this[int indice]
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
            this._competidores = new List<T>();
        }
        public Competencia(short cantVueltas, short cantCompetidores, ETipoCompetencia tipo) : this()
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

        public static bool operator ==(Competencia<T> c, T v)
        {
            bool retorno = false;

            if (c._tipo == ETipoCompetencia.F1 && v is AutoF1)
            {
                foreach (T item in c._competidores)
                {
                    if (item is AutoF1)
                    {
                        //  if ((AutoF1)item == (AutoF1)v)
                        //if(((AutoF1)item).Equals((AutoF1)v))
                        if (item.Equals(v))
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }

            else if (c._tipo == ETipoCompetencia.MotoCross && v is MotoCross)
            {

                foreach (VehiculoDeCarrera item in c._competidores)
                {
                    if (item is MotoCross)
                    {
                        //if ((MotoCross)item == (MotoCross)v)
                        //if(((MotoCross)item).Equals((MotoCross)v))
                      //  if(item.Equals(v))
                        {
                            retorno = true;
                            break;
                        }
                    }
                }

            }

            else
            {
                throw new CompetenciaNoDisponibleException("\nEl vehiculo no corresponde a la competencia", "Clase Competencia", "Metodo ==");
            }
            return retorno;
        }

        public static bool operator !=(Competencia<T> c, T v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia<T> c, T v)
        {
            bool retorno = false;
            Random rn = new Random();
            try
            {
                if (c != v)
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
            }
            catch (CompetenciaNoDisponibleException e)
            {
                throw new CompetenciaNoDisponibleException("Competencia Incorrecta", "Competencia", "metodo +", e);
            }


            return retorno;
        }

        public static bool operator -(Competencia<T> c, T v)
        {
            bool retorno = false;

            int i;
            int tam = c._competidores.Count;

            if (c._tipo == ETipoCompetencia.F1 && v is AutoF1)
            {
                for (i = 0; i < tam; i++)
                {
                    if (c[i] is AutoF1)
                    {
                        //if ((AutoF1)c[i] == (AutoF1)v)
                       // if(((AutoF1)c[i]).Equals((AutoF1)v))
                        if(c[i].Equals(v))
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

                for (i = 0; i < tam; i++)
                {

                    if (c[i] is MotoCross)
                    {
                        //   if ((MotoCross)c[i] == (MotoCross)v)
                       // if (((MotoCross)c[i]).Equals((MotoCross)v))
                      if(c[i].Equals(v))
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
