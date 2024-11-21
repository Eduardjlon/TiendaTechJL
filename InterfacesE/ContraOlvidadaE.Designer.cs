namespace TiendaExaFinalS2.InterfacesE
{
    partial class ContraOlvidadaE
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
            LabelNoDPI = new Label();
            textBoxNoDPI = new TextBox();
            labelUsuario = new Label();
            labelSigueLosSiguientesPasos = new Label();
            UsuarioIngreso = new TextBox();
            LabelRecuperandoContraseña = new Label();
            labelCargo = new Label();
            textBoxFechaDeNacimiento = new TextBox();
            VerificarDatosContra = new Button();
            SuspendLayout();
            // 
            // LabelNoDPI
            // 
            LabelNoDPI.AutoSize = true;
            LabelNoDPI.FlatStyle = FlatStyle.Flat;
            LabelNoDPI.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelNoDPI.ForeColor = Color.White;
            LabelNoDPI.Location = new Point(226, 327);
            LabelNoDPI.Margin = new Padding(0);
            LabelNoDPI.Name = "LabelNoDPI";
            LabelNoDPI.Size = new Size(59, 16);
            LabelNoDPI.TabIndex = 11;
            LabelNoDPI.Text = "No. DPI";
            LabelNoDPI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNoDPI
            // 
            textBoxNoDPI.BackColor = Color.Black;
            textBoxNoDPI.ForeColor = Color.White;
            textBoxNoDPI.Location = new Point(226, 346);
            textBoxNoDPI.Name = "textBoxNoDPI";
            textBoxNoDPI.Size = new Size(213, 23);
            textBoxNoDPI.TabIndex = 10;
            textBoxNoDPI.TextAlign = HorizontalAlignment.Center;
            textBoxNoDPI.TextChanged += textBoxContraI_TextChanged;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.FlatStyle = FlatStyle.Flat;
            labelUsuario.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(226, 206);
            labelUsuario.Margin = new Padding(0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(69, 16);
            labelUsuario.TabIndex = 9;
            labelUsuario.Text = "Usuario";
            labelUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSigueLosSiguientesPasos
            // 
            labelSigueLosSiguientesPasos.AutoSize = true;
            labelSigueLosSiguientesPasos.FlatStyle = FlatStyle.Flat;
            labelSigueLosSiguientesPasos.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSigueLosSiguientesPasos.ForeColor = Color.White;
            labelSigueLosSiguientesPasos.Location = new Point(226, 155);
            labelSigueLosSiguientesPasos.Margin = new Padding(0);
            labelSigueLosSiguientesPasos.Name = "labelSigueLosSiguientesPasos";
            labelSigueLosSiguientesPasos.Size = new Size(213, 16);
            labelSigueLosSiguientesPasos.TabIndex = 8;
            labelSigueLosSiguientesPasos.Text = "Sigue Los Siguientes Pasos";
            labelSigueLosSiguientesPasos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsuarioIngreso
            // 
            UsuarioIngreso.BackColor = Color.Black;
            UsuarioIngreso.ForeColor = Color.White;
            UsuarioIngreso.Location = new Point(226, 225);
            UsuarioIngreso.Name = "UsuarioIngreso";
            UsuarioIngreso.Size = new Size(213, 23);
            UsuarioIngreso.TabIndex = 7;
            UsuarioIngreso.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelRecuperandoContraseña
            // 
            LabelRecuperandoContraseña.AutoSize = true;
            LabelRecuperandoContraseña.FlatStyle = FlatStyle.Flat;
            LabelRecuperandoContraseña.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRecuperandoContraseña.ForeColor = Color.White;
            LabelRecuperandoContraseña.Location = new Point(142, 124);
            LabelRecuperandoContraseña.Name = "LabelRecuperandoContraseña";
            LabelRecuperandoContraseña.Size = new Size(399, 31);
            LabelRecuperandoContraseña.TabIndex = 6;
            LabelRecuperandoContraseña.Text = "Recuperarando Contraseña";
            LabelRecuperandoContraseña.TextAlign = ContentAlignment.MiddleCenter;
            LabelRecuperandoContraseña.Click += LabelInicioSesion_Click;
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.FlatStyle = FlatStyle.Flat;
            labelCargo.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCargo.ForeColor = Color.White;
            labelCargo.Location = new Point(226, 266);
            labelCargo.Margin = new Padding(0);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(53, 16);
            labelCargo.TabIndex = 13;
            labelCargo.Text = "Cargo";
            labelCargo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxFechaDeNacimiento
            // 
            textBoxFechaDeNacimiento.BackColor = Color.Black;
            textBoxFechaDeNacimiento.ForeColor = Color.White;
            textBoxFechaDeNacimiento.Location = new Point(226, 285);
            textBoxFechaDeNacimiento.Name = "textBoxFechaDeNacimiento";
            textBoxFechaDeNacimiento.Size = new Size(213, 23);
            textBoxFechaDeNacimiento.TabIndex = 12;
            textBoxFechaDeNacimiento.TextAlign = HorizontalAlignment.Center;
            // 
            // VerificarDatosContra
            // 
            VerificarDatosContra.Cursor = Cursors.AppStarting;
            VerificarDatosContra.FlatAppearance.BorderSize = 0;
            VerificarDatosContra.FlatAppearance.MouseDownBackColor = Color.Blue;
            VerificarDatosContra.FlatAppearance.MouseOverBackColor = Color.Red;
            VerificarDatosContra.FlatStyle = FlatStyle.Flat;
            VerificarDatosContra.ForeColor = Color.White;
            VerificarDatosContra.Location = new Point(226, 395);
            VerificarDatosContra.Name = "VerificarDatosContra";
            VerificarDatosContra.Size = new Size(213, 23);
            VerificarDatosContra.TabIndex = 14;
            VerificarDatosContra.Text = "Verificar";
            VerificarDatosContra.UseVisualStyleBackColor = true;
            // 
            // ContraOlvidadaE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(668, 522);
            Controls.Add(VerificarDatosContra);
            Controls.Add(labelCargo);
            Controls.Add(textBoxFechaDeNacimiento);
            Controls.Add(LabelNoDPI);
            Controls.Add(textBoxNoDPI);
            Controls.Add(labelUsuario);
            Controls.Add(labelSigueLosSiguientesPasos);
            Controls.Add(UsuarioIngreso);
            Controls.Add(LabelRecuperandoContraseña);
            MinimumSize = new Size(684, 561);
            Name = "ContraOlvidadaE";
            Text = "Olvide Mi Contraseña";
            Load += ContraOlvidadaE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNoDPI;
        private TextBox textBoxNoDPI;
        private Label labelUsuario;
        private Label labelSigueLosSiguientesPasos;
        private TextBox UsuarioIngreso;
        private Label LabelRecuperandoContraseña;
        private Label labelCargo;
        private TextBox textBoxFechaDeNacimiento;
        private Button VerificarDatosContra;
    }
}