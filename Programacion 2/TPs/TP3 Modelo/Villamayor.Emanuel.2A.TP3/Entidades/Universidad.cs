using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Universidad
    {
        #region Atributos

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        #endregion

        #region Propiedades

        //indexador
        public Jornada this[int indice]
        {
            get
            {
                if(indice>=0 && indice<=this.jornada.Count)
                {
                    return this.jornada[indice];
                }
                else
                {
                    throw new Exception();
                }
            }
            set
            {
                this.jornada.Add(value);
            }
        }

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Profesor> Instructores
        { 
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        #endregion

        #region Constructores

        public Universidad()
        {
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
            this.alumnos = new List<Alumno>();
        }

        #endregion

        #region Sobrecargas
        //Un Universidad será igual a un Alumno si el mismo está inscripto en él.
        //va a tener que usar el == de universitario castearlo o no ?
       public static bool operator ==(Universidad g , Alumno a)
        {
            bool retorno = false;

            foreach(Alumno item in g.alumnos)
            {
                if((Universitario)item==(Universitario)a)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }



        //Un Universidad será igual a un Profesor si el mismo está dando clases en él
        //va a tener que usar el == de universitario castearlo o no ?

        public static bool operator ==(Universidad g , Profesor i)
        {
            bool retorno = false;

            foreach(Profesor item in g.profesores)
            {
                if((Universitario)i ==(Universitario)item )
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }




        #endregion


    }
}
