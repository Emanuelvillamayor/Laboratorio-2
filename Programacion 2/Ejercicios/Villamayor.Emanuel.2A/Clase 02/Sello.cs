using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Sello
    {
        public static String mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            String cadena = "";
            String retorno = "Error cadena vacia";
            if (Sello.TryParse(Sello.mensaje, out cadena))
           // if (Sello.TryParse(Sello.mensaje))
            {
                
                 Sello.mensaje = cadena;
                retorno = Sello.ArmarFormatoMensaje();
            }

            return retorno;
        }

        public static void borrar()
        {
            Sello.mensaje = "";

        }

        public static void ImprimirEnColor()
        {

            Console.ForegroundColor = Sello.color;

            //Console.WriteLine(Sello.mensaje); se puede hacer de esta forma tambien
            Console.WriteLine(Sello.Imprimir());

            Console.BackgroundColor = ConsoleColor.Gray;

        }
        private static string ArmarFormatoMensaje()
        {
            String cadena = ""; //aca guardo la parte de arriba Y SIEMPRE TIENE QUE INICIALIZARSE UN STRING
            String mensaje = Sello.mensaje;
            String medio = "";
            String final = "";
            Int32 len;
            Int32 i;

            len = (mensaje.Length) + 2; //le agrego dos que son los que sobresalen a la palabra

            for (i = 0; i < len; i++)
            {
                cadena += "*";
            }

            medio += "\n*";
            medio += mensaje;
            medio += "*\n";

            final += cadena;
            final += medio;
            final += cadena;

            return final;
        }


        
       // public static Boolean TryParse(String mensaje)
       public static Boolean TryParse(String mensaje, out String  cadena)
        {
            Int32 len;
             cadena = "";
            Boolean retorno = false;
            len = mensaje.Length;
            if (len > 0)
            {
                retorno = true;
                    cadena = mensaje;
            }
            return retorno;
        }

    }
}
