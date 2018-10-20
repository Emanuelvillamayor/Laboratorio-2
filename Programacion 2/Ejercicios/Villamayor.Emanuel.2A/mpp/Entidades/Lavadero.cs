using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;

        #region Propiedades
         public string LavaderoToString
         {
             get
             {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("Razon social: {0} ", this._razonSocial);
                sb.AppendFormat("\nPrecio Auto : {0}\nPrecio Moto : {1}\nPrecio Camion : {2}\n", Lavadero._precioAuto, Lavadero._precioMoto, Lavadero._precioCamion);
                foreach (Vehiculo item in this._vehiculos)
                {
                    sb.AppendLine(item.ToString());
                }
                // sb.AppendLine(this.Vehiculos);


                return sb.ToString();
             }
         }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this._vehiculos;
                
            }
        }

        #endregion

        #region Constructores

        static Lavadero()
        {
            Random rn= new Random();
           
            Lavadero._precioAuto = rn.Next(150, 565);
            do
            {
                Lavadero._precioCamion = rn.Next(150, 565);
                Lavadero._precioMoto = rn.Next(150, 565);

            } while (Lavadero._precioCamion == Lavadero._precioAuto && Lavadero._precioMoto == Lavadero._precioAuto && Lavadero._precioMoto == Lavadero._precioCamion);
            


        }
        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(string razon) : this()
        {
            this._razonSocial = razon; 
        }

        #endregion


        #region Metodos
        public double MostrarTotalFacturado()
        {
            double acum = 0;

            acum += this.MostrarTotalFacturado(EVehiculos.Auto);
            acum += this.MostrarTotalFacturado(EVehiculos.Moto);
            acum += this.MostrarTotalFacturado(EVehiculos.Camion);


            return acum;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double acum = 0;
            foreach (Vehiculo item in this._vehiculos)
            {
                switch (vehiculo)
                {
                    case EVehiculos.Auto:
                        if (item is Auto)
                        {
                            acum += Lavadero._precioAuto;
                        }
                       break;

                    case EVehiculos.Moto:
                        if (item is Moto)
                        {
                            acum += Lavadero._precioMoto;
                        }
                        break;

                    case EVehiculos.Camion:
                        if (item is Camion)
                        {
                            acum += Lavadero._precioCamion;
                        }
                        break;
                    default:
                        break;
              }
            }

            return acum;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1 , Vehiculo v2)
        {
            return string.Compare(v1.Patente, v2.Patente);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo v1 , Vehiculo v2)
        {

            return string.Compare(Enum.GetName(typeof(EMarcas), v1.Marca), Enum.GetName(typeof(EMarcas), v2.Marca));
        }

        #endregion

        #region SobreacargaOperadores

        public static bool operator == (Lavadero l , Vehiculo v)
        {
            bool retorno = false;

            foreach(Vehiculo item in l._vehiculos)
            {
                if(item == v)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Lavadero l, Vehiculo v)
        {
            return !(l == v);
        }

        public static int operator ==(Vehiculo v , Lavadero l)
        {
            int i;
            int retorno = -1;
            for(i=0; i<l._vehiculos.Count;i++)
            {
                if(l._vehiculos[i]==v)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }

        public static int operator !=(Vehiculo v, Lavadero l)
        {
            return v == l;
        }

        public static Lavadero operator +(Lavadero l , Vehiculo v)
        {
            if(l!=v)
            {
                l._vehiculos.Add(v);
            }

            return l;
        }

        public static Lavadero operator -(Lavadero l , Vehiculo v)
        {
            int indice;
          /*  if (l==v)
            {
                l._vehiculos.Remove(v);
            }*/

            indice = v == l;

            if(indice!=-1)
            {
                l._vehiculos.RemoveAt(indice);
            }
         

            return l;
        }

        #endregion
    }
}
