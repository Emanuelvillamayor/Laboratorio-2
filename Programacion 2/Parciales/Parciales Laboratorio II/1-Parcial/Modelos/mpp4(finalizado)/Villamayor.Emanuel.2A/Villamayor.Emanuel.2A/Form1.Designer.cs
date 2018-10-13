namespace Villamayor.Emanuel._2A
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPruebaClases = new System.Windows.Forms.Button();
            this.btnMostrarSalida = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPruebaClases
            // 
            this.btnPruebaClases.Location = new System.Drawing.Point(47, 38);
            this.btnPruebaClases.Name = "btnPruebaClases";
            this.btnPruebaClases.Size = new System.Drawing.Size(377, 63);
            this.btnPruebaClases.TabIndex = 0;
            this.btnPruebaClases.Text = "Prueba Clase";
            this.btnPruebaClases.UseVisualStyleBackColor = true;
            this.btnPruebaClases.Click += new System.EventHandler(this.btnPruebaClases_Click);
            // 
            // btnMostrarSalida
            // 
            this.btnMostrarSalida.Location = new System.Drawing.Point(47, 131);
            this.btnMostrarSalida.Name = "btnMostrarSalida";
            this.btnMostrarSalida.Size = new System.Drawing.Size(377, 58);
            this.btnMostrarSalida.TabIndex = 1;
            this.btnMostrarSalida.Text = "MostrarSalida por Pantalla";
            this.btnMostrarSalida.UseVisualStyleBackColor = true;
            this.btnMostrarSalida.Click += new System.EventHandler(this.btnMostrarSalida_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 195);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(462, 243);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMostrarSalida);
            this.Controls.Add(this.btnPruebaClases);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaClases;
        private System.Windows.Forms.Button btnMostrarSalida;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

