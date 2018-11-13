using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio68
{
    public partial class Form1 : Form
    {
        private Persona p;
        private event DelegadoString evento;
        string nombre;
        string apellido;

        public Form1()
        {
            InitializeComponent();
            nombre = "";
            apellido = "";

        }

        public static void NotificarCambio(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
  
            
            if (p==null)
            {
                p = new Persona(textBox1.Text,textBox2.Text);
                nombre = textBox1.Text;
                apellido = textBox2.Text;
                btnCrear.Text = "Actualizar";
                NotificarCambio(string.Format("Se ha creado la persona "+p.Mostrar()));
            }
            else
            {
                if(nombre==textBox1.Text && apellido==textBox2.Text)
                {
                    NotificarCambio(string.Format("No se ha modificado el nombre ni el apellido" + p.Mostrar()));
                }
                else if(nombre == textBox1.Text && apellido != textBox2.Text)
                {
                    apellido = textBox2.Text;
                    p.Apellido = textBox2.Text; ;
                    NotificarCambio(string.Format("Se ha modificado solo el apellido " + p.Mostrar()));
            
                }
                else if (nombre != textBox1.Text && apellido == textBox2.Text)
                {
                    nombre = textBox1.Text;
                    p.Nombre = textBox1.Text;
                    NotificarCambio(string.Format("Se ha modificado solo el nombre " + p.Mostrar()));
                 
                }
                else
                {
                    nombre = textBox1.Text;
                    apellido = textBox2.Text;
                    p.Nombre = textBox1.Text;
                    p.Apellido = textBox2.Text;
                    NotificarCambio(string.Format("Se ha modificado  el nombre y el apellido " + p.Mostrar()));
                  
                }
            }
                  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            evento += new DelegadoString(Form1.NotificarCambio);
        }
    }
}
