using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaExaFinalS2.InterfacesSobreNosotros
{
    public partial class RedesSociales : Form
    {
        public RedesSociales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/tech_jjll/profilecard/?igsh=MXZqM3VtZW11NTg1Yw=="; // Reemplaza con el enlace de tu perfil de IG
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true // Necesario para abrir el navegador en sistemas modernos
            });
        }
    }
}
