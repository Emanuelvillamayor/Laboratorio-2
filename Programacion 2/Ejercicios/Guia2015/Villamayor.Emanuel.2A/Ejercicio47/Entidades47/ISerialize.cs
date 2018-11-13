using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades47
{
  public  interface ISerialize
    {

        bool Serializar(string path, object obj);
             

    }
}
