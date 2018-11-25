using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class DepositoHeredado : Deposito, ISerializar,IDeserializar
    {

        public DepositoHeredado()
        {

        }

        public bool Xml(string cadena)
        {
            bool retorno = false;

            try
            {
                XmlSerializer serialize = new XmlSerializer(typeof(DepositoHeredado));
                XmlTextWriter xw = new XmlTextWriter(cadena, Encoding.UTF8);
                serialize.Serialize(xw,this);
                xw.Close();
                retorno = true;
            }
            catch(Exception e)
            {
                throw e;
            }

            return retorno;
        }

        bool IDeserializar.Xml(string path, out DepositoHeredado dep)
        {
            bool retorno = false;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DepositoHeredado));
                XmlTextReader xr = new XmlTextReader(path);
                dep = (DepositoHeredado)serializer.Deserialize(xr);
                xr.Close();
                retorno = true;
          
            }
            catch(Exception e)
            {
                throw e;
            }

            return retorno;
        }
    }
}
