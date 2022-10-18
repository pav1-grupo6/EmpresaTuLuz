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

namespace EmpresaTuLuz.Logica
{
    public partial class ABMC_Cotizaciones : Form
    {
        public ABMC_Cotizaciones()
        {
            InitializeComponent();
        }

        private void ABMC_Cotizaciones_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarGrilla();
        }
        private void CargarCombo()
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

                    cmbEstados.DataSource = tabla;
                    cmbEstados.DisplayMember = "descripcion";
                    cmbEstados.ValueMember = "id_estado";
                    cmbEstados.SelectedIndex = -1;

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
        public void CargarGrilla()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM cotizaciones";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaCotizaciones.DataSource = tabla;

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaCotizaciones ventana = new AltaCotizaciones();
            ventana.ShowDialog();
        }
    }
}
