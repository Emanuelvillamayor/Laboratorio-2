using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase18
{
    public class TVEventsArgs : EventArgs
    {

        public DateTime Fecha
        {
            get
            {
                return DateTime.Now;
            }
            //set;
        }



    }
}
