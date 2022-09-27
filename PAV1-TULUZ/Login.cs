using PAV1_TULUZ.Entidades;
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

namespace PAV1_TULUZ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

            if (txt_Usuario.Text.Equals("") || txt_Paassword.Text.Equals("")) 
            {
                MessageBox.Show("Ingrese Usuario y Contraseña");
            }
            else
            {
                string nombreDeUsuario = txt_Usuario.Text;
                string password = txt_Paassword.Text;
                bool resultado = false;

                try
                {
                    resultado = ValidarUsuario(nombreDeUsuario, password);
                    if (resultado == true)
                    {
                        Usuario usu = new Usuario(nombreDeUsuario, password);
                        VentanaPrincipal principal = new VentanaPrincipal(usu);
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales invalidas");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar usaurio");
                }
            }
        }

        private bool ValidarUsuario(string nombreUsuario, string password)
        {
            string cadenaConexion = "Data Source=-PC\\SQLEXPRESS;Initial Catalog=TuLuz;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM usuarios WHERE usuario_nombre LIKE @nombreUsu AND usuario_pass LIKE @pass";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreUsuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }

                return resultado;
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
    }
}
