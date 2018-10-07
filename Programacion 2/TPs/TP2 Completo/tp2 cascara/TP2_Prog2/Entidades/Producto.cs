using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {

        #region Atributos

        private EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;

        #endregion

        #region Propiedades

        /// <summary>
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo
        /// </summary>
        protected abstract short CantidadCalorias
        { get; }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor que inicializa los parametros de producto
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Producto(string patente, EMarca marca, ConsoleColor color)
        {
            this.codigoDeBarras = patente;
            this.colorPrimarioEmpaque = color;
            this.marca = marca;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Devuelve un string con los datos de un producto determinado
        /// </summary>
        /// <param name="p">Producto</param>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CODIGO DE BARRAS: {0}\r\n", p.codigoDeBarras);
            sb.AppendFormat("MARCA          : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR EMPAQUE  : {0}\r\n", p.colorPrimarioEmpaque.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="p1">Producto 1 </param>
        /// <param name="p2">Producto 2</param>
        /// <returns>true si son iguales , false si son distintos</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.codigoDeBarras == p2.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="p1">Producto 1</param>
        /// <param name="p2">Producto 2</param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.codigoDeBarras == p2.codigoDeBarras);
        }

        #endregion

        #region Enumerado

        public enum EMarca
        {
            Serenisima,
            Campagnola,
            Arcor,
            Ilolay,
            Sancor,
            Pepsico
        }

        #endregion

    }
}
