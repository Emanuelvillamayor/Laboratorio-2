using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
   public abstract class Auto : Vehiculo
    {

        #region Atributos

        protected string _patente;

        #endregion

        #region Propiedades

        public string Patente
        {
            get
            {
                return this._patente;
            }
            set
            {
                this._patente = value;
            }
        }


        #endregion

        #region Constructores

        public Auto(double precio , string patente) : base(precio)
        {
            this._patente = patente;
        }

        #endregion

        #region Metodos

        public void MostrarPatente()
        {
            Console.WriteLine("Patente: {0}", this._patente);
        }

        #endregion
    }
}
