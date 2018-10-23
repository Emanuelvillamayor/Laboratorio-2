using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase14_2
{
    public class Cocina
    {
        #region Atributos

        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        #endregion

        #region Propiedades

        public int  Codigo
        {
            get
            {
                return this._codigo;
            }
                }

        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }

        public double Precio
        {
            get
            {
                return this._precio;
            }
        }

        #endregion

        #region Constructores

        public Cocina(int codigo , double precio , bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }

        #endregion

        #region Metodos

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Cocina)
            {
                retorno = this == (Cocina)obj;
            }
            return retorno;
        }

        public override string ToString()
        {
            return string.Format("Codigo: {0} - Precio: {1} - Es Industrial? {2}", this._codigo, this._precio, this._esIndustrial);
        }
        #endregion

        #region SobrecargaOperadores

        public static bool operator ==(Cocina a , Cocina b)
        {          
            return a._codigo == b._codigo;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }





        #endregion

    }
}
