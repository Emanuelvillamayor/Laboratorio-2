using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Bolígrafo
    {
        #region ATRIBUTOS

        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short  tinta;

        #endregion
        #region METODOS
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if(tinta>0 && tinta<=cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public Boolean Pintar (int gastar,out string dibujo)
        {
            short valor = this.tinta;
            Boolean retorno = false;
            Int32 i;
            dibujo = "";

            if(GetTinta()-gastar>0)
            {
                for(i=0;i<gastar;i++)
                {
                    dibujo += "*";
                }
                tinta = (short)(tinta - gastar);
                Console.BackgroundColor = this.color;
                retorno = true;
            }
 
            return retorno;
        }
        #endregion

        #region CONSTRUCTOR

        public Bolígrafo(short tinta , ConsoleColor color)
        {
            SetTinta(tinta);
            this.color = color;
        }
        #endregion

    }
}
