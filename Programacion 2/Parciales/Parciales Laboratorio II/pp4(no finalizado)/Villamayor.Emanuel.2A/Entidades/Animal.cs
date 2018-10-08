using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        #region Atributos

        protected int _cantidadPatas;
        protected static Random _distanciaRecorrida; //solo se inicializa constructor estatico
        protected int _velocidadMaxima;

        #endregion

        #region Propiedades
        public int CantidadPatas
        {
            get
            {
                return this._cantidadPatas;
            }
            set
            {
                if(value>0 && value<=4)
                {
                    this._cantidadPatas = value;
                }
                else
                {
                    this._cantidadPatas = 4;
                }
            }
        }

        public int VelocidadMaxima
        {
            get
            {
                return this._velocidadMaxima;
            }
            set
            {
                if(value>0 && value<=60)
                {
                    this._velocidadMaxima = value;
                }
                else
                {
                    this._velocidadMaxima = 60;
                }
            }
        }

        private int  DistanciaRecorrida
        {
            get
            {
                int retorno;
               retorno= Animal._distanciaRecorrida.Next(10, this._velocidadMaxima);

                return retorno;
            }
        }

        #endregion

        #region Constructores
        static Animal()
        {
            Animal._distanciaRecorrida = new Random();
        }

        public Animal(int cantidadPatas, int velocidadMaxima)
        {
            this.CantidadPatas = cantidadPatas;
            this.VelocidadMaxima = velocidadMaxima;
        }

        #endregion

        #region Metodos

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
        
            sb.AppendFormat("Cantidad de patas : {0}\n", this.CantidadPatas);
            sb.AppendFormat("Velocidad Maxima : {0}\n", this.VelocidadMaxima);
            sb.AppendFormat("Distancia Recorrida: {0}", this.DistanciaRecorrida);

            return sb.ToString();

        }

        #endregion

    }
}
