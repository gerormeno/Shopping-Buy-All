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
    class AD_RegistroEstacionamiento_Ingreso
    {
        public static DataTable ObtenerRegistros()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT playa.nombre_playa, registro_estacionamiento.nro_estacionamiento, registro_estacionamiento.patente, registro_estacionamiento.fecha_estacionamiento, registro_estacionamiento.hora_desde FROM registro_estacionamiento INNER JOIN playa ON registro_estacionamiento.id_playa = playa.id_playa";

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

        public static DataTable ObtenerVehiculoPorPatente(string patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();

            string consulta = "SELECT * FROM vehiculo WHERE patente = @patente";

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

        public static bool RegistrarIngreso(int idPlaya, string patente, int nroEstacionamiento,
            DateTime fecha)
        {
            string horaIngreso = fecha.ToString();
            string horaRecorte = horaIngreso.Substring(9);
            TimeSpan horaIngresoFinal = TimeSpan.Parse(horaRecorte); // en esta variable esta la hora en datetime. 

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                //string consulta = "INSERT INTO registro_estacionamiento (id_playa) (nro_estacionamiento) " +
                //    "(patente) (fecha_estacionamiento) (hora_desde) VALUES (@id_playa) (@nro_estacionamiento)" +
                //    "(@patente) (@fecha) (@hora_desde)";

                string consulta = "INSERT INTO registro_estacionamiento (id_playa, nro_estacionamiento, " +
                    "patente, fecha_estacionamiento, hora_desde)" +
                    " VALUES (@id_playa, @nro_estacionamiento, @patente, @fecha, @hora_desde)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_playa", idPlaya);
                cmd.Parameters.AddWithValue("@nro_estacionamiento", nroEstacionamiento);
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@hora_desde", horaIngresoFinal);

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

        public static DataTable ObtenerEstadisticasRegistros()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT p.nombre_playa as Playa, " +
                    "COUNT (re.patente) as Cantidad " +
                    "FROM registro_estacionamiento re " +
                    "INNER JOIN playa p ON re.id_playa = p.id_playa " +
                    "GROUP BY p.nombre_playa";

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
    }
}
