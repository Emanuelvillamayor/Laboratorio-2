using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
namespace EntidadesInstanciables
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
                if (indice >= 0 && indice <= this.jornada.Count)
                {
                    return this.jornada[indice];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.jornada[indice] = value;
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
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno item in g.alumnos)
            {
               // if (!Object.Equals(t, null)) 
                    if (item == a)
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

        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;

            foreach (Profesor item in g.profesores)
            {
                // if (!Object.Equals(t, null)) 
                if (i == item)
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


        public static Universidad operator +(Universidad g, EClases clase)
        {
            int i;
            bool flag = false;

            for (i = 0; i < g.profesores.Count; i++)
            {
                if (g.profesores[i] == clase) //chequea si hay profesor que de esa clase
                {
                    flag = true;
                    break;
                }
            }


            if (flag == true)
            {

                Jornada j = new Jornada(clase, g.profesores[i]);  //asigna clase y profe a la jornada

                for (i = 0; i < g.alumnos.Count; i++)
                {
                    if (g.alumnos[i] == clase)
                    {
                        j += g.alumnos[i];  //los alumnos que tiene la misma clase se los asigno a jornada
                    }
                }

            }
            return g;
        }

        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (g != a)
            {
                g.alumnos.Add(a);
            }

            return g;
        }

        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
            {
                g.profesores.Add(i);
            }

            return g;
        }


        //retornará el primer Profesor capaz de dar esa clase
        public static Profesor operator ==(Universidad g, EClases clase)
        {
        
            Profesor retorno = new Profesor();
            bool flag = false;
            int i;


            for (i = 0; i < g.profesores.Count; i++)
            {
                if (g.profesores[i] == clase)
                {
                    retorno = g.profesores[i];
                    flag = true;
                    break;
                }
            }
            if(flag == false)
            {

                throw new SinProfesorException();
            }
            return retorno;
        }


        // retornará el primer Profesor que no pueda dar la clase
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            int i;
            for (i = 0; i < g.profesores.Count; i++)
            {
                if (g.profesores[i] != clase) //chequea si hay profesor que de esa clase
                {
                    break;
                }
            }
            return g.profesores[i];
        }
        #endregion





        #region Enumerados

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        # endregion
    }
}
