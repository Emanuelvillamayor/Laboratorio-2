using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Excepciones.Final
{
   public class Burbujeo
    {

        public void MetodoInstacia()
        {
            using (StreamWriter sw = new StreamWriter("burbujeo.txt", false))
            {
                sw.WriteLine("Paso por el metodo de instancia " + DateTime.Now.ToString());
            }
            throw new ExceptionPropia("\nPaso por el metodo de instancia " + DateTime.Now.ToString());
        }

        public static void MetodoClase()
        {
            try
            {
                Burbujeo b = new Burbujeo();
                b.MetodoInstacia();


            }
            catch (ExceptionPropia e)
            {

                using (StreamWriter sw = new StreamWriter("burbujeo.txt", true))
                {
                    sw.WriteLine("\nPaso por el metodo estatico " + DateTime.Now.ToString());
                }

                throw new ExceptionPropia(e.Message + "Paso por el metodo estatico " + DateTime.Now.ToString(), e);
            }
        }

    }
}
