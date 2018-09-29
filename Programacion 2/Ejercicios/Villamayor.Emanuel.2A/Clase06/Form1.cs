using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase06
{
    public partial class Form1 : Form
    {
       private Clase05.Pluma pluma;
       private Clase05.Tinta tinta;

        public Form1()
        {
            InitializeComponent();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTinta form = new frmTinta();
            form.Show();
        }

        private void plumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
