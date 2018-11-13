using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Corredor
    {
        #region Atributos

        protected static Random _avance;
        protected Carril _carrilElegido;
        private short _velocidadMaxima;

        #endregion

        #region Propiedades

        public Carril CarrilElegido
        {
            get
            {
                return this._carrilElegido;
            }
        }

        public short VelocidadMaxima
        {
            get
            {
                return this._velocidadMaxima;
            }
            set
            {
                if (value <= 10 && value > 0)
                {
                    this._velocidadMaxima = value;
                }
            }
        }

        #endregion

        #region Constructores

         static Corredor()
        {
            Corredor._avance = new Random();
        }

        public Corredor(short velocidadMax , Carril carril)
        {
            this.VelocidadMaxima = velocidadMax;
            this._carrilElegido = carril;
        }

        #endregion

        #region Metodos

        public abstract void Correr();

        public virtual void Guardar(string path)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Enumerado

        public enum Carril
        {
            Carril1,
            Carril2
        }

        #endregion
    }
}
