using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase19_2
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        //metodo publico que cambia el nombre
        public void ActualizarNombre(string nombre)
        {
            this.label1.Text = nombre;
        }

       
    }
}
