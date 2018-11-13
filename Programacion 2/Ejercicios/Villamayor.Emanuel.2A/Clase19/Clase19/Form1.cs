using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Mostrar por msj box el nombre del control que invoco a ese metodo
        //Lo unicos elementos que van a poder invocarlo van a ser controles por lo tanto hay que castear
        //Es un metodo que cumple cona la firma de un delegado
        public void MiManejadorClick(object obj,EventArgs e )
        {
            MessageBox.Show(((Control)obj).Name);
        }


        //Va a quitar el manejador de evento de button2
        public void MiOtroManejadorClick(object obj, EventArgs e)
        {
            this.button2.Click -= new EventHandler(MiManejadorClick);
            this.button1.Click += new EventHandler(MiManejadorClick); //ahora se va agregarla cantidad de veces que toquemos en el form
        }

        //cambiar el color de fondo del control que recibe como parametro
        public void CambiarFondo(object obj , EventArgs e)
        {
            ((Control)obj).BackColor = Color.Chocolate;
        }


        //Asociar de manera dinamica el evento lick de button 1 a MiManejadorClick y apartir de ahi mostrar en name del obj que invoca
        //Para eso vamos a asociar un delegado que me sirva entre el evento que se genera , me tengo que ajustar a esa firma
        private void Form1_Load(object sender, EventArgs e)
        {

            // this.button1.Click += new EventHandler(this.MiManejadorClick);
            // this.button2.Click += new EventHandler(this.MiManejadorClick);
            // this.textBox1.Click += new EventHandler(this.MiManejadorClick);

            ////cuando hagamos click en el formulario va a borrar el button2 ya que se ejecuta el codigo de MiOtroManejadorClick
            // this.Click += new EventHandler(this.MiOtroManejadorClick);

            // //asociamos CambiarFondo al textbox 
            // this.Click += new EventHandler(this.CambiarFondo);

            this.button1.Click += new EventHandler(this.MiManejadorClick);
            this.button1.Click += new EventHandler(this.ManejadorCentral);
          
        }


        public void ManejadorCentral(object sender , EventArgs e)
        {
           // if(((Control)sender).Name=="button1")
           if(Object.Equals(sender,this.button1))
            {
                this.button1.Click -= new EventHandler(this.MiManejadorClick);
                this.button1.Click -= new EventHandler(this.ManejadorCentral);
                this.button2.Click += new EventHandler(this.ManejadorCentral);
                this.button2.Click += new EventHandler(this.MiManejadorClick);
            }

           // else if (((Control)sender).Name == "button2")
            else if (Object.Equals(sender, this.button2))
            {
                this.button2.Click -= new EventHandler(this.MiManejadorClick);
                this.button2.Click -= new EventHandler(this.ManejadorCentral);
                this.textBox1.Click += new EventHandler(this.ManejadorCentral);
                this.textBox1.Click += new EventHandler(this.MiManejadorClick);
            }

            // else if (((Control)sender).Name == "textBox1")
            else if (Object.Equals(sender, this.textBox1))
            {
                this.textBox1.Click -= new EventHandler(this.MiManejadorClick);
                this.textBox1.Click -= new EventHandler(this.ManejadorCentral);
                this.button1.Click += new EventHandler(this.ManejadorCentral);
                this.button1.Click += new EventHandler(this.MiManejadorClick);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button1.Click -= new EventHandler(MiManejadorClick);
            this.button2.Click -= new EventHandler(MiManejadorClick);
            this.textBox1.Click -= new EventHandler(MiManejadorClick);
            this.Click -= new EventHandler(CambiarFondo);
            this.Click -= new EventHandler(MiOtroManejadorClick);
        }
    }
}
