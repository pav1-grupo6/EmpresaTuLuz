using PAV1_TULUZ.ABMS.Proveedores;
using PAV1_TULUZ.Entidades;

namespace PAV1_TULUZ
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        public VentanaPrincipal(Usuario usuario)
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido al Sistema " + usuario.Nombre;
            lblBienvenida.Visible = true;
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmABM_Proveedores formProveedores = new frmABM_Proveedores();
            formProveedores.Show();
        }
    }
}