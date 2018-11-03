using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;

            try
            {
                using (StreamWriter sm = new StreamWriter(archivo, false))
                {
                    sm.WriteLine(datos);
                }
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e); 
            }

            return retorno;
        }
    

        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            datos = "";
            try
            {
               using (StreamReader sr = new StreamReader(archivo))
               {
               datos = sr.ReadToEnd();
               }
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
