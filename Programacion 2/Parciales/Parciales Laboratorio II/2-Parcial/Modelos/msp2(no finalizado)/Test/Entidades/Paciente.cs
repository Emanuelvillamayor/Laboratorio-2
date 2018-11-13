using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        #region Atributos

        private int turno;
        private static int ultimoTurnoDado;

        #endregion

        #region Propiedades

        public int Turno
        {
            get
            {
                return this.turno;
            }

        }


        #endregion

        #region Constructores

        static Paciente()
        {
            Paciente.ultimoTurnoDado = 0;
        }

        public Paciente(string nombre , string apellido , int ultimoTurno):this(nombre,apellido)
        {
            Paciente.ultimoTurnoDado = ultimoTurno;
        }

        public Paciente(string nombre , string apellido): base(nombre,apellido)
        {
            Paciente.ultimoTurnoDado += 1;
            this.turno = Paciente.ultimoTurnoDado;
        }

        #endregion

        #region SobrecargaMetodos

        public override string ToString()
        {
            return string.Format("Turno N°{0}: {2}, {1}", this.turno, this.apellido, this.nombre);
        }

# endregion
    }
}
