using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades

{
    class Cosa
    {
        #region Atributos
        public String cadena; //de instancia
        public Double numero;//de instancia
        public DateTime fecha;//de instancia
        #endregion

        #region Metodos

        public static String Mostrar(Cosa objeto)
        {


            return objeto.Mostrar();

        }//retorne valor de cadena concatenado con todo asi luego en el main hago console.write libe y me lo devuelve de una

       
        //lo puedo utilizar desde un objeto creado y va a hacer referencia solo a ese objeto
        private String Mostrar()
        {
           String retorno = "";

           retorno += this.cadena + " " + this.numero + " " + this.fecha;
            
           return retorno;
        }

        public void EstablecerValor(string c)
        {
            this.cadena = c;
        }

        public void EstablecerValor(string c,Double a)
        {
            this.numero = a;
            
            
        }

        public void EstablecerValor(string c, Double b,DateTime a)
        {
            this.fecha = a;
      
        }
        #endregion

        #region Constructores

        //si accedo al constructor por defecto , la cadena = "sin valor" , numero = 1.9  , fecha=DateTime.now;
        public Cosa()
        {
            this.cadena = "Sin valor";
            this.numero = 1.9;
            this.fecha = DateTime.Now;
        }

        public Cosa(String c) : this()
        {
            this.cadena = c;
           // this.numero = 1.9;
            //this.fecha = DateTime.Now;
        }

        public Cosa(string c, Int32 n) : this(c)
        {
            //this.cadena = c;
             this.numero = n;
            //this.fecha = DateTime.Now;
        }

        public Cosa(string c ,Int32 n , DateTime d): this(c,n)
        {
            //this.cadena = c;
           // this.numero = n;
            this.fecha = DateTime.Now;
        }


        #endregion


    }
}
