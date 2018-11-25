using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Fruta-> _color:string y _peso:double (protegidos); TieneCarozo:bool (prop. s/l, abstracta);
    //constructor con 2 parametros y FrutaToString():string (protegido y virtual, retorna los valores de la fruta)
    public abstract class Fruta
    {
        protected string _color;
        protected double _peso;


        public abstract bool TieneCarojo { get; }

        public double Peso
        {
            get
            {
                return this._peso;
            }
            set
            {
                this._peso = value;
            }
        }

        public string Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        

        public Fruta()
        {

        }

        public Fruta(string color , double peso)
        {
            this.Color= color;
            this.Peso = peso;
        }

        protected virtual string FrutaToString()
        {
            return string.Format("Color: {0} Peso: {1}",this._color,this._peso);
        }


    }
}
