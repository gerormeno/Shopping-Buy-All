using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.AD
{
    class AD_Barrios
    {
        public static DataTable ObtenerBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetBarrios";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
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

        public static Barrio ObtenerBarrioXID(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Barrio b = new Barrio();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM barrios WHERE id_barrio LIKE @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    b.IdBarrio = Convert.ToInt32(dr["id_barrio"]);
                    b.NombreBarrio = Convert.ToString(dr["nombre_barrio"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return b;
        }

        public static bool ActualizarBarrio(Barrio b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", b.IdBarrio);
                cmd.Parameters.AddWithValue("@nombre", b.NombreBarrio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return res;
        }

        public static bool InsertarBarrio(Barrio b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBarrio", b.NombreBarrio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return res;
        }

        public static int ObtenerIDUltimoBarrio()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetUltimoBarrio";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                res = (Convert.ToInt32(tabla.Rows[0][0]) + 1);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return res;
        }

        public static DataTable BuscarBarriosPorNombre(string criterio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "BuscarBarriosPorNombre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBarrio", criterio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
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

        public static bool EliminarBarrio(Barrio b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarBarrio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", b.IdBarrio);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return res;
        }
    }
}
