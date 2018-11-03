﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

using Excepciones;
namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlTextWriter sw = new XmlTextWriter(archivo, Encoding.UTF8);
                serializer.Serialize(sw, datos);              
                sw.Close();
                retorno = true;
            }

            catch(Exception e)
            {
                throw new ArchivosException(e);
            }

            return retorno;
            
        }

        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlTextReader sr = new XmlTextReader(archivo);
                datos = (T)serializer.Deserialize(sr);
                sr.Close();

                retorno = true;
            }
            catch(Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }
    }
}
