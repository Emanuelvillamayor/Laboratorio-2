using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades47
{
    public class Pez : Animal, Mascota
    {
        #region Atributos

        private string _nombre;

        #endregion

        #region Constructores
        public Pez()
            {

            }


        public Pez(string nombre , int patas) : base(patas)
        {
            
        }

        #endregion

        #region Propiedades


        public string Nombre
        {
            get
            {
                return this._nombre;
            }

            set
            {
                this._nombre = value;
            }

        }

        #endregion

        #region Metodos

        public override string Comer()
        {
            return "Bacterias , comida para peces , peces ";
        }

        public void Jugar()
        {
            Console.WriteLine("Juega con otros peces");
        }

        public override string Caminar()
        {
            return "Este animal no camina";
        }

        #endregion
    }
}
