using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Auto : Vehiculo
    {
       public int cantVentanas;

        public Auto(int ventanas , int ruedas, int asientos , float precio) : base(ruedas,asientos,precio)
        {
            this.cantVentanas = ventanas;
        }

        public override string MostrarPrecio()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarPrecio());
            sb.AppendFormat("Auto: {0} ", base.PrecioHora);

            return sb.ToString();
        }

        public override float PrecioMin
        {
            get
            {
              return  base.PrecioMin;
            }
                
            set
            {
                base.PrecioMin = value;
            }
               
        }

    }
}
