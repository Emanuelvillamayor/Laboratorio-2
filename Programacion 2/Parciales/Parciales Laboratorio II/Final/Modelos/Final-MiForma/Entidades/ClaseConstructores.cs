using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{

    //crear una clase (ClaseConstructores) que al instanciarse:
    //    *pase por un constructor estático
    //    *pase por un constructor que reciba 2 parámetros (privado)
    //    *pase por un constructor publico (default)
    //    *pase por una propiedad de sólo escritura
    //    *pase por una propiedad de sólo lectura
    //    *pase por un método de instancia
    //    *pase por un método de clase
    //NOTA: por cada lugar que pase, mostrar con un MessageBox.Show dicho lugar
    //NOTA: agregar la referencia a System.Windows.Form; para poder acceder a la clase MessageBox.
    //NOTA: NO MAS DE 2 LINEAS DE CODIGO POR METODO/PROPIEDAD/CONSTRUCTOR
    public class ClaseConstructores
    {
        private int num1 ;
        private int num2;

        static ClaseConstructores()
        {
            MessageBox.Show("Pasa constructor estatico");
        }
        private ClaseConstructores(int i , int b)
        {
            MessageBox.Show("Pasa constructor privado");
            this.PropiedadEscritura = b;
            num1 = this.PropiedadLectura;
        }

        public ClaseConstructores():this(2,5)
        {
            MessageBox.Show("Pasa constructor  Publico");
            this.Metodo();
        }

        public int PropiedadLectura
        {
            get
            {
                MessageBox.Show("Pasa propiedad Lectura");
                return 2;
            }
        }

        public int PropiedadEscritura
        {
            set
            {
                MessageBox.Show("Pasa propiedad Escritura");
                int num = value;
            }
        }


        public void Metodo()
        {
            MessageBox.Show("Pasa metodo instancia");
            ClaseConstructores.MetodoEstatico();
        }
        public static void MetodoEstatico()
        {
            MessageBox.Show("Pasa metodo estatico");
        }
    }
}
