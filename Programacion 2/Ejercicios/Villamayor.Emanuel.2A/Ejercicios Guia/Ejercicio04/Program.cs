using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Ejercicio04
    {
        static void Main(string[] args)
        {
            Int32 i;
            Int32 j;
            Int32 acum = 0;

            Console.Title = "Ejercicio 04";

            for(i=1;i<10000-1;i++)
            {
                acum = 0;
                for(j=1;j<i;j++)
                {
                    if(i%j==0)
                    {
                        acum=acum + j;
                    }
                }

                if (acum == i)
                {
                    Console.WriteLine("{0}", i);
                }
           
            }

            Console.ReadLine();
        }
    }
}
