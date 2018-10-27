namespace TestEjercicio40_Form
{
    partial class FrmMostrar
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
            this.btnGenLlamada = new System.Windows.Forms.Button();
            this.btnFacTotal = new System.Windows.Forms.Button();
            this.btnFacLocal = new System.Windows.Forms.Button();
            this.btnFacProv = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenLlamada
            // 
            this.btnGenLlamada.Location = new System.Drawing.Point(12, 12);
            this.btnGenLlamada.Name = "btnGenLlamada";
            this.btnGenLlamada.Size = new System.Drawing.Size(363, 65);
            this.btnGenLlamada.TabIndex = 0;
            this.btnGenLlamada.Text = "GenerarLlamada";
            this.btnGenLlamada.UseVisualStyleBackColor = true;
            // 
            // btnFacTotal
            // 
            this.btnFacTotal.Location = new System.Drawing.Point(12, 83);
            this.btnFacTotal.Name = "btnFacTotal";
            this.btnFacTotal.Size = new System.Drawing.Size(363, 57);
            this.btnFacTotal.TabIndex = 1;
            this.btnFacTotal.Text = "Facturacion Total";
            this.btnFacTotal.UseVisualStyleBackColor = true;
            // 
            // btnFacLocal
            // 
            this.btnFacLocal.Location = new System.Drawing.Point(12, 146);
            this.btnFacLocal.Name = "btnFacLocal";
            this.btnFacLocal.Size = new System.Drawing.Size(363, 51);
            this.btnFacLocal.TabIndex = 2;
            this.btnFacLocal.Text = "Facturacion Local";
            this.btnFacLocal.UseVisualStyleBackColor = true;
            // 
            // btnFacProv
            // 
            this.btnFacProv.Location = new System.Drawing.Point(12, 203);
            this.btnFacProv.Name = "btnFacProv";
            this.btnFacProv.Size = new System.Drawing.Size(363, 61);
            this.btnFacProv.TabIndex = 3;
            this.btnFacProv.Text = "Facturacion Provincial";
            this.btnFacProv.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 270);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(363, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 341);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacProv);
            this.Controls.Add(this.btnFacLocal);
            this.Controls.Add(this.btnFacTotal);
            this.Controls.Add(this.btnGenLlamada);
            this.Name = "Form1";
            this.Text = "CentralTelefonica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenLlamada;
        private System.Windows.Forms.Button btnFacTotal;
        private System.Windows.Forms.Button btnFacLocal;
        private System.Windows.Forms.Button btnFacProv;
        private System.Windows.Forms.Button btnSalir;
    }
}

