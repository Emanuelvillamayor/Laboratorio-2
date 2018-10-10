using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    class PrestamoPesos : Prestamo
    {
        #region Atributos

        private float _porcentajeInteres;

        #endregion

        #region Propiedades
        //public float Intereses
        //{
        //    get
        //    {

        //    }
        //}

        #endregion

        #region Constructores
        public PrestamoPesos(float monto,DateTime vencimiento,float interes) :base()

        #endregion

    }
}
