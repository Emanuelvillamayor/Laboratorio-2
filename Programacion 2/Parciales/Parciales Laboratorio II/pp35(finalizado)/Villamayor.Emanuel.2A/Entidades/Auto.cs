using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        #region Atributos

        private string _color;
        private double _precio;
        private EMarcas _marca;
        private DateTime _fecha;

        #endregion

        #region Constructores

        public Auto( EMarcas marca,string color )
        {
            this._color = color;
            this._marca = marca;
        }

        public Auto(EMarcas marca,string color,double precio) :this(marca,color)
        {
            this._precio = precio;
        }

        public Auto(EMarcas marca, string color , double precio,DateTime fecha) :this(marca,color,precio)
        {
            this._fecha = fecha;
        }

        public Auto(string color , EMarcas marca, double precio , DateTime fecha) : this(marca,color,precio,fecha)
        {

        }

        #endregion

        #region Metodos

        public void AgregarImpuestos(double importe)
        {
            this._precio = this._precio + importe;
        }

        public static void MostrarAuto(Auto a)
        {
            Console.WriteLine("Color : {0}  Marca : {1}  Precio : {2}  Fecha : {3:G}", a._color, a._marca, a._precio, a._fecha);
        }

        #endregion

        #region SobrecargaOperadores
    
        public static bool operator == (Auto a1 , Auto a2)
        {
            bool retorno = false;

            if(a1._marca==a2._marca)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Auto a1, Auto a2)
        {
            return !(a1 == a2);
        }

        public static  double operator +(Auto a1 , Auto a2)
        {
            double retorno = 0;

            if(a1==a2 && a1._color == a2._color)
            {                       
                    retorno = a1._precio+a2._precio;                
            }
            else
            {
                Console.WriteLine("No son iguales no se puede sumar !!");
            }

            return retorno;
        }

        #endregion


    }
}
