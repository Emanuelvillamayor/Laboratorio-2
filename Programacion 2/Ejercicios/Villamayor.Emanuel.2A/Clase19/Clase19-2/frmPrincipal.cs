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
    public partial class frmPrincipal : Form
    {
        //creo evento 
        //public event ActualizarNombrePorDelegado miDel;
        public ActualizarNombrePorDelegado miDel;
        frmTestDelegados frmTestDelegados;
        frmDatos frmDatos;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;                    
            this.WindowState = FormWindowState.Maximized;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados = new frmTestDelegados();
            this.frmTestDelegados.Show(this);   //owner       

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDatos = new frmDatos();
            this.frmDatos.Show(this);//owner
            this.miDel += frmDatos.ActualizarNombre;
            this.miDel.Invoke("probando probando\n");
        }
    }
}
