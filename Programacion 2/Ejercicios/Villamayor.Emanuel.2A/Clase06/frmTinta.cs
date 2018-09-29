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
    public partial class frmTinta : Form
    {
        public frmTinta()
        {
            InitializeComponent();

            foreach (ConsoleColor colores in Enum.GetValues(typeof(ConsoleColor))) //incializo las opciones de cbox
            {
                this.cbo1.Items.Add(colores);
            }
            this.cbo1.SelectedItem = ConsoleColor.Cyan; //por default

            this.cbo1.DropDownStyle = ComboBoxStyle.DropDownList;//sirve para que el usuario no escriba ensima



            foreach (ETipoTinta tinta in Enum.GetValues(typeof(ETipoTinta))) //inicializo las opciones de cbo
            {

                this.cbo2.Items.Add(tinta);
            }

            this.cbo2.SelectedItem = ETipoTinta.Comun; //pordefault
            this.cbo2.DropDownStyle = ComboBoxStyle.DropDownList; //sirve para que el usuario no escriba ensima
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmTinta_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // aca dentro va a pasar lo que sucedad si hacemos click
        {
          
               
        }

        private void cbo2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
