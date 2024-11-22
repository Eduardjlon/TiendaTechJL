namespace TiendaExaFinalS2.InterfacesC
{
    partial class MenuCliente
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            panelImagenLogoMenu = new Panel();
            Bienvenida = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 109);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(644, 401);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // txtBuscar
            // 
            txtBuscar.AccessibleRole = AccessibleRole.None;
            txtBuscar.BackColor = Color.Black;
            txtBuscar.Cursor = Cursors.Help;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(304, 80);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(245, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.Text = "Ingresa Id/Nombre";
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(555, 80);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // panelImagenLogoMenu
            // 
            panelImagenLogoMenu.BackgroundImage = Properties.Resources.LogoEmpresa;
            panelImagenLogoMenu.BackgroundImageLayout = ImageLayout.Stretch;
            panelImagenLogoMenu.Location = new Point(12, 12);
            panelImagenLogoMenu.Name = "panelImagenLogoMenu";
            panelImagenLogoMenu.Size = new Size(179, 91);
            panelImagenLogoMenu.TabIndex = 40;
            // 
            // Bienvenida
            // 
            Bienvenida.AutoSize = true;
            Bienvenida.FlatStyle = FlatStyle.Flat;
            Bienvenida.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bienvenida.ForeColor = Color.White;
            Bienvenida.Location = new Point(216, 12);
            Bienvenida.Name = "Bienvenida";
            Bienvenida.Size = new Size(440, 37);
            Bienvenida.TabIndex = 41;
            Bienvenida.Text = "Bienvenido Al Mundo 3D";
            Bienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(668, 522);
            Controls.Add(Bienvenida);
            Controls.Add(panelImagenLogoMenu);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(flowLayoutPanel1);
            MinimumSize = new Size(684, 561);
            Name = "MenuCliente";
            Text = "MenuCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Panel panelImagenLogoMenu;
        private Label Bienvenida;
    }
}