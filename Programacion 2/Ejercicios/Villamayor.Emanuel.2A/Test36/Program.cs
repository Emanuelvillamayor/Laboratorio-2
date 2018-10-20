using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades36;
namespace Test36
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(2, "vi");
            AutoF1 a2 = new AutoF1(2, "vi");
            AutoF1 a3 = new AutoF1(3, "boo");

            Console.WriteLine(a1 == a2);
            Console.WriteLine(a1 == a3);


        }
    }
}
