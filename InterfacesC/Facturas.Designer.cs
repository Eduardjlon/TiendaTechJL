namespace TiendaExaFinalS2.InterfacesC
{
    partial class Facturas
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
            panelLogo = new Panel();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.BackgroundImage = Properties.Resources.LogoEmpresa;
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.ImeMode = ImeMode.NoControl;
            panelLogo.Location = new Point(12, 12);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(125, 59);
            panelLogo.TabIndex = 1;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(668, 522);
            Controls.Add(panelLogo);
            ForeColor = Color.White;
            MinimumSize = new Size(684, 561);
            Name = "Facturas";
            Text = "Facturas";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
    }
}