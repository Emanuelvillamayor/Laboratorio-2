using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades43;
     
namespace TestEjercicio43
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(2, "vi");
            bool vo;
            AutoF1 a2 = new AutoF1(2, "vi");
            AutoF1 a3 = new AutoF1(3, "boo");
            MotoCross m1 = new MotoCross(21, "as");
            MotoCross m2 = new MotoCross(21, "as");
            MotoCross m3 = new MotoCross(19, "loa");
            Competencia comp = new Competencia(3, 4, ETipoCompetencia.F1);

            try
            {
                Console.WriteLine(a1 == a2);
                Console.WriteLine(a1 == a3);

                Console.WriteLine(m1 == m2);
                Console.WriteLine(m1 == m3);

                vo = comp + m1;
            }
            catch(CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();


        }
    }
}
