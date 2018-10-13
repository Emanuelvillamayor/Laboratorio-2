using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        #region Atributos

        private int _edad;
        private bool esAlfa;

        #endregion

        #region Propiedades
        public int Edad
        {
            get { return this._edad; }

            set{ this._edad = value; }
        }

        public bool EsAlfa
        {
            get { return this.esAlfa; }

            set { this.esAlfa = value; }
        }

        #endregion

        #region Constructores
        public Perro(string nombre, string raza) : this(nombre,raza,0,false)
        {

        }

        public Perro(string nombre , string raza, int edad,bool esAlfa) : base(nombre,raza)
        {
            this.Edad = edad;
            this.esAlfa = esAlfa;
        }

        #endregion

        #region Metodos

        protected override string Ficha()
        {
            string retorno = "";

            if(this.EsAlfa==true)
            {
                retorno +=base.DatosCompletos() + ",alfa de la manada," + "edad " + this.Edad.ToString(); 
            }
            else
            {
                retorno += base.DatosCompletos() + "edad " + this.Edad.ToString();
            }

            return retorno;
        }

        #endregion

        #region Operadores

        public static bool operator ==(Perro p1 ,Perro p2)
        {
            bool retorno = false;

            if(p1.Raza==p2.Raza && p1.Nombre==p2.Nombre && p1.Edad==p2.Edad)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int (Perro perro)
        {
            return perro.Edad;
        }

        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
              if (obj is Perro)
              {
                  if (this == (Perro)obj)
                  {
                      retorno = true;
                  }
              }
          
            return retorno;
        }

        #endregion
    }
}
