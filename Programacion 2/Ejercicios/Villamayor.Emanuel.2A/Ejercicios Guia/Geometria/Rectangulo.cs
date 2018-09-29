using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        #region ATRIBUTOS

        // 4 Vertices del rectagulo

        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        private float area;
        private float perimetro;

        #endregion

        #region METODOS

        public float GetArea()
        {
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }



        #endregion
    }
}
