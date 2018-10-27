using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades43
{
   public class CompetenciaNoDisponibleException : Exception
    {
        #region Atributos

        private string _nombreClase;
        private string _nombreMetodo;

        #endregion

        #region Propiedades

        public string NombreClase
        {
            get
            {
                return this._nombreClase;
            }
                }

        public string NombreMetodo
        {
            get
            {
                return this._nombreMetodo;
            }
        }

        #endregion

        #region Constructores

        public CompetenciaNoDisponibleException(string mensaje , string clase , string metodo) : base(mensaje)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje , string clase , string metodo , Exception innerException): base(mensaje,innerException)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
           
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.InnerException.Message);
            sb.AppendFormat("Excepcion en el metodo {0} de la clase {1}\n", this.NombreMetodo, this.NombreClase);
            sb.AppendLine(this.Message);
           
            return sb.ToString();
        }

        #endregion

    }
}
