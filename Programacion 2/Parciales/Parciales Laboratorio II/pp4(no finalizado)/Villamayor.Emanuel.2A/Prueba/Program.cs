using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Prueba
{
    class Program
    {
        static void Main(string[] args)

        {
            //VER ESTE EJEMPLO SIN HACER LA CLASE ANIMAL ABSTRACTA

            // Animal a1 = new Animal(10, 80);

            // Console.WriteLine( a1.MostrarDatos());

            //-------------HUMANO------------------  

            Console.WriteLine("HUMANOS \r\n");

            Humano h1 = new Humano("Lucas","Villamayor",29);
            Humano h2 = new Humano("Jorge", "Alcina", 70);

            Console.WriteLine(h1.MostrarHumano());
    
            Console.WriteLine(h2.MostrarHumano());

            Console.WriteLine(h1 == h2);
           
            Console.WriteLine(h1 != h2);

            Console.ReadLine();
            Console.Clear();

       
            //--------------Perros---------------

            Console.WriteLine("PERROS \r\n");

            Perros p1 = new Perros(Perros.Razas.Galgo, 40);
            Perros p2 = new Perros(20);

            Console.WriteLine(p1.MostrarPerro());

            Console.WriteLine(p2.MostrarPerro());

            Console.WriteLine(p1 == p2);
           
            Console.WriteLine(p1 != p2);
            
            Console.WriteLine(p1 == p1); //comparo dos iguales

            Console.ReadLine();
            Console.Clear();

            //--------------CABALLOS----------------

            Console.WriteLine("Caballos \r\n");

            Caballo c1 = new Caballo("Jorge", 50);
            Caballo c2 = new Caballo("Lusito", 20);

            Console.WriteLine(c1.MostrarCaballo());

            Console.WriteLine(c2.MostrarCaballo());

            Console.WriteLine(c1 == c2);

            Console.WriteLine(c1 != c2);

            Console.WriteLine(c1 == c1); //comparo dos iguales


            Console.ReadLine();
            Console.Clear();

            Carrera car1 = new Carrera(3);

            car1 += c1;
            car1 += c2;
            car1 += c1; //intento agregar uno igual
            car1 += p2;
            car1 += p1; //intento agregar uno de mas

           
            Console.WriteLine(car1 == c2);





        }
    }
}
