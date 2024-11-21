namespace TiendaExaFinalS2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            panelRedesSociales = new Panel();
            RedesSociales = new Button();
            Sobre = new Button();
            panelMenu2 = new Panel();
            CrearUsuarioC = new Button();
            IniciarSesionC = new Button();
            Cliente = new Button();
            panelSubMenu = new Panel();
            CrearUsuario = new Button();
            IniciarSesion = new Button();
            Estudiante = new Button();
            panelLogo = new Panel();
            panelContenedor = new Panel();
            panelSideMenu.SuspendLayout();
            panelRedesSociales.SuspendLayout();
            panelMenu2.SuspendLayout();
            panelSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelSideMenu.Controls.Add(panelRedesSociales);
            panelSideMenu.Controls.Add(Sobre);
            panelSideMenu.Controls.Add(panelMenu2);
            panelSideMenu.Controls.Add(Cliente);
            panelSideMenu.Controls.Add(panelSubMenu);
            panelSideMenu.Controls.Add(Estudiante);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 561);
            panelSideMenu.TabIndex = 0;
            // 
            // panelRedesSociales
            // 
            panelRedesSociales.BackColor = Color.Black;
            panelRedesSociales.Controls.Add(RedesSociales);
            panelRedesSociales.Dock = DockStyle.Top;
            panelRedesSociales.ForeColor = Color.Black;
            panelRedesSociales.Location = new Point(0, 393);
            panelRedesSociales.Name = "panelRedesSociales";
            panelRedesSociales.Size = new Size(250, 42);
            panelRedesSociales.TabIndex = 6;
            // 
            // RedesSociales
            // 
            RedesSociales.BackColor = Color.Black;
            RedesSociales.Dock = DockStyle.Top;
            RedesSociales.FlatAppearance.BorderSize = 0;
            RedesSociales.FlatAppearance.MouseDownBackColor = Color.Blue;
            RedesSociales.FlatAppearance.MouseOverBackColor = Color.Red;
            RedesSociales.FlatStyle = FlatStyle.Flat;
            RedesSociales.ForeColor = Color.White;
            RedesSociales.Location = new Point(0, 0);
            RedesSociales.Name = "RedesSociales";
            RedesSociales.Padding = new Padding(35, 0, 0, 0);
            RedesSociales.Size = new Size(250, 40);
            RedesSociales.TabIndex = 0;
            RedesSociales.Text = "Redes Sociales";
            RedesSociales.TextAlign = ContentAlignment.MiddleLeft;
            RedesSociales.UseVisualStyleBackColor = false;
            RedesSociales.Click += RedesSociales_Click;
            // 
            // Sobre
            // 
            Sobre.BackColor = Color.FromArgb(64, 0, 0);
            Sobre.Dock = DockStyle.Top;
            Sobre.FlatAppearance.BorderSize = 0;
            Sobre.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            Sobre.FlatAppearance.MouseOverBackColor = Color.Red;
            Sobre.FlatStyle = FlatStyle.Flat;
            Sobre.ForeColor = Color.White;
            Sobre.Location = new Point(0, 353);
            Sobre.Name = "Sobre";
            Sobre.Padding = new Padding(10, 0, 0, 0);
            Sobre.Size = new Size(250, 40);
            Sobre.TabIndex = 5;
            Sobre.Text = "Sobre Nosotros";
            Sobre.TextAlign = ContentAlignment.MiddleLeft;
            Sobre.UseVisualStyleBackColor = false;
            Sobre.Click += Sobre_Click;
            // 
            // panelMenu2
            // 
            panelMenu2.BackColor = Color.Black;
            panelMenu2.Controls.Add(CrearUsuarioC);
            panelMenu2.Controls.Add(IniciarSesionC);
            panelMenu2.Dock = DockStyle.Top;
            panelMenu2.Location = new Point(0, 273);
            panelMenu2.Name = "panelMenu2";
            panelMenu2.Size = new Size(250, 80);
            panelMenu2.TabIndex = 4;
            // 
            // CrearUsuarioC
            // 
            CrearUsuarioC.BackColor = Color.Black;
            CrearUsuarioC.Dock = DockStyle.Top;
            CrearUsuarioC.FlatAppearance.BorderSize = 0;
            CrearUsuarioC.FlatAppearance.MouseDownBackColor = Color.Blue;
            CrearUsuarioC.FlatAppearance.MouseOverBackColor = Color.Red;
            CrearUsuarioC.FlatStyle = FlatStyle.Flat;
            CrearUsuarioC.ForeColor = Color.White;
            CrearUsuarioC.ImageAlign = ContentAlignment.MiddleLeft;
            CrearUsuarioC.Location = new Point(0, 40);
            CrearUsuarioC.Name = "CrearUsuarioC";
            CrearUsuarioC.Padding = new Padding(35, 0, 0, 0);
            CrearUsuarioC.Size = new Size(250, 40);
            CrearUsuarioC.TabIndex = 1;
            CrearUsuarioC.Text = "Crear Usuario";
            CrearUsuarioC.TextAlign = ContentAlignment.MiddleLeft;
            CrearUsuarioC.UseVisualStyleBackColor = false;
            CrearUsuarioC.Click += CrearUsuarioC_Click;
            // 
            // IniciarSesionC
            // 
            IniciarSesionC.Dock = DockStyle.Top;
            IniciarSesionC.FlatAppearance.BorderSize = 0;
            IniciarSesionC.FlatAppearance.MouseDownBackColor = Color.Blue;
            IniciarSesionC.FlatAppearance.MouseOverBackColor = Color.Red;
            IniciarSesionC.FlatStyle = FlatStyle.Flat;
            IniciarSesionC.ForeColor = Color.White;
            IniciarSesionC.Location = new Point(0, 0);
            IniciarSesionC.Name = "IniciarSesionC";
            IniciarSesionC.Padding = new Padding(35, 0, 0, 0);
            IniciarSesionC.Size = new Size(250, 40);
            IniciarSesionC.TabIndex = 0;
            IniciarSesionC.Text = "Iniciar Sesión";
            IniciarSesionC.TextAlign = ContentAlignment.MiddleLeft;
            IniciarSesionC.UseVisualStyleBackColor = true;
            IniciarSesionC.Click += IniciarSesionC_Click;
            // 
            // Cliente
            // 
            Cliente.BackColor = Color.FromArgb(64, 0, 0);
            Cliente.Dock = DockStyle.Top;
            Cliente.FlatAppearance.BorderSize = 0;
            Cliente.FlatAppearance.MouseDownBackColor = Color.Blue;
            Cliente.FlatAppearance.MouseOverBackColor = Color.Red;
            Cliente.FlatStyle = FlatStyle.Flat;
            Cliente.ForeColor = Color.White;
            Cliente.Location = new Point(0, 228);
            Cliente.Name = "Cliente";
            Cliente.Padding = new Padding(10, 0, 0, 0);
            Cliente.Size = new Size(250, 45);
            Cliente.TabIndex = 3;
            Cliente.Text = "Cliente";
            Cliente.TextAlign = ContentAlignment.MiddleLeft;
            Cliente.UseVisualStyleBackColor = false;
            Cliente.Click += Cliente_Click;
            // 
            // panelSubMenu
            // 
            panelSubMenu.BackColor = Color.Black;
            panelSubMenu.Controls.Add(CrearUsuario);
            panelSubMenu.Controls.Add(IniciarSesion);
            panelSubMenu.Dock = DockStyle.Top;
            panelSubMenu.Location = new Point(0, 145);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(250, 83);
            panelSubMenu.TabIndex = 2;
            // 
            // CrearUsuario
            // 
            CrearUsuario.BackColor = Color.Black;
            CrearUsuario.Dock = DockStyle.Top;
            CrearUsuario.FlatAppearance.BorderSize = 0;
            CrearUsuario.FlatAppearance.MouseDownBackColor = Color.Blue;
            CrearUsuario.FlatAppearance.MouseOverBackColor = Color.Red;
            CrearUsuario.FlatStyle = FlatStyle.Flat;
            CrearUsuario.ForeColor = Color.White;
            CrearUsuario.Location = new Point(0, 40);
            CrearUsuario.Name = "CrearUsuario";
            CrearUsuario.Padding = new Padding(35, 0, 0, 0);
            CrearUsuario.Size = new Size(250, 45);
            CrearUsuario.TabIndex = 1;
            CrearUsuario.Text = "Crear Usuario";
            CrearUsuario.TextAlign = ContentAlignment.MiddleLeft;
            CrearUsuario.UseVisualStyleBackColor = false;
            CrearUsuario.Click += CrearUsuario_Click;
            // 
            // IniciarSesion
            // 
            IniciarSesion.Dock = DockStyle.Top;
            IniciarSesion.FlatAppearance.BorderSize = 0;
            IniciarSesion.FlatAppearance.MouseDownBackColor = Color.Blue;
            IniciarSesion.FlatAppearance.MouseOverBackColor = Color.Red;
            IniciarSesion.FlatStyle = FlatStyle.Flat;
            IniciarSesion.ForeColor = Color.White;
            IniciarSesion.Location = new Point(0, 0);
            IniciarSesion.Name = "IniciarSesion";
            IniciarSesion.Padding = new Padding(35, 0, 0, 0);
            IniciarSesion.Size = new Size(250, 40);
            IniciarSesion.TabIndex = 0;
            IniciarSesion.Text = "Iniciar Sesión";
            IniciarSesion.TextAlign = ContentAlignment.MiddleLeft;
            IniciarSesion.UseVisualStyleBackColor = true;
            IniciarSesion.Click += IniciarSesion_Click;
            // 
            // Estudiante
            // 
            Estudiante.BackColor = Color.FromArgb(64, 0, 0);
            Estudiante.Dock = DockStyle.Top;
            Estudiante.FlatAppearance.BorderSize = 0;
            Estudiante.FlatAppearance.MouseDownBackColor = Color.Blue;
            Estudiante.FlatAppearance.MouseOverBackColor = Color.Red;
            Estudiante.FlatStyle = FlatStyle.Flat;
            Estudiante.ForeColor = Color.White;
            Estudiante.Location = new Point(0, 100);
            Estudiante.Name = "Estudiante";
            Estudiante.Padding = new Padding(10, 0, 0, 0);
            Estudiante.Size = new Size(250, 45);
            Estudiante.TabIndex = 1;
            Estudiante.Text = "Empleado";
            Estudiante.TextAlign = ContentAlignment.MiddleLeft;
            Estudiante.UseVisualStyleBackColor = false;
            Estudiante.Click += Estudiante_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.BackgroundImage = Properties.Resources.LogoEmpresa;
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.ImeMode = ImeMode.NoControl;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 0;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(684, 561);
            panelContenedor.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(934, 561);
            Controls.Add(panelContenedor);
            Controls.Add(panelSideMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "Form1";
            Text = "MENU ";
            panelSideMenu.ResumeLayout(false);
            panelRedesSociales.ResumeLayout(false);
            panelMenu2.ResumeLayout(false);
            panelSubMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Panel panelSubMenu;
        private Button CrearUsuario;
        private Button IniciarSesion;
        private Button Estudiante;
        private Button Cliente;
        private Panel panelMenu2;
        private Button CrearUsuarioC;
        private Button IniciarSesionC;
        private Button Sobre;
        private Panel panelContenedor;
        private Panel panelRedesSociales;
        private Button RedesSociales;
    }
}
