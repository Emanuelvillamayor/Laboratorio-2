using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Villamayor.Emanuel._2A
{
    public partial class Form1 : Form
    {
        Carrera carrera;
        public Form1()
        {
            InitializeComponent();
            carrera = new Carrera(7);
        }

        private void btnPruebaClases_Click(object sender, EventArgs e)
        {


            Animal a1 = new Perros(Perros.Razas.Galgo, 60);
            carrera += a1;
            Perros a2 = new Perros(Perros.Razas.Galgo, 60);
            carrera += a2;
            Humano a3 = new Humano("Juan", "Gomez", 20);
            carrera += a3;
            Caballo a4 = new Caballo("Veloz", 70);
            carrera += a4;
            Caballo a5 = new Caballo("Match 5", 75);
            carrera += a5;
            Animal a6 = new Humano("Pedro", "Martínez", 40);
            carrera += a6;
            Perros a7 = new Perros(Perros.Razas.OvejeroAleman, 50);
            carrera += a7;
        }

        private void btnMostrarSalida_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = Carrera.MostrarCarrera(this.carrera);
        }
    }
}
