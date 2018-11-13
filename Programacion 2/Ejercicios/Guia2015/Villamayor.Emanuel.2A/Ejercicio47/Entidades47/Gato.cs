using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades47
{
    public class Gato : Animal, Mascota,ISerialize
    {
        #region Atributos

        private string _nombre;

        #endregion

        #region Constructores 

        public Gato()
        {


        }

        public Gato(string nombre , int patas): base(patas)
        {
            this.Nombre = nombre;
        }

        #endregion


        public void Jugar()
        {
            Console.WriteLine("Juega con bolas de hilo");
        }

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

        public override string Comer()
        {
            return "CatChow , Pescado , Carne , Pollo";
        }

        public override string Caminar()
        {
            return base.Caminar();
        }

        bool ISerialize.Serializar(string path, object obj)
        {
            bool retorno = false;

            try
            {
                XmlTextWriter xw = new XmlTextWriter(path, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(Gato));

                serializer.Serialize(xw, this);
                xw.Close();
                retorno = true;
                    }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }
    }
}
