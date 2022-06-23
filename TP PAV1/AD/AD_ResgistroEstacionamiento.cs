using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV1.AD
{
    class AD_RegistroEstacionamiento
    {
        public static DataTable ObtenerRegistroPorPatente(string patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();

            string consulta = "SELECT * FROM registro_estacionamiento WHERE patente = @patente";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@patente", patente);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;

        }
        public static string ObtenerPlayaXID(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Playa p = new Playa();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT id_playa, nombre_playa FROM playa WHERE id_playa = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.IdPlaya = Convert.ToInt32(dr["id_playa"]);
                    p.NombrePlaya = dr["nombre_playa"].ToString();
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
            return p.NombrePlaya;
        }
        public static DataTable ObtenerRegistros()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT playa.nombre_playa, registro_estacionamiento.nro_estacionamiento, registro_estacionamiento.patente, registro_estacionamiento.fecha_estacionamiento, registro_estacionamiento.hora_desde, registro_estacionamiento.hora_hasta, registro_estacionamiento.monto FROM registro_estacionamiento INNER JOIN playa ON registro_estacionamiento.id_playa = playa.id_playa";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

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

        public static bool InsertarMonto(int monto, string patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE registro_estacionamiento SET monto=@monto WHERE patente=@patente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
        public static bool InsertarHoraHasta(TimeSpan horaSalida, string patente)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE registro_estacionamiento SET hora_hasta=@horaSalida WHERE patente=@patente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Parameters.AddWithValue("@horaSalida", horaSalida);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
    }
}