using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
    public class Avion : Vehiculo, IAFIP,IARBA
    {

        #region Atributos

        protected double _velocidadMaxima;

        #endregion

        #region Propiedades

        public double VelocidadMaxima
        {
            get
            {
                return this._velocidadMaxima;
            }
            set
            {
                this._velocidadMaxima = value;
            }
        }

        #endregion

        #region Constructores


        public Avion(double precio , double velMax) : base(precio)
        {
            this._velocidadMaxima = velMax;
        }

   
        #endregion

        #region Metodos

    public double CalcularImpuesto()
        {
            return this.Precio * 0.33;
        }

        double IARBA.CalcularImpuesto()
        {
            return this.Precio * 0.27;
        }


        #endregion
    }
}
