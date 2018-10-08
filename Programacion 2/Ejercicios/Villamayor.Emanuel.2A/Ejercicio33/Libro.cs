using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Libro
    {
        private List<string> _paginas;

            public string this [int i]
        {
            get
            {
                if(i>=0 && i< this._paginas.Count)
                {
                    return this._paginas[i];
                }
                else
                {
                    return "";
                }

            }

            set
            {
                foreach(string item in this._paginas)
                {
                    if(item == value)
                    {
                        this._paginas.Add(value);
                    }
                }

             
            }
        }



    }
}
