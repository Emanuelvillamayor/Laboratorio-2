using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaBancaria
    {
        #region Atributos

        private string _nombreDelCliente;
        private int _numeroCuenta;
        private double _saldo;

        #endregion

        #region Constructores

        public CuentaBancaria(int cuenta , string nombre) :this(cuenta, nombre,0)
        {
           
        }

        public CuentaBancaria(int cuenta , string nombre , double saldo) 
        {
            this._saldo = saldo;
            this._numeroCuenta = cuenta;
            this._nombreDelCliente = nombre;
        }


        #endregion

        #region Mostrar

        public void Mostrar()
        {
            Console.WriteLine("Nombre : {0}  NumeroCuenta: {1}  Saldo: {2}", this._nombreDelCliente, this._numeroCuenta, this._saldo);
        }


        #endregion


        #region SobrecargaOperadores

        public static double operator +(CuentaBancaria c1 , CuentaBancaria c2)
        {
            double retorno = 0;

            if(c1._nombreDelCliente ==c2._nombreDelCliente)
            {
                retorno = c1._saldo + c2._saldo;
            }
            else
            {
                Console.WriteLine("No son del mismo cliente las cuentas!!");
            }

            return retorno;
        }

        public static CuentaBancaria operator +(CuentaBancaria c1, double importe)
        {
            c1._saldo = c1._saldo + importe;

            return c1;
        }

        public static CuentaBancaria operator -(CuentaBancaria c1, double importe)
        {
            if(c1._saldo-importe>=0)
            {
                c1._saldo = c1._saldo - importe;
            }

            return c1;
        }

        #endregion
    }
}
