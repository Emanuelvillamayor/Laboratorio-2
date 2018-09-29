using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAparte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "hola"; //camibiar texto a la etiqueta "label"
        }

        private void btnDespedida_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Gracias vuelva prontos!";

            //referencia al form para modificarlo dentro de el btn
            // "this" refiere al formulario
            this.Text = "bye"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = ""; // limpia el mensaje mientras se carga el form
        }
    }
}
