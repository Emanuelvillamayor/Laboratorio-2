using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase18
{
    //DERIVA DE EVENT ARGS LA CUAL GENERALMENTE SE UTILIZA PARA BRINDAR INFO
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
