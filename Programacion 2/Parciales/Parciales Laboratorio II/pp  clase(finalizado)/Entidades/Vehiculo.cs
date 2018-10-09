using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        #region Atributos

        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;
        #endregion

        #region Propiedades
        public string Patente
        {
            get
            {
                return this._patente;
            }
            
        }

        public byte CantRuedas
        {
            get
            {
                return this._cantRuedas;
            }
            set
            {
                this._cantRuedas = value;
            }
        }

        public EMarcas Marca
        {
            get
            {
                return this._marca;
            }
        }

        #endregion

        #region Constructores

        public Vehiculo(string patente,byte ruedas,EMarcas marca)
        {
            this._patente = patente;
            this.CantRuedas = ruedas;
            this._marca = marca;
        }

        #endregion

        #region Metodos
        protected virtual string Mostrar()
        {
            return string.Format("Patente: {0} Ruedas: {1} Marca: {2}", this.Patente, this.CantRuedas, this.Marca);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion

        #region SobrecargaOperadores
        public static bool operator ==(Vehiculo v1 , Vehiculo v2)
        {
            bool retorno = false;
            
            if(v1.Patente==v2.Patente && v1.Marca==v2.Marca)
            {
                retorno = true;
            }

            return retorno;
        }


        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
