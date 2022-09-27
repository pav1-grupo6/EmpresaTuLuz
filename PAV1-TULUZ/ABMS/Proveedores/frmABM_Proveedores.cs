using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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
            string cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=TuLuz;Integrated Security=True";
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


        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = grillaProveedores.CurrentRow;
            if (fila != null)
            {
                string cuitprov = fila.Cells["Columna_id"].Value.ToString();
                EliminarProveedor(cuitprov);
            }
        }
        public bool EliminarProveedor(string cuitProveedor)
        {

            string cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=TuLuz;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM proveedores WHERE proveedor_id = " + cuitProveedor;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

                if (cuitProveedor != null)
                {
                    MessageBox.Show("Se borro existosamente");
                }
                else
                {
                    MessageBox.Show("No se borro, hubo error");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
         {/*
            string query = "SELECT * FROM proveedores WHERE 1=1";
            if (!string.IsNullOrEmpty(txt_RazonSocial.Text))
            {
                query += " razon_social LIKE '%" + txt_RazonSocial.Text + "%'";
            }
            if (chk_BoxActivos.Checked)
            {
                query += " AND proveedor_activo = '1'";
            }
            else
            {
                query += " AND proveedor_activo = '0'";
            }

            List<Parametro> lst = new List<Parametro>();
            //lst.Add(new Parametro("@nombre", txtNombre.Text));
            
            DataTable resultados = new HelperDB().ConsultaSQL(query, lst);
            //Limpiar grilla
            //grillaProveedores.Rows.Clear();
            if (resultados.Rows.Count > 0)
            {
                //Volver a cargar
                foreach (DataRow fila in resultados.Rows)
                {
                    bool activo = fila["proveedor_activo"].ToString().Equals("1");

                    int id = (int)fila["proveedor_id"];
                    grillaProveedores.Rows.Add(new object[] { fila["proveedor_id"].ToString(), fila["razon_social"], fila["mail"], fila["telefono"].ToString(), fila["proveedor_activo"].ToString()});
                }
            }
            */
           }
        }
}
