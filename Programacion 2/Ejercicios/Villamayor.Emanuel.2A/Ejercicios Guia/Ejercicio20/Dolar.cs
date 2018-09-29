using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        #region ATRIBUTOS

        private double cantidad;
        static private float cotizRespectoDolar = 1;

        #endregion

        #region METODOS

        public static float getCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static explicit operator Euro(Dolar d)
        {
            double cantidad =  d.GetCantidad()/Euro.getCotizacion() ;

            Euro retorno = new Euro(cantidad);
        
            return retorno;
        }

        public static explicit operator Pesos(Dolar d)
        {
            double cantidad = Pesos.getCotizacion() * d.GetCantidad();

           Pesos retorno = new Pesos(cantidad);

            return retorno;
        }

        public static implicit operator Dolar(Double d)
        {
            
            Dolar retorno = new Dolar(d);

            return retorno;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar pasaje = new Dolar();
            pasaje = (Dolar)e;

            d = d.GetCantidad() + pasaje.GetCantidad();

            return d;

        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar pasaje = new Dolar();
            pasaje = (Dolar)p;

            d = d.GetCantidad() + pasaje.GetCantidad();

            return d;

        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar pasaje = new Dolar();
            pasaje = (Dolar)p;

            d = d.GetCantidad() - pasaje.GetCantidad();

            return d;

        }



        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar pasaje = new Dolar();
            pasaje = (Dolar)e;

            d = d.GetCantidad() - pasaje.GetCantidad();

            return d;

        }

        public static bool operator ==(Dolar d, Dolar d2)
        {
            return d.GetCantidad() ==(float) d2.GetCantidad();

        }

        public static bool operator !=(Dolar d, Dolar d2)
        {
            return !(d==d2);

        }

        public static bool operator ==(Dolar d, Euro e)
        {
            Dolar retorno = (Dolar)e;
           
            return (float) d.GetCantidad() ==  retorno.GetCantidad();
            

        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);

        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            Dolar d2 = new Dolar();

            d2 = (Dolar)p;

            return d.GetCantidad() == (float) d2.GetCantidad(); 

        }

        public static bool operator !=(Dolar d, Pesos p)
        {

            return !(d == p);

        }


        #endregion

        #region CONSTRUCTORES

        private Dolar()
        {
            this.cantidad = 0;
            Dolar.cotizRespectoDolar = 1f;
        }
        
        public Dolar(double cantidad): this ()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad,float cotizacion) : this (cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }



        #endregion


    }



}
