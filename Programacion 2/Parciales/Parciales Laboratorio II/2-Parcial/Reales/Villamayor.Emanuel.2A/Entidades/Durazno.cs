using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Durazno-> _cantPelusa:int (protegido); Nombre:string (prop. s/l, retornará 'Durazno'); 
    //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true
    public class Durazno : Fruta
    {
        protected int _cantPelusa;

        public String Nombre
        {
            get
            {
                return "Durazno";
            }
        }

        public override bool TieneCarojo
        {
            get
            {
                return true;
            }
        }

        public Durazno()
        {

        }

        public Durazno(string color , double peso , int pelusa): base(color,peso)
        {
            this._cantPelusa = pelusa;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutaToString());
            sb.AppendFormat("Cantidad De pelusa: {0}", this._cantPelusa);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
