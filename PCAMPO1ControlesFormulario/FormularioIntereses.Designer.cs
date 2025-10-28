namespace PCAMPO1ControlesFormulario
{
    partial class FormularioIntereses
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
            this.chkMusica = new System.Windows.Forms.CheckBox();
            this.chkDeporte = new System.Windows.Forms.CheckBox();
            this.chkLectura = new System.Windows.Forms.CheckBox();
            this.chkCine = new System.Windows.Forms.CheckBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkMusica
            // 
            this.chkMusica.AutoSize = true;
            this.chkMusica.Location = new System.Drawing.Point(63, 32);
            this.chkMusica.Name = "chkMusica";
            this.chkMusica.Size = new System.Drawing.Size(60, 17);
            this.chkMusica.TabIndex = 0;
            this.chkMusica.Text = "Música";
            this.chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkDeporte
            // 
            this.chkDeporte.AutoSize = true;
            this.chkDeporte.Location = new System.Drawing.Point(63, 55);
            this.chkDeporte.Name = "chkDeporte";
            this.chkDeporte.Size = new System.Drawing.Size(64, 17);
            this.chkDeporte.TabIndex = 1;
            this.chkDeporte.Text = "Deporte";
            this.chkDeporte.UseVisualStyleBackColor = true;
            this.chkDeporte.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkLectura
            // 
            this.chkLectura.AutoSize = true;
            this.chkLectura.Location = new System.Drawing.Point(63, 78);
            this.chkLectura.Name = "chkLectura";
            this.chkLectura.Size = new System.Drawing.Size(62, 17);
            this.chkLectura.TabIndex = 2;
            this.chkLectura.Text = "Lectura";
            this.chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkCine
            // 
            this.chkCine.AutoSize = true;
            this.chkCine.Location = new System.Drawing.Point(63, 101);
            this.chkCine.Name = "chkCine";
            this.chkCine.Size = new System.Drawing.Size(47, 17);
            this.chkCine.TabIndex = 3;
            this.chkCine.Text = "Cine";
            this.chkCine.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(155, 51);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(122, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar intereses";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblIntereses
            // 
            this.lblIntereses.AutoSize = true;
            this.lblIntereses.Location = new System.Drawing.Point(60, 154);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(0, 13);
            this.lblIntereses.TabIndex = 5;
            // 
            // FormularioIntereses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 325);
            this.Controls.Add(this.lblIntereses);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chkCine);
            this.Controls.Add(this.chkLectura);
            this.Controls.Add(this.chkDeporte);
            this.Controls.Add(this.chkMusica);
            this.Name = "FormularioIntereses";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMusica;
        private System.Windows.Forms.CheckBox chkDeporte;
        private System.Windows.Forms.CheckBox chkLectura;
        private System.Windows.Forms.CheckBox chkCine;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblIntereses;
    }
}

