using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades47
{
   public class EquipoBasquet : Equipo
    {

        #region Constructores

        public EquipoBasquet(string nombre, DateTime fecha) : base(nombre, fecha)
        {

        }

        #endregion

        public override string Ficha()
        {
            return base.Ficha();
        }
    }
}
