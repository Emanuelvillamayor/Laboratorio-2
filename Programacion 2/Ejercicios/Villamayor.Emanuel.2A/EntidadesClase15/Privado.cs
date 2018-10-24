using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
   public class Privado : Avion
    {

        #region Atributos

        protected int _valoracionServicioAbordo;

        #endregion

        #region Constructores

        public Privado(double precio, double velocidad, int valoracion) : base(precio,velocidad)
        {
            this._valoracionServicioAbordo = valoracion;
        }

        #endregion

        
    }
}
