﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.Ejercicio42
{
    class MiException:Exception
    {

        public MiException(string cadena, Exception excp) : base(cadena, excp)
        {

        }
    }
}