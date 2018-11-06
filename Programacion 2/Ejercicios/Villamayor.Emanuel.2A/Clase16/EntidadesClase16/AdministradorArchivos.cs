using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EntidadesClase16
{
    /*clase estatica dos metodos , parametro string y ambas retorna booleano
    primer parametro el path y el segundo parametro lo que tengo que escribir y lo que tengo que leer
    el booleano indica si pudo o no leer*/

    public static class AdministradorArchivos
    {

        #region Metodos

        public static bool Escribir(string path, string dato)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter sm = new StreamWriter(path, false))
                {
                    sm.WriteLine(dato);
                }
                retorno = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno; 
        }

        public static bool  Leer(string path ,out string  dato)
        {
            bool retorno = false;
            dato = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    dato = sr.ReadToEnd();
                }
            retorno = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }

        #endregion



    }
}
