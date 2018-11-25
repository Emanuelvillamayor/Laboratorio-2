using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Archivos
{
    public class Texto
    {
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }

        public static bool Leer(string path, out string dato)
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }
        //public bool Guardar(string path)
        //{
        //    bool retorno = false;

        //    try
        //    {


        //        using (StreamWriter sm = new StreamWriter(path, false))
        //        {
        //            sm.WriteLine(this.ToString());
        //        }

        //        retorno = true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    return retorno;
        //}



        //public bool Recuperar(string path)
        //{
        //    bool retorno = false;
        //    try
        //    {
        //        using (StreamReader sr = new StreamReader(path))
        //        {

        //            Console.WriteLine(sr.ReadToEnd());
        //            retorno = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    return retorno;
        //}

    }
}
