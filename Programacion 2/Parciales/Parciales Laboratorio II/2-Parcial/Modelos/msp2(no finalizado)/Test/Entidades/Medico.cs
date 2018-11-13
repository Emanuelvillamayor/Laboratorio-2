using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Medico : Persona
    {
        #region Atributos

        private Paciente pacienteActual;
        protected static Random tiempoAleatorio;

        

        #endregion

        #region Propiedades

        public virtual string EstaAtendidoA
        {
            get
            {
                return this.pacienteActual.ToString();
            }
        }

        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }
        #endregion

        #region Constructores

        static Medico()
        {
            Medico.tiempoAleatorio = new Random();
        }

        public Medico(string nombre , string apellido): base(nombre,apellido)
        {

        }

        #endregion

        #region Metodos

        protected abstract void Atender();
        
        protected void FinalizarAtencion()
        {


        }
        

        #endregion
    }
}
