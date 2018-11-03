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

        #region Metodos

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
         
            foreach(Jornada item in uni.jornada)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region SobrecargaMetodos

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        #endregion

        #region SobrecargasOperadores

        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno item in g.alumnos)
            {
               
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


        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;

            foreach (Profesor item in g.profesores)
            {
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
            Profesor p = (g == clase);
            Jornada j = new Jornada(clase, p);

            foreach(Alumno item in g.alumnos)
            {
                if(item == clase)
                {
                    j += item;
                }
                
            }

            g.Jornadas.Add(j);
            return g;
        }

        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (g != a)
            {
                g.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return g;
        }

        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
            {
                g.profesores.Add(i);
            }

          //en el else no sabia si agregar una excepcion o algo ya que no lo dice en el enunciado

            return g;
        }


        
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


        
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            Profesor retorno = new Profesor();
            bool flag = false;
            int i;
            for (i = 0; i < g.profesores.Count; i++)
            {
                if (g.profesores[i] != clase) 
                {
                    retorno = g.profesores[i];

                    break;
                }
            }
            if(flag==false)
            {
                //nose si tirar la excepcion o retornar null o algo en el caso de que todos los profesores  puedan dar la clase
                throw new SinProfesorException();
            }
            return retorno;
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
