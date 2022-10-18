using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTuLuz.DAO
{
    class CotizacionDAO
    {
        //Validar si el usuario existe en la BD
        public static int ObtenerUltimoNroCotizacion()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
 
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT MAX(numCotizacion) FROM cotizaciones";
                //Agregando parameters
                cmd.Parameters.Clear();
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
            }
            catch (Exception)
            {

                return 0;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool AltaCotizacion(int numCot,int idCliente,int idVend, int estado, string nombre, string apellido, string obs, float precio, string motivo, List<int> listaProd)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlTransaction objTransaccion = null;

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "INSERT INTO cotizaciones values(@numCot,@idCliente,@idVend,@estado,@nombre,@apellido,@fecha,@obs,@precio,@motivo)";
                //Agregando parameters
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@numCot",numCot);
                cmd.Parameters.AddWithValue("@idCliente",idCliente);
                cmd.Parameters.AddWithValue("@idVend",idVend);
                cmd.Parameters.AddWithValue("@estado",estado);
                cmd.Parameters.AddWithValue("@nombre",nombre);
                cmd.Parameters.AddWithValue("@apellido",apellido);
                cmd.Parameters.AddWithValue("@fecha",DateTime.Now);
                cmd.Parameters.AddWithValue("@obs",obs);
                cmd.Parameters.AddWithValue("@precio",precio);
                cmd.Parameters.AddWithValue("@motivo",motivo);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                

                cn.Open();

                objTransaccion = cn.BeginTransaction("AltaDeCotizacion");

                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
                foreach (var idProducto in listaProd)
                {
                    //string consultaCotizacioXDetalle = "INSERT INTO detalle_cotizacion values(@numCotizacion,@cod_producto,@cantidad,@precio)";
                    string consultaCotizacioXDetalle = "INSERT INTO detalle_cotizacion values(@numCotizacion,@cod_producto,@precio)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@numCotizacion", numCot);
                    cmd.Parameters.AddWithValue("@cod_producto", idProducto);
                    //cmd.Parameters.AddWithValue("@cantidad", );
                    cmd.Parameters.AddWithValue("@precio",precio);

                    cmd.CommandText = consultaCotizacioXDetalle;
                    cmd.ExecuteNonQuery();
                }
                objTransaccion.Commit();
                return true;

            }
            catch (Exception)
            {
                objTransaccion.Rollback();
                return false;
                ;
            }
            finally
            {
                cn.Close();
            }
        }

        
    }
}
