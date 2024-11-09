namespace Simulacro
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblContinente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstBxOpciones = new System.Windows.Forms.ListBox();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.lstBxContinente = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(112, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 32);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(112, 116);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(118, 32);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblContinente
            // 
            this.lblContinente.AutoSize = true;
            this.lblContinente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinente.Location = new System.Drawing.Point(440, 116);
            this.lblContinente.Name = "lblContinente";
            this.lblContinente.Size = new System.Drawing.Size(153, 32);
            this.lblContinente.TabIndex = 3;
            this.lblContinente.Text = "Continente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(446, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // lstBxOpciones
            // 
            this.lstBxOpciones.FormattingEnabled = true;
            this.lstBxOpciones.ItemHeight = 16;
            this.lstBxOpciones.Location = new System.Drawing.Point(110, 203);
            this.lstBxOpciones.Name = "lstBxOpciones";
            this.lstBxOpciones.Size = new System.Drawing.Size(184, 84);
            this.lstBxOpciones.TabIndex = 7;
            this.lstBxOpciones.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(391, 302);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(312, 136);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto.TabIndex = 9;
            this.Foto.TabStop = false;
            this.Foto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lstBxContinente
            // 
            this.lstBxContinente.FormattingEnabled = true;
            this.lstBxContinente.ItemHeight = 16;
            this.lstBxContinente.Location = new System.Drawing.Point(446, 203);
            this.lstBxContinente.Name = "lstBxContinente";
            this.lstBxContinente.Size = new System.Drawing.Size(184, 84);
            this.lstBxContinente.TabIndex = 10;
            this.lstBxContinente.SelectedIndexChanged += new System.EventHandler(this.lstBxContinente_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(118, 319);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(135, 23);
            this.btn.TabIndex = 11;
            this.btn.Text = "Pulsa Aquí";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lstBxContinente);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.lstBxOpciones);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblContinente);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblContinente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstBxOpciones;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.ListBox lstBxContinente;
        private System.Windows.Forms.Button btn;
    }
}

