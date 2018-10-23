using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase14_2;
namespace TestClase14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cocina c1 = new Cocina(111, 12300, false);
            Cocina c2 = new Cocina(112, 15000, true);
            Cocina c3 = new Cocina(113, 5600, false);
            DepositoDeCocinas dc = new DepositoDeCocinas(5);
            dc.Agregar(c1);
            dc.Agregar(c2);
            if (!(dc + c3))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(dc);
            dc.Remover(c2);
            if (!(dc - c2))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(dc);

            // if(dc.Guardar("D:\\MisDocumentos\\Cocinas.txt")) //agregar dos barras porque sino lo toma como secuencia de escape o sino:
            if (dc.Guardar(@"D:\Manu\Cocinas.txt")) //el arroba lo que hace es decirle que va a ser todo literal que no tiene secuencia de escape
            {
                Console.WriteLine("Guardado");
            }

            if (dc.Recuperar(@"D:\Manu\Cocinas.txt")) //leo el archivo que cree
            {
                Console.WriteLine("Leido");
            }


            Console.ReadLine();



        }
    }
}
