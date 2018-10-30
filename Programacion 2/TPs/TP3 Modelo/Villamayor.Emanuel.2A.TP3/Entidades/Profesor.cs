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

        private Profesor()
        {
            Profesor.random = new Random();
        }



        #endregion

        #region Metodos
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

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

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        private void _randomClase()
        {
            this.clasesDelDia = new Queue<EClases>();
          //  this.clasesDelDia.Enqueue(Profesor.random.Next(Enum.GetValues(typeof(EClases)), 3));
        }

        #endregion

    }
}
