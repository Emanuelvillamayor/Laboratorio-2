using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ejercicio23.Forms
{
    public partial class Form1 : Form
    {
        Pesos peso;
        Dolar dolar;
        Euro euro;
       
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnConverEuro_Click(object sender, EventArgs e)
        {
            euro = new Euro(Convert.ToDouble(this.txtEuro.Text));
            this.txtEuroAEuro.Text = euro.GetCantidad().ToString();

            peso = new Pesos(1);
            peso = (Pesos) euro;
            this.txtEuroAPesos.Text = peso.GetCantidad().ToString();

            dolar = new Dolar(1);
            dolar = (Dolar)euro;
            this.txtEuroADolar.Text = dolar.GetCantidad().ToString();
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            dolar = new Dolar(Convert.ToDouble(this.txtDolar.Text));
            this.txtDolarADolar.Text = dolar.GetCantidad().ToString();

            peso = new Pesos(1);
            peso = (Pesos)dolar;
            this.txtDolarAPesos.Text = peso.GetCantidad().ToString();

            euro = new Euro(1);
            euro = (Euro)dolar;
            this.txtDolarAEuro.Text = euro.GetCantidad().ToString();
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            peso = new Pesos(Convert.ToDouble(this.txtPesos.Text));
            this.txtPesosAPesos.Text = peso.GetCantidad().ToString();

            dolar = new Dolar(1);
            dolar = (Dolar)peso;
            this.txtPesosADolar.Text = dolar.GetCantidad().ToString();

            euro = new Euro(1);
            euro = (Euro)peso;
            this.txtPesosAEuro.Text = euro.GetCantidad().ToString();
        }
    }
}
