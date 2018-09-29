using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Ejercicio16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";

            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();


            alumno1.apellido = "villamayor";
            alumno1.nombre = "emanuel";
            alumno1.legajo = 107346;

            alumno2.apellido = "rodriguez";
            alumno2.nombre = "gustavo";
            alumno2.legajo = 124343;

            alumno3.apellido = "perez";
            alumno3.nombre = "homero";
            alumno3.legajo = 108734;

            alumno1.Estudiar(4, 6);           
            alumno1.CalcularFinal();
            alumno1.Mostrar();

            alumno2.Estudiar(2, 3);
            alumno2.CalcularFinal();
            alumno2.Mostrar();

            alumno3.Estudiar(5, 1);
            alumno3.CalcularFinal();
            alumno3.Mostrar();


            Console.ReadLine();


        }
    }
}
