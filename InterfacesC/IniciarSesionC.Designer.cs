namespace TiendaExaFinalS2.InterfacesC
{
    partial class IniciarSesionC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelInicioSesion = new Label();
            UsuarioIngreso = new TextBox();
            labelIniciaSesionParaContinuar = new Label();
            labelUsuario = new Label();
            ContraseñaIngreso = new Label();
            textBoxContraI = new TextBox();
            OlvideContraseña = new Button();
            button1 = new Button();
            panelImagenLogo = new Panel();
            SuspendLayout();
            // 
            // LabelInicioSesion
            // 
            LabelInicioSesion.AutoSize = true;
            LabelInicioSesion.FlatStyle = FlatStyle.Flat;
            LabelInicioSesion.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelInicioSesion.ForeColor = Color.White;
            LabelInicioSesion.Location = new Point(240, 135);
            LabelInicioSesion.Name = "LabelInicioSesion";
            LabelInicioSesion.Size = new Size(206, 31);
            LabelInicioSesion.TabIndex = 0;
            LabelInicioSesion.Text = "Inicia Sesión";
            LabelInicioSesion.TextAlign = ContentAlignment.MiddleCenter;
            LabelInicioSesion.Click += label1_Click;
            // 
            // UsuarioIngreso
            // 
            UsuarioIngreso.BackColor = Color.Black;
            UsuarioIngreso.ForeColor = Color.White;
            UsuarioIngreso.Location = new Point(240, 243);
            UsuarioIngreso.Name = "UsuarioIngreso";
            UsuarioIngreso.Size = new Size(206, 23);
            UsuarioIngreso.TabIndex = 1;
            UsuarioIngreso.TextAlign = HorizontalAlignment.Center;
            UsuarioIngreso.TextChanged += textBox1_TextChanged_1;
            // 
            // labelIniciaSesionParaContinuar
            // 
            labelIniciaSesionParaContinuar.AutoSize = true;
            labelIniciaSesionParaContinuar.FlatStyle = FlatStyle.Flat;
            labelIniciaSesionParaContinuar.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIniciaSesionParaContinuar.ForeColor = Color.White;
            labelIniciaSesionParaContinuar.Location = new Point(224, 166);
            labelIniciaSesionParaContinuar.Margin = new Padding(0);
            labelIniciaSesionParaContinuar.Name = "labelIniciaSesionParaContinuar";
            labelIniciaSesionParaContinuar.Size = new Size(234, 16);
            labelIniciaSesionParaContinuar.TabIndex = 2;
            labelIniciaSesionParaContinuar.Text = "Inicia Sesión Para Continuar";
            labelIniciaSesionParaContinuar.TextAlign = ContentAlignment.MiddleCenter;
            labelIniciaSesionParaContinuar.Click += label1_Click_1;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.FlatStyle = FlatStyle.Flat;
            labelUsuario.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(240, 224);
            labelUsuario.Margin = new Padding(0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(69, 16);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario";
            labelUsuario.TextAlign = ContentAlignment.MiddleCenter;
            labelUsuario.Click += labelUsuario_Click;
            // 
            // ContraseñaIngreso
            // 
            ContraseñaIngreso.AutoSize = true;
            ContraseñaIngreso.FlatStyle = FlatStyle.Flat;
            ContraseñaIngreso.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContraseñaIngreso.ForeColor = Color.White;
            ContraseñaIngreso.Location = new Point(240, 290);
            ContraseñaIngreso.Margin = new Padding(0);
            ContraseñaIngreso.Name = "ContraseñaIngreso";
            ContraseñaIngreso.Size = new Size(99, 16);
            ContraseñaIngreso.TabIndex = 5;
            ContraseñaIngreso.Text = "Contraseña";
            ContraseñaIngreso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxContraI
            // 
            textBoxContraI.BackColor = Color.Black;
            textBoxContraI.ForeColor = Color.White;
            textBoxContraI.Location = new Point(240, 309);
            textBoxContraI.Name = "textBoxContraI";
            textBoxContraI.Size = new Size(206, 23);
            textBoxContraI.TabIndex = 4;
            textBoxContraI.TextAlign = HorizontalAlignment.Center;
            // 
            // OlvideContraseña
            // 
            OlvideContraseña.BackColor = Color.Black;
            OlvideContraseña.FlatAppearance.BorderSize = 0;
            OlvideContraseña.FlatAppearance.MouseDownBackColor = Color.Blue;
            OlvideContraseña.FlatAppearance.MouseOverBackColor = Color.Red;
            OlvideContraseña.FlatStyle = FlatStyle.Flat;
            OlvideContraseña.ForeColor = Color.White;
            OlvideContraseña.Location = new Point(0, 499);
            OlvideContraseña.Name = "OlvideContraseña";
            OlvideContraseña.Size = new Size(141, 23);
            OlvideContraseña.TabIndex = 7;
            OlvideContraseña.Text = "Olvide Mi Contraseña :(";
            OlvideContraseña.UseVisualStyleBackColor = false;
            OlvideContraseña.Click += OlvideContraseña_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Blue;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(240, 338);
            button1.Name = "button1";
            button1.Size = new Size(206, 23);
            button1.TabIndex = 8;
            button1.Text = "Iniciar Sesion Cliente";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelImagenLogo
            // 
            panelImagenLogo.BackgroundImage = Properties.Resources.LogoEmpresa;
            panelImagenLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelImagenLogo.Location = new Point(242, 12);
            panelImagenLogo.Name = "panelImagenLogo";
            panelImagenLogo.Size = new Size(206, 100);
            panelImagenLogo.TabIndex = 37;
            // 
            // IniciarSesionC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(668, 522);
            Controls.Add(panelImagenLogo);
            Controls.Add(button1);
            Controls.Add(OlvideContraseña);
            Controls.Add(ContraseñaIngreso);
            Controls.Add(textBoxContraI);
            Controls.Add(labelUsuario);
            Controls.Add(labelIniciaSesionParaContinuar);
            Controls.Add(UsuarioIngreso);
            Controls.Add(LabelInicioSesion);
            MinimumSize = new Size(684, 561);
            Name = "IniciarSesionC";
            Text = "IniciarSesionC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelInicioSesion;
        private TextBox UsuarioIngreso;
        private Label labelIniciaSesionParaContinuar;
        private Label labelUsuario;
        private Label ContraseñaIngreso;
        private TextBox textBoxContraI;
        private Button OlvideContraseña;
        private Button button1;
        private Panel panelImagenLogo;
    }
}