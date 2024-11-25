

using TiendaExaFinalS2.InterfacesC;
using TiendaExaFinalS2.InterfacesE;
using TiendaExaFinalS2.InterfacesSobreNosotros;

namespace TiendaExaFinalS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            costumizeDesign();
            CargarFormularioInicial();

        }
        public void CargarFormularioInicial()
        {
            AbrirFormularioEnPanel(new SobreNosotros());
        }
        private void costumizeDesign()
        {
            panelSubMenu.Visible = false;
            panelMenu2.Visible = false;
            panelRedesSociales.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
            if (panelMenu2.Visible == true)
                panelMenu2.Visible = false;
            if (panelRedesSociales.Visible == true)
                panelRedesSociales.Visible = false;
        }
        private void showSubMenus(Panel subMenus)
        {
            if (subMenus.Visible == false)
            {
                hideSubMenu();
                subMenus.Visible = true;
            }
            else
                subMenus.Visible = false;
        }

        private void Estudiante_Click(object sender, EventArgs e)
        {
            showSubMenus(panelSubMenu);
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            var iniciarSesionForm = new IniciarSesionE();
            AbrirFormularioEnPanel(iniciarSesionForm);   // Mostrarlo en el panel
        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {
            var CrearUsuarioForm = new CrearUsuarioE();
            AbrirFormularioEnPanel(CrearUsuarioForm);   // Mostrarlo en el panel
        }

        private void Cliente_Click(object sender, EventArgs e)
        {
            showSubMenus(panelMenu2);
        }

        private void IniciarSesionC_Click(object sender, EventArgs e)
        {
            var TiendaMenuForm = new MenuCliente();
            AbrirFormularioEnPanel(TiendaMenuForm);   // Mostrarlo en el panel
        }



        private void CrearUsuarioC_Click(object sender, EventArgs e)
        {
            var FacturaGenerarForm = new Facturas();
            AbrirFormularioEnPanel(FacturaGenerarForm);   // Mostrarlo en el panel
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            var SobreNosotrosForm = new SobreNosotros();
            AbrirFormularioEnPanel(SobreNosotrosForm); //Mostrarlo en el panel
            showSubMenus(panelRedesSociales);
        }
        public void AbrirFormularioEnPanel(Form formulario)
        {
            // Limpiar cualquier control existente en el panel
            panelContenedor.Controls.Clear();

            // Configurar el formulario para que se integre en el panel
            formulario.TopLevel = false; // No es un formulario independiente
            formulario.Dock = DockStyle.Fill; // Ocupa todo el espacio del panel
            formulario.FormBorderStyle = FormBorderStyle.None; // Sin bordes

            // Agregar el formulario al panel y mostrarlo
            panelContenedor.Controls.Add(formulario);
            formulario.Show();

        }

        private void RedesSociales_Click(object sender, EventArgs e)
        {
            var RedesSocialesIgForm = new RedesSociales();
            AbrirFormularioEnPanel(RedesSocialesIgForm); //Mostrarlo en el panel
            showSubMenus(panelRedesSociales);
        }
    }
}
