namespace Ejercicio23.Forms
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
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.btnConverEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.txtPesosAEuro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(8, 29);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(8, 80);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(8, 146);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(36, 13);
            this.lblPesos.TabIndex = 2;
            this.lblPesos.Text = "Pesos";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(124, 26);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 3;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(124, 80);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 4;
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(124, 139);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 5;
            // 
            // btnConverEuro
            // 
            this.btnConverEuro.Location = new System.Drawing.Point(271, 23);
            this.btnConverEuro.Name = "btnConverEuro";
            this.btnConverEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConverEuro.TabIndex = 6;
            this.btnConverEuro.Text = "->";
            this.btnConverEuro.UseVisualStyleBackColor = true;
            this.btnConverEuro.Click += new System.EventHandler(this.btnConverEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(271, 77);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 7;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Location = new System.Drawing.Point(271, 136);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPesos.TabIndex = 8;
            this.btnConvertPesos.Text = "->";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            this.btnConvertPesos.Click += new System.EventHandler(this.btnConvertPesos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pesos";
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(377, 26);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.ReadOnly = true;
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAEuro.TabIndex = 15;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(508, 25);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.ReadOnly = true;
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroADolar.TabIndex = 16;
            // 
            // txtEuroAPesos
            // 
            this.txtEuroAPesos.Location = new System.Drawing.Point(640, 25);
            this.txtEuroAPesos.Name = "txtEuroAPesos";
            this.txtEuroAPesos.ReadOnly = true;
            this.txtEuroAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAPesos.TabIndex = 17;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(377, 80);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.ReadOnly = true;
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAEuro.TabIndex = 18;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(508, 80);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.ReadOnly = true;
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarADolar.TabIndex = 19;
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.Location = new System.Drawing.Point(640, 80);
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.ReadOnly = true;
            this.txtDolarAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAPesos.TabIndex = 20;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Location = new System.Drawing.Point(640, 139);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.ReadOnly = true;
            this.txtPesosAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAPesos.TabIndex = 21;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.Location = new System.Drawing.Point(508, 138);
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.ReadOnly = true;
            this.txtPesosADolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesosADolar.TabIndex = 22;
            // 
            // txtPesosAEuro
            // 
            this.txtPesosAEuro.Location = new System.Drawing.Point(377, 138);
            this.txtPesosAEuro.Name = "txtPesosAEuro";
            this.txtPesosAEuro.ReadOnly = true;
            this.txtPesosAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAEuro.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 213);
            this.Controls.Add(this.txtPesosAEuro);
            this.Controls.Add(this.txtPesosADolar);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtDolarAPesos);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAPesos);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertPesos);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConverEuro);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Button btnConverEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPesos;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.TextBox txtPesosAPesos;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.TextBox txtPesosAEuro;
    }
}

