namespace PrototipoAsignacion
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
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Lbl_contraseña = new System.Windows.Forms.Label();
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.Bnt_ingresar = new System.Windows.Forms.Button();
            this.Bnt_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Location = new System.Drawing.Point(64, 62);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(56, 13);
            this.Lbl_usuario.TabIndex = 0;
            this.Lbl_usuario.Text = "USUARIO";
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(151, 55);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.Txt_usuario.TabIndex = 1;
            // 
            // Lbl_contraseña
            // 
            this.Lbl_contraseña.AutoSize = true;
            this.Lbl_contraseña.Location = new System.Drawing.Point(48, 130);
            this.Lbl_contraseña.Name = "Lbl_contraseña";
            this.Lbl_contraseña.Size = new System.Drawing.Size(81, 13);
            this.Lbl_contraseña.TabIndex = 2;
            this.Lbl_contraseña.Text = "CONTRASEÑA";
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.Location = new System.Drawing.Point(151, 122);
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.Size = new System.Drawing.Size(100, 20);
            this.Txt_contraseña.TabIndex = 3;
            // 
            // Bnt_ingresar
            // 
            this.Bnt_ingresar.Location = new System.Drawing.Point(201, 207);
            this.Bnt_ingresar.Name = "Bnt_ingresar";
            this.Bnt_ingresar.Size = new System.Drawing.Size(75, 23);
            this.Bnt_ingresar.TabIndex = 4;
            this.Bnt_ingresar.Text = "INGRESAR";
            this.Bnt_ingresar.UseVisualStyleBackColor = true;
            this.Bnt_ingresar.Click += new System.EventHandler(this.Bnt_ingresar_Click);
            // 
            // Bnt_salir
            // 
            this.Bnt_salir.Location = new System.Drawing.Point(80, 207);
            this.Bnt_salir.Name = "Bnt_salir";
            this.Bnt_salir.Size = new System.Drawing.Size(75, 23);
            this.Bnt_salir.TabIndex = 5;
            this.Bnt_salir.Text = "SALIR";
            this.Bnt_salir.UseVisualStyleBackColor = true;
            this.Bnt_salir.Click += new System.EventHandler(this.Bnt_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(343, 286);
            this.Controls.Add(this.Bnt_salir);
            this.Controls.Add(this.Bnt_ingresar);
            this.Controls.Add(this.Txt_contraseña);
            this.Controls.Add(this.Lbl_contraseña);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Lbl_usuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.Label Lbl_contraseña;
        private System.Windows.Forms.TextBox Txt_contraseña;
        private System.Windows.Forms.Button Bnt_ingresar;
        private System.Windows.Forms.Button Bnt_salir;
    }
}

