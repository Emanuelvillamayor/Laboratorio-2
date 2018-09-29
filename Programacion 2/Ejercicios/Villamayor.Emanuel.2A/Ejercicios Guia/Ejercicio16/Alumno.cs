using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {

        #region ATRIBUTOS
        private Byte _nota1;
        private Byte _nota2;
        private Single _notaFinal;

        public String apellido;
        public Int32 legajo;
        public String nombre;

        #endregion

        #region METODOS

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }
        public void CalcularFinal()
        {

            if(this._nota1>=4 && this._nota2>=4)
            {
                Random rnd = new Random();

                this._notaFinal = rnd.Next(4,10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public  void Mostrar()
        {
            Console.WriteLine("Nombre     Apellido     Legajo   nota 1  nota 2  nota Final   ");
            if(this._notaFinal != -1)
            {
                Console.WriteLine("{0,-8}  {1,-10}  {2,-10}  {3,-5}  {4,-8}  {5}", this.nombre, this.apellido, this.legajo, this._nota1, this._nota2, this._notaFinal);
            }
            else
            {
                Console.WriteLine("{0,-8}  {1,-10}  {2,-10}  {3,-5}   {4,-5}  Alumno desaprobado", this.nombre, this.apellido, this.legajo, this._nota1, this._nota2);
            }
        }
        
        #endregion 
    }
}
