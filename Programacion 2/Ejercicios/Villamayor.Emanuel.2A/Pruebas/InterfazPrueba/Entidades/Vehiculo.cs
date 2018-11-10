using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{


    public class Vehiculo : InterfazG
    {
        public int cantRuedas;
        public int cantAsientos;
        public float precioHora;


        public  float PrecioHora
        {
            get
            {
                return this.precioHora;
            }

            set
            {
                this.precioHora = value;
            }
        }

        public virtual  float PrecioMin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //puedo modificarlo a virtual una vez definido
        

        public virtual string MostrarPrecio()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Precio Hora: ");
            return sb.ToString();
        }

        public Vehiculo(int ruedas, int asientos, float precio)
        {
            this.PrecioHora = precio;
            this.cantAsientos = asientos;
            this.cantRuedas = ruedas;
        }
    }
}
