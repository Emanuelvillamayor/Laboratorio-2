using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static bool EsPar(this Int32 entero)
        {
            return (entero%2) == 0 ? true : false;
        }
        public static bool EsImpar(this Int32 entero)
        {
            return !(EsPar(entero));
        }
    }
}
