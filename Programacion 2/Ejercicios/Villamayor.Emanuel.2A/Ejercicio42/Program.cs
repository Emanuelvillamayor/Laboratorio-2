﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*42. Crear el código necesario para lanzar una excepción DivideByZeroException en un método estático,
capturarla en un constructor de instancia y relanzarla hacia otro constructor de instancia que creará
una excepción propia llamada UnaException (utilizar innerException para almacenar la excepción
original) y volver a lanzarla. Luego pasará por un método de instancia que generará una excepción
propia llamada MiException. MiException será capturada en el Main, mostrando el mensaje de
error que esta almacena y los mensajes de todas las excepciones almacenadas en sus
innerException.*/


namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Clase3 clase = new Clase3();
                clase.MetodoInstancia();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
