using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_TULUZ
{
    class HelperDB
    {
        private SqlConnection cnn;

        public HelperDB()

        {
            string cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=TuLuz;Integrated Security=True";
            cnn = new SqlConnection(cadenaConexion);
        }

        public DataTable ConsultaSQL(string strSql, List<Parametro> lst)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;

            //if (lst != null && lst.Count > 0)
            foreach (Parametro p in lst)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }


        //Permite ejecutar INSERT/UPDATE/DELETE
        //a partir de una consulta SQL con parametros
        public int EjecutarSQL(string strSql, List<Parametro> lst)
        {
            int afectadas = 0;
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = strSql;

            foreach (Parametro p in lst)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            afectadas = cmd.ExecuteNonQuery();
            cnn.Close();

            return afectadas;
        }
    }
}
