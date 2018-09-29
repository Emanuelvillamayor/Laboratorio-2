using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Ejercicio08
    {
        static void Main(string[] args)
        {
            Single valorHora;
            String nombre;
            Int32 antiguedad;
            Int32 horaMes;

            Single valorBruto; //multiplicar (valorHora y horaMes) + (antiguedad * %150) y al total  restarle %13 en concepto de descuento = total bruto
            Single descuento; //solo el 13% que se le descuenta
            Single valorNeto; //total con descuento  (neto = bruto - descuento)


            String opcion;

            do {

                Console.Write("Ingrese el nombre del usuario:");
                nombre = Console.ReadLine();

                Console.Write("Ingrese horas : ");
                valorHora = Single.Parse(Console.ReadLine());

                Console.Write("Ingrese antiguedad (años) : ");
                antiguedad = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese cantidad de horas trabajadas : ");
                horaMes = Int32.Parse(Console.ReadLine());

                valorBruto = (valorHora * (Single)horaMes) + (antiguedad*150f); //obtengo valor bruto sin descuento

                valorNeto= (((valorHora * (Single)horaMes) + (antiguedad * 150f))-((13f/100)*valorBruto)); //le coloco la "f " para que sea flotanto y no lo reconozca como entero

                descuento = (13f / 100) * valorBruto; //obtengo solo el descuento

                Console.WriteLine("Valor Bruto : {0}", valorBruto);
                Console.WriteLine("Valor Nerto: {0}", valorNeto);
                Console.WriteLine("Valor del descuento : {0}", descuento);


                Console.Write("¿Desea ingresar otro usuario? (si/no)");
                opcion = Console.ReadLine();

            } while (opcion != "no");

        }
    }
}
