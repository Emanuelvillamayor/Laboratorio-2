using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesClase07;
namespace Clase08
{
    public partial class FrmTempera : Form
    {
        private Tempera _mitempera;

        //permtite retornar en otro lado el valor cargado en _mitempera
        public Tempera MiTempera {
            get { return this._mitempera; }
                }

        public FrmTempera()
        {
            InitializeComponent();

            this.lblCantidad.Text = "Cantidad";
            this.lblColor.Text = "Color";
            this.lblMarca.Text = "Marca";

            this.btnAceptar.Text = "Aceptar";
            this.btnCancelar.Text = "Cancelar";


            foreach(ConsoleColor item in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cbxColor.Items.Add(item);
            }
            this.cbxColor.SelectedItem = ConsoleColor.Cyan;
            this.cbxColor.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //esto permite guardar los datos que le pasamos dentro de la variable _mitempera
            _mitempera = new Tempera(sbyte.Parse(this.tbxCantidad.Text),(ConsoleColor) this.cbxColor.SelectedItem, this.tbxMarca.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //SOBRECARAGA RECIBE TEMPERA
        public FrmTempera(Tempera temp) : this()
        {
            _mitempera = temp;
            this.cbxColor.SelectedItem = temp.GetColor;
            this.tbxCantidad.Text = ""+(sbyte)temp;
            this.tbxMarca.Text = temp.GetMarca;
        }
    
        
      
    }
}
