using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;


        public int CantidadDePaginas
        {
            get
            {
                int retorno;
                if (this._cantidadDePaginas == 0)
                {
                    retorno = Libro._generadorDePaginas.Next(10, 580);
                }
                else
                {
                    retorno = this._cantidadDePaginas;
                }

                return retorno;
            }
        }
            static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }

        public Libro(float precio , string titulo , string nombre , string apellido) : this(titulo, new Autor(nombre, apellido), precio)
        {
         
        }

        public Libro (string titulo , Autor autor , float precio)  
        {
            this._precio = precio;
            this._titulo = titulo;
            this._autor = autor;
        }
      
        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("TITULO: {0}\n", l._titulo);
            sb.AppendFormat("CANTIDAD DE PAGINAS: {0}\n", l.CantidadDePaginas);
            sb.AppendFormat( l._autor);
            sb.AppendFormat("PRECIO: {0}", l._precio);

            return sb.ToString();
        }

        public static bool operator ==(Libro l1 , Libro l2)
        {
            bool retorno = false;

            if(l1._titulo==l2._titulo && l1._autor==l2._autor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        public static explicit operator string (Libro l)
        {
            return Libro.Mostrar(l);
        }


        

    }
}
