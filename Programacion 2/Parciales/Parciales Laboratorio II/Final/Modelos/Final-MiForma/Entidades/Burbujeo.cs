using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Entidades
{
    //Realizar el burbujeo de una excepción propia (MiException), comenzando en un método de instancia (de la clase Burbujeo),
    //pasando por un método de estático (de la misma clase) y capturado por última vez en el método que lo inició (manejador _click).
    //En cada paso, agregar en un único archivo de texto (burbujeo.txt)
    //el lugar por donde se paso junto con la hora, minuto y segundo de la accion. 
    //Atrapar la excepción y relanzarla en cada ocasión, al finalizar, leer el archivo y mostrarlo por MessageBox
    public class Burbujeo
    {


        public void MetodoInstacia()
        {
            using (StreamWriter sw = new StreamWriter("burbujeo.txt", false))
            {
                sw.WriteLine("Paso por el metodo de instancia "+DateTime.Now.ToString());
            }
                throw new MiException("\nPaso por el metodo de instancia "+ DateTime.Now.ToString());
        }

        public static void MetodoClase()
        {
            try
            {
                Burbujeo b = new Burbujeo();
                b.MetodoInstacia();
               
             
            }
            catch(MiException e)
            {
                
                using (StreamWriter sw = new StreamWriter("burbujeo.txt", true))
                {
                    sw.WriteLine("\nPaso por el metodo estatico "+DateTime.Now.ToString());
                }

                throw new MiException (e.Message + "Paso por el metodo estatico "+ DateTime.Now.ToString(), e);
            }
        }
    }
}
