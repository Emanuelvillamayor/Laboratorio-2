using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Data;

namespace Archivos
{
    class Serializar
    {
       public void metod()
        {
            XmlSerializer sr = new XmlSerializer(typeof(string)); // nole pasamos un solo televisr sino la LISTA para que serialize una coleccion de objetos
            XmlTextWriter xw = new XmlTextWriter("Televisor.xml", Encoding.UTF8);
            XmlTextReader xr = new XmlTextReader("Televisor.xml");

            xw.Close(); // lo cerramos pa que no pinche

            List<string> listaTelevisorRead;
            listaTelevisorRead = (List<string>)sr.Deserialize(xr);
            xr.Close();

        }
    }
}
