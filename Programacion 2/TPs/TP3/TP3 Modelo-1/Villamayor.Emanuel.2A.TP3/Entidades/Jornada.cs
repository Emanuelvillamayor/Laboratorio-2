using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entidades
{
    public class Jornada
    {
        #region Atributos

        private List<Alumno> alumnos; //se inicializa constructor defecto
        private EClases clase;
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

        public EClases Clase
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

        public Jornada(EClases clase , Profesor instructor): this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Metodos

        public static bool Guardar(Jornada jornada)
        {
            bool retorno = false;

            //  string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Jornada.txt");
            string path = Environment.CurrentDirectory + @"\Jornada.txt";
            try
            {
               using (StreamWriter sm = new StreamWriter(path, false))
               {
                    sm.WriteLine(jornada.ToString());
               }
                retorno = true;
            }
            catch(ArchivosException e)
            {
                throw new ArchivosException(e); //fijarme si aca tiene que crear una nuevo instancia pro el inner exception
            }

            return retorno;
        }

        public static string Leer()
        {
            string retorno = "";
            string path = (AppDomain.CurrentDomain.BaseDirectory) + @"\Jornada.txt";
            try
            {


                using (StreamReader sr = new StreamReader(path))
                {
                    retorno = sr.ReadToEnd();
                }
            }
            catch(ArchivosException e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }


        #endregion

        #region Sobrecarga

        // si el mismo participa de la clase.
        public static bool operator ==(Jornada j , Alumno a)
        {
            bool retorno = false;

            foreach(Alumno item in j.alumnos)
            {
                if(item == a)
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

        public static Jornada operator +(Jornada j , Alumno a)
        {
            if(j!=a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");
            sb.AppendFormat("CLASE DE {0} POR ", this.clase);
            sb.AppendLine(this.instructor.ToString());
            foreach(Alumno item in this.alumnos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion
    }
}
