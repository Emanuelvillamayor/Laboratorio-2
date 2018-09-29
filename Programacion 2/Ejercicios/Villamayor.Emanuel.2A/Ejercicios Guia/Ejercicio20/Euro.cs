using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        #region ATRIBUTOS

        private double cantidad;
        private static float cotizRespectoDolar;

        #endregion

        #region METODOS

        public static float getCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static explicit operator Dolar(Euro e)
        {
            double cantidad = e.GetCantidad() * Euro.getCotizacion();


            Dolar d = new Dolar(cantidad);

            return d;

        }

        public static explicit operator Pesos(Euro e)
        {

            Dolar d = new Dolar(1);
            d = (Dolar)e;

            Pesos p = new Pesos(d.GetCantidad() * Pesos.getCotizacion());

            return p;

        }

        public static implicit operator Euro(Double e)
        {
            double cantidad = e;

            Euro retorno = new Euro(cantidad);

            return retorno;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro pasaje = new Euro();
            pasaje = (Euro)d;

            pasaje = e.GetCantidad() + pasaje.GetCantidad();

            return pasaje;

        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro pasaje = new Euro();
            pasaje = (Euro)p;

            pasaje = e.GetCantidad() + pasaje.GetCantidad();

            return pasaje;

        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro pasaje = new Euro();
            pasaje = (Euro)d;

            pasaje = e.GetCantidad() - pasaje.GetCantidad();

            return pasaje;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro pasaje = new Euro();
            pasaje = (Euro)p;

            pasaje = e.GetCantidad() - pasaje.GetCantidad();
            return pasaje;
        }


        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e , Dolar d)
        {
            Euro retorno = new Euro();
            retorno = (Euro)d;

            return (float)e.GetCantidad() == retorno.GetCantidad();
        }


        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }


        public static bool operator ==(Euro e, Pesos p)
        {
            Euro retorno = new Euro();
            retorno = (Euro)p;

            return (float)e.GetCantidad() == retorno.GetCantidad();
        }

        public static bool operator !=(Euro e, Pesos p)
        {      
            return !(e == p);
        }



        #endregion

        #region CONSTRUCTORES
        private Euro()
        {
            this.cantidad = this.cantidad*Euro.getCotizacion();
            Euro.cotizRespectoDolar = 1.3642f;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }


        #endregion

    }
}
