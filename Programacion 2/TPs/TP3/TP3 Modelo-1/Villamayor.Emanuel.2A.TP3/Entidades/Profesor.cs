using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Profesor : Universitario
    {
        #region Atributos

        private Queue<EClases> clasesDelDia;
        private static Random random;

        #endregion

        #region Constructores

        static Profesor()
        {
            Profesor.random = new Random();
        }

        public Profesor() : this(0,"no tiene nombre","no tiene apelldio","1",ENacionalidad.Argentino)
        {
        
        }

       public Profesor(int id ,string nombre , string apellido , string dni , ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<EClases>();
            this._randomClases();
        }
        #endregion

        #region Metodos

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASES DEL DIA:\n");

            //Enum.GetValues(typeof(this.clasesDelDia))
            foreach(EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());         
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

     

        private void _randomClases()
        { 
            int i;
            int variable = 0;

            for(i=0;i<2;i++)
            {
                variable = Profesor.random.Next(0, 3);
                this.clasesDelDia.Enqueue((EClases)variable);
            }
           
        }

        #endregion

        #region Sobrecarga

   public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool operator ==(Profesor i, EClases clase)
        {
            bool retorno = false;

            foreach (EClases item in i.clasesDelDia)
            {
                if (clase == item)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Profesor i, EClases clase)
        {
            return !(i == clase);
        }
        #endregion

    }
}
