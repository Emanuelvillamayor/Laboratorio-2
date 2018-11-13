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
    public partial class frmTestDelegados : Form
    {
        public frmTestDelegados()
        {

            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            //accedo a el atributo que se encuentra en mi form "padre"
            ((frmPrincipal)(this.Owner)).miDel(s);          
           
        }
    }
}
