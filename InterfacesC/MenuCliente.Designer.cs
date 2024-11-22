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
            lblMontoTotal = new Label();
            panelCarrito = new Panel();
            listBoxCarrito = new ListBox();
            btnQuitar = new Button();
            panelCarrito.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 154);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(644, 356);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // txtBuscar
            // 
            txtBuscar.AccessibleRole = AccessibleRole.None;
            txtBuscar.BackColor = Color.Black;
            txtBuscar.Cursor = Cursors.Help;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(402, 124);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(147, 23);
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
            btnBuscar.Location = new Point(555, 124);
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
            panelImagenLogoMenu.Size = new Size(144, 60);
            panelImagenLogoMenu.TabIndex = 40;
            // 
            // Bienvenida
            // 
            Bienvenida.AutoSize = true;
            Bienvenida.FlatStyle = FlatStyle.Flat;
            Bienvenida.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bienvenida.ForeColor = Color.White;
            Bienvenida.Location = new Point(188, 12);
            Bienvenida.Name = "Bienvenida";
            Bienvenida.Size = new Size(440, 37);
            Bienvenida.TabIndex = 41;
            Bienvenida.Text = "Bienvenido Al Mundo 3D";
            Bienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.ForeColor = Color.White;
            lblMontoTotal.Location = new Point(311, 132);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(38, 15);
            lblMontoTotal.TabIndex = 42;
            lblMontoTotal.Text = "label1";
            // 
            // panelCarrito
            // 
            panelCarrito.Controls.Add(listBoxCarrito);
            panelCarrito.Location = new Point(12, 78);
            panelCarrito.Name = "panelCarrito";
            panelCarrito.Size = new Size(256, 70);
            panelCarrito.TabIndex = 43;
            // 
            // listBoxCarrito
            // 
            listBoxCarrito.BackColor = Color.Black;
            listBoxCarrito.ForeColor = Color.White;
            listBoxCarrito.FormattingEnabled = true;
            listBoxCarrito.ItemHeight = 15;
            listBoxCarrito.Location = new Point(3, 3);
            listBoxCarrito.Name = "listBoxCarrito";
            listBoxCarrito.Size = new Size(250, 64);
            listBoxCarrito.TabIndex = 0;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.FromArgb(192, 0, 0);
            btnQuitar.FlatAppearance.BorderSize = 0;
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.ForeColor = Color.White;
            btnQuitar.Location = new Point(271, 80);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(125, 23);
            btnQuitar.TabIndex = 44;
            btnQuitar.Text = "Quitar Del Carrito";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(668, 522);
            Controls.Add(btnQuitar);
            Controls.Add(panelCarrito);
            Controls.Add(lblMontoTotal);
            Controls.Add(Bienvenida);
            Controls.Add(panelImagenLogoMenu);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(flowLayoutPanel1);
            MinimumSize = new Size(684, 561);
            Name = "MenuCliente";
            Text = "MenuCliente";
            Load += MenuCliente_Load;
            panelCarrito.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Panel panelImagenLogoMenu;
        private Label Bienvenida;
        private Label lblMontoTotal;
        private Panel panelCarrito;
        private ListBox listBoxCarrito;
        private Button btnQuitar;
    }
}