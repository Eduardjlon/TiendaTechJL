namespace TiendaExaFinalS2.InterfacesSobreNosotros
{
    partial class SobreNosotros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreNosotros));
            panelImagenLogo = new Panel();
            LabelRecuperandoContraseña = new Label();
            labelSobreNosotrosInfo = new Label();
            SuspendLayout();
            // 
            // panelImagenLogo
            // 
            panelImagenLogo.BackgroundImage = Properties.Resources.LogoEmpresa;
            panelImagenLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelImagenLogo.Location = new Point(195, 12);
            panelImagenLogo.Name = "panelImagenLogo";
            panelImagenLogo.Size = new Size(244, 100);
            panelImagenLogo.TabIndex = 31;
            // 
            // LabelRecuperandoContraseña
            // 
            LabelRecuperandoContraseña.AutoSize = true;
            LabelRecuperandoContraseña.FlatStyle = FlatStyle.Flat;
            LabelRecuperandoContraseña.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRecuperandoContraseña.ForeColor = Color.White;
            LabelRecuperandoContraseña.Location = new Point(195, 115);
            LabelRecuperandoContraseña.Name = "LabelRecuperandoContraseña";
            LabelRecuperandoContraseña.Size = new Size(244, 31);
            LabelRecuperandoContraseña.TabIndex = 32;
            LabelRecuperandoContraseña.Text = "Sobre Nosotros";
            LabelRecuperandoContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSobreNosotrosInfo
            // 
            labelSobreNosotrosInfo.FlatStyle = FlatStyle.Flat;
            labelSobreNosotrosInfo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSobreNosotrosInfo.ForeColor = Color.White;
            labelSobreNosotrosInfo.Location = new Point(12, 158);
            labelSobreNosotrosInfo.Name = "labelSobreNosotrosInfo";
            labelSobreNosotrosInfo.Size = new Size(644, 355);
            labelSobreNosotrosInfo.TabIndex = 0;
            labelSobreNosotrosInfo.Text = resources.GetString("labelSobreNosotrosInfo.Text");
            labelSobreNosotrosInfo.Click += labelSobreNosotrosInfo_Click;
            // 
            // SobreNosotros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(668, 522);
            Controls.Add(labelSobreNosotrosInfo);
            Controls.Add(LabelRecuperandoContraseña);
            Controls.Add(panelImagenLogo);
            MinimumSize = new Size(684, 561);
            Name = "SobreNosotros";
            Text = "SobreNosotros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelImagenLogo;
        private Label LabelRecuperandoContraseña;
        private Label labelSobreNosotrosInfo;
    }
}