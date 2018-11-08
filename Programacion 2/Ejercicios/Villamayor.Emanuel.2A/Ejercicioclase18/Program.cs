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
            Televisor tele = new Televisor(12, "hitachi", 23476, 23, "rusia");
            Program pro = new Program();

            Televisor.Borrar(tele); //lo borro porque viene cargado de la base de datos asi puedo volverlo a agregar

           
            //agrego metodos a  el atributo de eventos de mi objeto televisor

            tele.miEvento += new MiDelegado(Program.PruebaEvento);
            tele.miEvento += new MiDelegado(pro.PruebaEvento2);
            tele.eventoTv += new DelegadoTV(Program.MuestroTvAgregado);
            //inserto esa television en mi base de datos y a su vez lanzo el evento
            tele.Insertar();




            Console.ReadKey();

            

        }

        #region METODOS PRIMER DELEGADO

        public static void PruebaEvento()
        {
            Console.WriteLine("Se inserta un registro en la lista");
        }

        public void PruebaEvento2()
        {
            Console.WriteLine("Estoy en el segundo de los metodos del delegado");
        }

        #endregion

        #region METODOS  SEGUNDO DELEGADO

        public static void MuestroTvAgregado(Televisor tele, TVEventsArgs args)
        {
            Console.WriteLine("codigo: {0} marca: {1} precio: {2} pulgadas: {3} pais: {4}", tele.id, tele.marca, tele.precio, tele.pulgadas, tele.pais);
            Console.WriteLine("Horario {0:G}", args.Fecha);
        }

        #endregion
    }

}
