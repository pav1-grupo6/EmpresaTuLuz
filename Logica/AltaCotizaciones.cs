using System;
using EmpresaTuLuz.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmpresaTuLuz.Logica
{
    public partial class AltaCotizaciones : Form
    {
        public AltaCotizaciones()
        {
            InitializeComponent();
        }


        private void AltaCotizaciones_Load(object sender, EventArgs e)
        {
            Cargafecha();
            ObtenerUltimoNroCotizacion();
            CargarComboCliente();
            CargarComboEstado();
            CargarComboVendedor();
            CargarComboProducto();
            //CargarCombos();
        }
        private void Cargafecha()
            {
                txtfecha.Text=DateTime.Now.ToShortDateString();
                

            }
        /*public void CargarCombos()
        {
            CargarComboCliente();
            CargarComboEstado();
            CargarComboVendedor();
            CargarComboProducto();
        }*/

        private void ObtenerUltimoNroCotizacion()
        {
            int id = CotizacionDAO.ObtenerUltimoNroCotizacion();
            txtNroCotizacion.Text = (id + 1).ToString();
        }
        private void CargarComboCliente()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM clientes";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbIdCliente.DataSource = tabla;
                cmbIdCliente.DisplayMember = "cliente_id";
                cmbIdCliente.ValueMember = "cliente_id";
                cmbIdCliente.SelectedIndex = -1;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }
        private void CargarComboEstado()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM estados_cotizaciones";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbEstado.DataSource = tabla;
                cmbEstado.DisplayMember = "descripcion";
                cmbEstado.ValueMember = "id_estado";
                cmbEstado.SelectedIndex = -1;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }
        private void CargarComboVendedor()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM empleados";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbVendedor.DataSource = tabla;
                cmbVendedor.DisplayMember = "empleado_id";
                cmbVendedor.ValueMember = "empleado_id";
                cmbVendedor.SelectedIndex = -1;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        private void CargarComboProducto()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM productos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbProducto.DataSource = tabla;
                cmbProducto.DisplayMember = "nombre";
                cmbProducto.ValueMember = "id";
                cmbProducto.SelectedIndex = -1;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = ClienteDAO.ObtenerClientexId(int.Parse(cmbIdCliente.Text));
                if (tablaResultado.Rows.Count > 0)
                {
                    txtNombreCliente.Text = tablaResultado.Rows[0][2].ToString();
                    txtApellidoCliente.Text= tablaResultado.Rows [0][3].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente Inexistente");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            DataTable tablaResultado = ProductoDAO.Obtenerproductoxnombre(cmbProducto.Text);
            float PxC= 0;

            if (tablaResultado.Rows.Count > 0)
            {
                float precioUni = float.Parse(tablaResultado.Rows[0][2].ToString());
                float cantP = float.Parse(txtCantidad.Text);
                PxC = precioUni * cantP;
                grillaProductos.Rows.Add(txtIdProducto.Text,cmbProducto.Text, txtCantidad.Text, PxC);
            }
            
        }

        

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = ProductoDAO.Obtenerproductoxnombre(cmbProducto.Text);
                if (tablaResultado.Rows.Count > 0)
                {
                    txtIdProducto.Text = tablaResultado.Rows[0][0].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Cliente Inexistente");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
          

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow Fila in grillaProductos.Rows)
            {
                double subtotal = Convert.ToDouble(Fila.Cells[3].Value);
                total += subtotal;
            }
            txtTotal.Text = total.ToString();
        }
        private void btnGuardarCotizacion_Click(object sender, EventArgs e)
        {
            List<int> listaProductos = new List<int>();
            for (int i = 0; i < grillaProductos.Rows.Count; i++)
            {
                listaProductos.Add(int.Parse(grillaProductos.Rows[i].Cells[0].Value.ToString()));
            }

            bool resultado = CotizacionDAO.AltaCotizacion(int.Parse(txtNroCotizacion.Text), int.Parse(cmbIdCliente.Text), int.Parse(cmbVendedor.Text), int.Parse(cmbEstado.ValueMember), txtNombreCliente.Text, txtApellidoCliente.Text, txtObservaciones.Text, float.Parse(txtTotal.Text), txtMotPerdida.Text, listaProductos);
            if (resultado) 
            {
                MessageBox.Show("Alta de dealle de cotizacion exitoso");
            }
            else
            {
                MessageBox.Show("Error al dar alta detalle de cotizacion");
            }
        }
    }
}
