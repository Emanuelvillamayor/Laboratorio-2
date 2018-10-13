using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        #region Atributos

        private int _cantidadTinta;
        private string _color;
        private string _marca;

        #endregion

        #region Constructores
      
        public Boligrafo(string color, string marca, int cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidadTinta = cantidad;
        }

        public Boligrafo(int tintas,string marcas, string colores) :this(colores,marcas,tintas)
        {

        }

        public Boligrafo(string marcas, int tintas, string colores) : this(colores, marcas, tintas)
        {

        }

        public Boligrafo(string marca , string colores) : this(colores,marca,0)
        {

        }
        #endregion

        #region Metodos
        private void Mostrar()
        {
            Console.WriteLine("Cant Tinta :{0} Color:{1} Marca : {2}", this._cantidadTinta, this._color, this._marca);
        }

        public static void MostrarBoligrafos(List<Boligrafo> ListadoBoligrafos)
        {
            foreach(Boligrafo b in ListadoBoligrafos)
            {
                b.Mostrar();
            }
        }

        public void Escribir (int CantidadNecesaria)
        {
            if(this._cantidadTinta-CantidadNecesaria<0)
            {
                Console.WriteLine("Cantidad de tinta insuficiente: ");
                this.Mostrar();
            }
            else
            {
                this._cantidadTinta = this._cantidadTinta - CantidadNecesaria;
            }
        }

        public bool RecargarTinta()
        {
            bool retorno = false; 

            if(this._cantidadTinta<50)
            {
                this._cantidadTinta = 100;
                retorno = true;
            }

            return retorno;
        }

        public bool RecargarTinta(int cantidad)
        {
            bool retorno = false;

            if (this._cantidadTinta < 50 && this._cantidadTinta+cantidad<100)
            {
                this._cantidadTinta =this._cantidadTinta+cantidad;
                retorno = true;
            }
            return retorno;
        }
        #endregion


        #region SobrecargaOperadores
        public static bool operator ==(Boligrafo b1 , Boligrafo b2)
        {
            bool retorno = false;

            if(b1._marca==b2._marca && b1._color == b2._color)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Boligrafo b1, Boligrafo b2)
        {
            return !(b1 == b2);
        }

        public static List<Boligrafo> operator +(List<Boligrafo> lista, Boligrafo pen)
        {
            lista.Add(pen);
            return lista;
        }

        public static List<Boligrafo> operator -(List<Boligrafo> lista, Boligrafo pen)
        {
            int i;
            int tamaño;

            tamaño = lista.Count;
            for(i=0;i<tamaño; i++)
            {
                if(lista[i]==pen)
                {
                    lista.RemoveAt(i);                 
                }
            }

            return lista;
        }

        #endregion

    }
}
