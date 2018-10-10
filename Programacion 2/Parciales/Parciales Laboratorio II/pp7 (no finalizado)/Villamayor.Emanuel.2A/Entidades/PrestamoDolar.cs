using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    class PrestamoDolar : Prestamo
    {
        #region Atributos

        private PeriodicidadDePago _periodicidad;

        #endregion

        #region Propiedades
        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        public PeriodicidadDePago Periodicidad
        {
            get
            {
                return this._periodicidad;
            }
        }
        #endregion


        #region Constructores

        public PrestamoDolar(Prestamo prestamo , PeriodicidadDePago periodicidad) :this(prestamo.Monto,prestamo.Vencimiento,periodicidad)
        {

        }

        public PrestamoDolar(float monto , DateTime vencimiento , PeriodicidadDePago periodicidad) :base(monto,vencimiento)
        {
            this._periodicidad = periodicidad;
        }

        #endregion


        #region Metodos

        private float CalcularInteres()
        {
            return (this.monto * (float)this.Periodicidad)/100;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan ts;
            ts = nuevoVencimiento - base.Vencimiento;

            int diasExtendido = ts.Days;

            base.monto = base.monto + 2.5f * diasExtendido;
          
        }

        public override string Mostrar()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Prestamo Dolar\n");
            sb.AppendFormat("Periodicidad: {0}\n", this.Periodicidad);
            sb.AppendFormat("Interese: {0}\n", this.Interes);
            sb.AppendLine(base.Mostrar());

            return sb.ToString();
        }
        #endregion



    }
}
