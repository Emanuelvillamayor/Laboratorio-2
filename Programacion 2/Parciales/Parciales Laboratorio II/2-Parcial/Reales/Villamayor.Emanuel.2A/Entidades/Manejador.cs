using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
   public class Manejador
    {
        

        public void manejadorTexto(object sender)
        {
            try
            {

                using (StreamWriter sm = new StreamWriter("manejadorTexo.txt", false)) 
                {
                    sm.WriteLine(sender.ToString());
                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
