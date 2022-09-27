using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TULUZ.ABMS.Proveedores
{
    public partial class frmABM_Proveedores : Form
    {
        public frmABM_Proveedores()
        {
            InitializeComponent();
        }

        private void frmABM_Proveedores_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
    
            string cadenaConexion = "Data Source=DESKTOP-74FLCP1\\SQLEXPRESS;Initial Catalog=TuLuz;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM proveedores";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaProveedores.DataSource = tabla;

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_RazonSocial.Text = "";
            chk_BoxTodos.Checked = false;
            chk_BoxActivos.Checked = false;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            VentanaPrincipal principal = new VentanaPrincipal();
            principal.Show();
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frmAlta_Proveedores alta_proveedor = new frmAlta_Proveedores();
            alta_proveedor.Show();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (grillaProveedores.CurrentRow != null)
            {
                frmModificacion_Proveedores frmModificacion_Proveedores = new frmModificacion_Proveedores();
                int idProveedor = int.Parse(grillaProveedores.CurrentRow.Cells["columnProveedorId"].Value.ToString());
                frmModificacion_Proveedores.InicializarModificarProveedor(idProveedor);
                frmModificacion_Proveedores.ShowDialog();
            }
            CargarGrilla();
        }
    }
}
