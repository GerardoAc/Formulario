namespace Formulario
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.UsarioLabel = new System.Windows.Forms.Label();
            this.ContraseñaLabel = new System.Windows.Forms.Label();
            this.UsuarioTxt = new System.Windows.Forms.TextBox();
            this.ContraseñaTxt = new System.Windows.Forms.TextBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.OlvidarContraseLabel = new System.Windows.Forms.LinkLabel();
            this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UsarioLabel
            // 
            this.UsarioLabel.AutoSize = true;
            this.UsarioLabel.Location = new System.Drawing.Point(63, 74);
            this.UsarioLabel.Name = "UsarioLabel";
            this.UsarioLabel.Size = new System.Drawing.Size(40, 13);
            this.UsarioLabel.TabIndex = 0;
            this.UsarioLabel.Text = "Usario:";
            // 
            // ContraseñaLabel
            // 
            this.ContraseñaLabel.AutoSize = true;
            this.ContraseñaLabel.Location = new System.Drawing.Point(63, 109);
            this.ContraseñaLabel.Name = "ContraseñaLabel";
            this.ContraseñaLabel.Size = new System.Drawing.Size(61, 13);
            this.ContraseñaLabel.TabIndex = 1;
            this.ContraseñaLabel.Text = "Contraseña";
            // 
            // UsuarioTxt
            // 
            this.UsuarioTxt.Location = new System.Drawing.Point(175, 76);
            this.UsuarioTxt.Name = "UsuarioTxt";
            this.UsuarioTxt.Size = new System.Drawing.Size(285, 20);
            this.UsuarioTxt.TabIndex = 2;
            // 
            // ContraseñaTxt
            // 
            this.ContraseñaTxt.Location = new System.Drawing.Point(175, 102);
            this.ContraseñaTxt.Name = "ContraseñaTxt";
            this.ContraseñaTxt.Size = new System.Drawing.Size(285, 20);
            this.ContraseñaTxt.TabIndex = 3;
            this.ContraseñaTxt.UseSystemPasswordChar = true;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(66, 178);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 4;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(385, 178);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 5;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // OlvidarContraseLabel
            // 
            this.OlvidarContraseLabel.AutoSize = true;
            this.OlvidarContraseLabel.Location = new System.Drawing.Point(341, 149);
            this.OlvidarContraseLabel.Name = "OlvidarContraseLabel";
            this.OlvidarContraseLabel.Size = new System.Drawing.Size(119, 13);
            this.OlvidarContraseLabel.TabIndex = 6;
            this.OlvidarContraseLabel.TabStop = true;
            this.OlvidarContraseLabel.Text = "¿Olvido su contraseña?";
            // 
            // LoginErrorProvider
            // 
            this.LoginErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.AceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(560, 213);
            this.Controls.Add(this.OlvidarContraseLabel);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.ContraseñaTxt);
            this.Controls.Add(this.UsuarioTxt);
            this.Controls.Add(this.ContraseñaLabel);
            this.Controls.Add(this.UsarioLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "Bienvenido al sistema";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsarioLabel;
        private System.Windows.Forms.Label ContraseñaLabel;
        private System.Windows.Forms.TextBox UsuarioTxt;
        private System.Windows.Forms.TextBox ContraseñaTxt;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.LinkLabel OlvidarContraseLabel;
        private System.Windows.Forms.ErrorProvider LoginErrorProvider;
    }
}

