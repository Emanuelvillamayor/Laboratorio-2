using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    //Implementar (implicitamente) ISerializar en Cajon y manzana
    //Implementar (explicitamente) IDeserializar en manzana
    //Los archivos .xml guardarlos en el escritorio del cliente
    public class Manzana :Fruta,ISerializar,IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre
        {
            get
            {
                return "Manzana";
            }

        }

        public string ProvinciaOrigen
        {
            get
            {
                return this._provinciaOrigen;
            }
            set
            {
                this._provinciaOrigen = value;
            }
        }

        public override bool TieneCarojo
        {
            get
            {
                return true;
            }
        }

        public Manzana()
        {

        }

        public Manzana(string color , double precio , string  provi): base(color,precio)
        {
            this.ProvinciaOrigen= provi;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutaToString());
            sb.AppendFormat("Provincia Origen: {0}",this.ProvinciaOrigen);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public bool Xml(string path)
        {
            string path2 = @"\" + path;
            bool retorno = false;
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Manzana));
                XmlTextWriter xw = new XmlTextWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + path2), Encoding.UTF8);
               
                sr.Serialize(xw, this);
                xw.Close();
                retorno = true;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return retorno;
        }

        bool IDeserializar.Xml(string path, out Fruta f)
        {
            bool retono = false;
            string path2 = @"\" + path;
            f = null;
                try
                {
                    XmlSerializer sr = new XmlSerializer(typeof(Manzana));
                    XmlTextReader xr = new XmlTextReader(((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + path2)));                   
                    f = (Manzana)sr.Deserialize(xr);
                    xr.Close();
                retono = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            return retono;
        }
    }
}
