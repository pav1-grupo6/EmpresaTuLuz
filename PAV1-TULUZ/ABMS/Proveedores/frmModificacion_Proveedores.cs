using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TULUZ.ABMS.Proveedores
{
    public partial class frmModificacion_Proveedores : Form
    {
        private bool cambioRealizado = false;
        private int proveedorAModificar;
        public frmModificacion_Proveedores()
        {
            InitializeComponent();
        }

        private void txt_Mail_TextChanged(object sender, EventArgs e)
        {
            cambioRealizado = true;
        }

        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {
            cambioRealizado = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_RazonSocial_TextChanged(object sender, EventArgs e)
        {
            cambioRealizado = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (!cambioRealizado)
            {
                this.Close();
            } 

            else if ((MessageBox.Show("Si cancela no se registraran los cambios.", "Cancelar cambios", MessageBoxButtons.OKCancel) == DialogResult.OK))
                {
                    this.Close(); 
                }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        internal void InicializarModificarProveedor(int idProveedor)
        {
            string sql = "SELECT proveedor.razon_social," +
      "proveedor.mail," +
       "proveedor.telefono" +
  " FROM proveedores as proveedor" +
" WHERE proveedor_id = '" + idProveedor + "'";
            DataTable proveedor = DataManager.GetInstance().ConsultaSQL(sql);
            txt_Mail.Text = proveedor.Rows[0]["mail"].ToString();
            txt_Telefono.Text = proveedor.Rows[0]["telefono"].ToString();
            txt_RazonSocial.Text = proveedor.Rows[0]["razon_social"].ToString();
            cambioRealizado = false;
            proveedorAModificar = idProveedor;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (!cambioRealizado)
            {
                this.Close();
            }

            else if ((MessageBox.Show("¿Esta seguro que desea guardar cambios? esta accion no se podra deshacer", "Guardar cambios", MessageBoxButtons.OKCancel) == DialogResult.OK))
                {
                Dictionary<string, object> parametros = new Dictionary<string, object>(){
                                  {"razon_social", txt_RazonSocial.Text},
                                  {"mail", txt_Mail.Text},
                                  {"telefono", txt_Telefono.Text},
                                  {"proveedor", proveedorAModificar}};

                string sql = "UPDATE proveedores SET razon_social = @razon_social, mail = @mail, telefono = @telefono WHERE proveedor_id = @proveedor";
                DataManager.GetInstance().EjecutarSQL(sql, parametros);
                this.Close();
                 }
        }
    }
}
