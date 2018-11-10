using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio57
{
   public class Persona
    {
        #region Atributos

        private string nombre;
        private string apellido;

        #endregion

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
                }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        #endregion


        #region Constructores

        public Persona()
        {

        }

        public Persona(string nombre , string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion


        #region Metodos


        public static void Guardar(Persona p)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                XmlTextWriter sw = new XmlTextWriter("persona.xml", Encoding.UTF8);
                serializer.Serialize(sw, p);
                sw.Close();
            
            }
            //no tiene constructor sin parametros la clase
            //la clase debe ser publica
            catch (InvalidOperationException e)
            {
                throw e;
            }


        }

        public static Persona Leer(string path)
        {
            Persona retorno ;
            try
            {
                XmlSerializer serialize = new XmlSerializer(typeof(Persona));
                XmlTextReader wr = new XmlTextReader(path);

                retorno = (Persona)serialize.Deserialize(wr);
            }
            catch(Exception e)
            {
                throw e;
            }

            return retorno;
        }

        #endregion

        public override string ToString()
        {
            return string.Format("NOMBRE: {0}\nAPELLIDO: {1}", this.nombre, this.apellido);
        }
    }
}
