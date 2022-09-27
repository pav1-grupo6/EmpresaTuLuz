using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TULUZ.ABMS.Proveedores
{
    public partial class frmAlta_Proveedores : Form
    {
        public frmAlta_Proveedores()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_RazonSocial.Text = "";
            txt_Mail.Text = "";
            txt_Telefono.Text = "";
            chk_Activo.Checked = false;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            // VALIDACIONES CORRESPONDIENTES ANTES DE INSERT
            // EL PROVEEDOR YA EXISTE? RAZON SOCIAL Existente en BD
            // FALTARIA CUIT COMO DATO EN LA BD?
            if (txt_RazonSocial.Text.Equals(""))
            {
                MessageBox.Show("Ingrese una razon social");
            }
            else if (txt_Mail.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un mail");
            }
            else if (txt_Telefono.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un Telefono");
            }
            else
            {
                string razonSocial = txt_RazonSocial.Text;
                string mail = txt_Mail.Text;
                string telefono = txt_Telefono.Text;
                bool activo = chk_Activo.Checked;
                try
                {
                    bool resultado = InsertarProveedor(razonSocial, mail, telefono, activo);
                    if (resultado)
                    {
                        MessageBox.Show("Proveedor dado de alta con éxito");
                        LimpiarCampos();
                        txt_RazonSocial.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar nuevo Proveedor");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private bool InsertarProveedor(string razon_social, string mail, string telefono, bool activo)
        {
            string cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=TuLuz;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO proveedores VALUES(@razonSocial, @mail, @telefono, @activo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@razonSocial", razon_social);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
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
        
    }
}
