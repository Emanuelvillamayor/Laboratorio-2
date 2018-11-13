using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entidades58
{
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        public bool Guardar(string ruta , PuntoDat obj)
        {
            bool retorno = false;         
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(obj);
                }
                retorno = true;                      

               return retorno;

        }

        public PuntoDat Leer(string ruta)
        {
            throw new NotImplementedException();
        }

        protected override bool ValidarArchivo(string ruta)
        {
            bool retorno = false;

            try
            {
                if (base.ValidarArchivo(ruta))
                {
                    if(Path.GetExtension(ruta)==".dat")
                    {
                       retorno= true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El Archivo no es un .dat");
                    }
                }
            }
            catch(FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }

            return retorno;
        }
    }
}
