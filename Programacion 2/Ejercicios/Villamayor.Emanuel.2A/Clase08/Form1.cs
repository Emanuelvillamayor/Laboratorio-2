using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using EntidadesClase07; //REFERENCIA DE CLASE 08

namespace Clase08
{
    public partial class Form1 : Form
    {
        //groupbox contenedeor de otros controles y tiene titulo
        //texbox y los dos botones meterlos en el groupbox y que quede casi ocupando todo el gb
        PaletaColleccion _miPaleta;
        

        public Form1()
        {
            InitializeComponent();
            this. _miPaleta = 5;
            this.gb1.Text = "Paleta de Colores";
            this.txb1.Multiline = true; //permite abritlo mas paraque sea un cuadrado
            this.btn1.Text = "+";
            this.btn2.Text = "-";          
        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gb1.Visible = true;
            this.agregarPaletaToolStripMenuItem.Enabled = false; //la deja inavitilada la opcion para que no se vuelva a ejecutar
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            FrmTempera temp = new FrmTempera();
            DialogResult rta = temp.ShowDialog();
            if(rta==DialogResult.OK)
            {
                this._miPaleta += temp.MiTempera;
                this.txb1.Text = (string)_miPaleta;
            }         
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string seleccionado = "";
            string []todoText = txb1.Lines;
            int i = 0;
            int indice=-1;
            seleccionado = this.txb1.SelectedText;
                     

            foreach(string item in todoText)
             {
                if(item==seleccionado)
                {
                   indice = i;
                   break;                  
                }
                i++;
            }
            seleccionado += " "+ indice.ToString();
            MessageBox.Show(seleccionado);

           
            FrmTempera frmtemp = new FrmTempera(_miPaleta[indice]);  //utilizo la propiedad del INDEXADOR
            DialogResult rta = frmtemp.ShowDialog();
            if(rta==DialogResult.OK)
            {
                this._miPaleta -= frmtemp.MiTempera;
                this.txb1.Text = (string)_miPaleta;
            }


        }

        //boton menos , cual de todos los elementos quiere seleccionar el usuario y borrarlo para saber cual 
        //es la tempera y despues borrarla o eliminar cantidades
    }
}
