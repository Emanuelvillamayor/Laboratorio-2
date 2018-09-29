using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Pesos
    {

        #region ATRIBUTOS

        private double cantidad;
        private static float cotizRespectoDolar;

        #endregion

        #region METODOS

        public static float getCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar d = new Dolar(1);

            d = (Dolar)p;
            Euro retorno = new Euro(d.GetCantidad() / Euro.getCotizacion());

            return retorno;
        }

        public static explicit operator Dolar(Pesos p)
        {
            double cantidad = p.GetCantidad() / Pesos.getCotizacion();

            Dolar retorno = new Dolar(cantidad);

            return retorno;
        }

        public static implicit operator Pesos(Double d)
        {
            double cantidad = d;

            Pesos retorno = new Pesos(cantidad);

            return retorno;
        }


        public static Pesos operator +(Pesos p1, Pesos p2)
        {
            Pesos retorno = new Pesos();

            retorno = p1.GetCantidad() + p2.GetCantidad();

            return retorno;
        }

        public static Pesos operator -(Pesos p1, Pesos p2)
        {
            Pesos retorno = new Pesos();

            retorno = p1.GetCantidad() - p2.GetCantidad();

            return retorno;
        }


        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos();

            retorno = (Pesos)d;

            retorno = retorno.GetCantidad() + p.GetCantidad();

            return retorno;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos();

            retorno = (Pesos)d;

            retorno = retorno.GetCantidad() - p.GetCantidad();

            return retorno;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos retorno = new Pesos();

            retorno = (Pesos)e;

            retorno = retorno.GetCantidad() + p.GetCantidad();

            return retorno;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos retorno = new Pesos();

            retorno = (Pesos)e;

            retorno = retorno.GetCantidad() - p.GetCantidad();

            return retorno;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos();

            retorno = (Pesos)d;

            return p.GetCantidad() == (float)retorno.GetCantidad();
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }


        public static bool operator ==(Pesos p, Euro e)
        {
            Pesos retorno = new Pesos();

            retorno = (Pesos)e;

            return p.GetCantidad() == (float)retorno.GetCantidad();
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        #endregion

        #region CONSTRUCTORES
        private Pesos()
        {
            this.cantidad = 0;
            Pesos.cotizRespectoDolar = 17.55f;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        #endregion





    }
}
