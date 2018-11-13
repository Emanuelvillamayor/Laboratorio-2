using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona : Corredor
    {
        #region Atributos

        private string _nombre;
        public event CorrenCallback Corriendo;

        #endregion

        #region Constructores

        public Persona(string nombre , short velocidadMax, Carril carril):base(velocidadMax,carril)
        {
            this._nombre = nombre;
        }

        #endregion

        #region SobrecargaOperadores

        //utilizar thread
        public override void Correr()
        {
            int i;
            int cant;
           cant= Corredor._avance.Next(1,10);

            for(i=0;i<cant;i++)
            {
                this.Corriendo();
            }
          

            throw new NotImplementedException();
        }

        public override void Guardar(string path)
        {
            base.Guardar(path);
        }

        #endregion

    }

    public delegate void CorrenCallback();
}
