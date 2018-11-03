using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
namespace EntidadesInstanciables
{
   public class Jornada
    {

        #region Atributos

        private List<Alumno> alumnos; //se inicializa constructor defecto
        private Universidad.EClases clase;
        private Profesor instructor;

        #endregion

        #region Propiedades

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

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region Constructores

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Metodos

       public static bool Guardar(Jornada jornada)
        {
    
            Texto t = new Texto();
   
            return  t.Guardar((AppDomain.CurrentDomain.BaseDirectory) + @"\Jornada.txt", jornada.ToString());
        }

        public static string Leer()
        {
            string retorno ;
            Texto t = new Texto();
            t.Leer((AppDomain.CurrentDomain.BaseDirectory) + @"\Jornada.txt", out retorno);
              
            return retorno;
        }


        #endregion

        #region Sobrecarga

        // si el mismo participa de la clase.
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno item in j.alumnos)
            {
                if (item == a)
                {
                    retorno = true;
                    break;
                }

            }

            return retorno;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return j;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");
            sb.AppendLine("CLASE DE " + this.clase +" POR "+ this.instructor);
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno item in this.alumnos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion




    }
}
