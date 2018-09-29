using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Ejercicio20
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";

            /*  Dolar d = new Dolar(3);
              Dolar d2 = new Dolar(5);
              Euro e = new Euro(2);
              Pesos p = new Pesos(3);

              e = (Euro)d;
              p = (Pesos) d;
              d2 = 3; //modifico la cantidad de dolar con un double

             // pasajes de dolar a euro , pesos y a dolar denuevo
              Console.WriteLine("Dolar : {0:#,###.00}", d.GetCantidad());
              Console.WriteLine("Dolar2 : {0:#,###.00}", d2.GetCantidad());
              Console.WriteLine("Euro : {0:#,###.00}", e.GetCantidad());
              Console.WriteLine("Pesos: {0:#,###.00}", p.GetCantidad());

              Console.WriteLine();

              Dolar d3 = new Dolar(4);
              Euro e2 = new Euro(6);
              Pesos p2 = new Pesos(17.55);

              d3 = (Dolar) p2;
              e2 = (Euro)p2;
              p2 = 2;

              // pasaje de pesos a dolar , a euro
              Console.WriteLine("Dolar3 : {0:#,###.00}", d3.GetCantidad());
              Console.WriteLine("Euro2 : {0:#,###.00}", e2.GetCantidad());
              Console.WriteLine("Pesos luego: {0:#,###.00}", p2.GetCantidad());


              Console.WriteLine();

              Euro e3 = new Euro(1.3642);

              p2 = (Pesos)e3;
              d3 = (Dolar)e3;
              e2 = e3;

              //pasaje de euro a peso y a dolar
              Console.WriteLine("Dolar3 : {0:#,###.00}", d3.GetCantidad());
              Console.WriteLine("Pesos2 : {0:#,###.00}", p2.GetCantidad());
              Console.WriteLine("Euro luego: {0:#,###.00}", e2.GetCantidad());


              //prueba suma dolar y euro devuelve dolar

              d = d3 + e3;

              Console.WriteLine("Dolar + : {0:#,###.00}", d.GetCantidad());

              //prueba resta dolar y euro devuelve dolar

              d = d3 - e3;

              Console.WriteLine("Dolar - : {0:#,###.00}", d.GetCantidad());

              //prueba suma dolar y peso devuelve dolar

              d = d2 + p2;

              Console.WriteLine("Dolar + : {0:#,###.00}", d.GetCantidad());

              Console.WriteLine("Comparando dos dolares:");
              Console.WriteLine(d == d2);

              Console.WriteLine(d != d2);
              

            Euro e4 = new Euro(2);
            Dolar d5 = new Dolar(3);
            e4=1;
            d5 = 1.3642;
            Console.WriteLine("Comparando dolar y euro :");
            Console.WriteLine(d5 == e4);
            Console.WriteLine(d5 != e4);*/

            /*  Pesos p5 = new Pesos(1);
              Dolar d6 = new Dolar(2);
              p5 = 17.55;
              d6 = 1;
              Console.WriteLine("Comparando dolar y euro :");
              Console.WriteLine(d6 == p5);
              Console.WriteLine(d6 != p5);
              */

            ///////////////////////////EURO//////////////////////////////////
            /*     Euro e1 = new Euro(1);
                 Dolar d1 = new Dolar(1.3642);

                 d1 = (Dolar) e1;

                 Console.WriteLine("De euro a  dolar: {0:#,###.00}", d1.GetCantidad());

                 Euro e2 = new Euro(1);
                 Pesos p1 = new Pesos(23.94171);

                 p1 = (Pesos)e2;

                 Console.WriteLine("De euro a peso :  {0:#,###.00}", p1.GetCantidad());


               Euro e3 = new Euro(1);
               Dolar d2 = new Dolar(1.3642);

               e3 =  e3+d2 ;

               Console.WriteLine("Suma de euro y dolar , devuelve euro :  {0:#,###.00}", e3.GetCantidad());

              Euro e4 = new Euro(1);
               Pesos p3 = new Pesos(23.94171);

               e4 = e4 + p3;

               Console.WriteLine("Suma de euro y pesos, devuelve euro :  {0:#,###.00}", e4.GetCantidad()); */



            Dolar d = new Dolar(1.36242);
            Euro e = new Euro(1);
            Console.WriteLine(d == e);                







          Console.ReadLine();

        }
    }
}
