using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase18;
namespace Ejercicioclase18
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisor tele = new Televisor(12, "hitcahi", 23476, 23, "rusia");
            Program pro = new Program();

            tele.miEvento += new MiDelegado(Program.PruebaEvento);
            tele.miEvento += new MiDelegado(pro.PruebaEvento2);
            tele.eventoTv += new DelegadoTV(Program.MuestroTvAgregado);
            tele.Insertar();
            Console.ReadKey();

            

        }

        public static void PruebaEvento()
        {
            Console.WriteLine("Se inserta un registro en la lista");
        }

        public void PruebaEvento2()
        {
            Console.WriteLine("Estoy en el segundo de los metodos del delegado");
        }

        public static void MuestroTvAgregado(Televisor tele, TVEventsArgs args)
        {
            Console.WriteLine("codigo: {0} marca: {1} precio: {2} pulgadas: {3} pais: {4}", tele.id, tele.marca, tele.precio, tele.pulgadas, tele.pais);
            Console.WriteLine("Horario {0:G}", args.Fecha);
        }
    }
 
}
