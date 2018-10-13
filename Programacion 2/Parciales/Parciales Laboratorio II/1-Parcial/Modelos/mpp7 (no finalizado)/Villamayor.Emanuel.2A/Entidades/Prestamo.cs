using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
  public abstract class Prestamo
    {
        #region Atributos

        protected float monto;
        protected DateTime vencimiento;

        #endregion

        #region Propiedades

        public float Monto
        {
            get
            {
              return  this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if(DateTime.Now<value)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
       }

        #endregion

        #region Constructor
        public Prestamo(float monto , DateTime vencimiento)
        {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }

        #endregion



        #region Metodos
        public static int OrdenarPorFecha(Prestamo p1 , Prestamo p2)
        {
            return string.Compare(p1.Vencimiento.ToString(), p2.Vencimiento.ToString());
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            return string.Format("Monto : {0}  Vencimiento : {1}", this.monto, this.vencimiento);
        }

        #endregion

    }
}
