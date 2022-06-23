using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV1.Entidades;

namespace TP_PAV1.AD
{
    public class AD_Vehiculo
    {
        public static DataTable obtenerVehiculos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "getVehiculos";

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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool EliminarVehiculo(String Patente)
        {
            bool rtdo = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Vehiculo v = new Vehiculo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarVehiculo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Patente", Patente);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                rtdo = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return rtdo;

        }

        public static Vehiculo obtenerVehiculoPorPatente(String patent)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Vehiculo veh = new Vehiculo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarVehiculoPorPatente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", patent);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    veh.patenteVehiculo = dr["patente"].ToString();
                    veh.tipoVehiculo = (int)dr["id_tipo_vehiculo"];
                    veh.modeloVehiculo = (int)dr["id_modelo_vehiculo"];
                    veh.tipoDocVehiculo = (int)dr["tipo_documento"];
                    veh.nroDocVehiculo = dr["nro_documento"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return veh;
        }

        public static string ObtenerDescripcion(string primaryKey, string nombrePkTabla, string nombreDescripcion, string tabla)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"]);
            cn.Open();
            try
            {
                SqlCommand command = new SqlCommand("SELECT TOP 1 " + nombreDescripcion + " FROM " + tabla + " WHERE " + nombrePkTabla + " = " + primaryKey + ";", cn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var valor = reader.GetString(0);
                        return valor;
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return null;
        }

        public static bool InsertarVehiculo(string Patente, int idDoc, string nroDoc, int idMarcaVehiculo, int idTipoVehiculo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertVehiculo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", Patente);
                cmd.Parameters.AddWithValue("@idMarcaVehiculo", idMarcaVehiculo);
                cmd.Parameters.AddWithValue("@idTipoVehiculo", idTipoVehiculo);
                cmd.Parameters.AddWithValue("@idDni", idDoc);
                cmd.Parameters.AddWithValue("@NroDni", nroDoc);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                cn.Close();
            }
            return result;

        }
        public static bool ActualizarVehiculoPorCliente(Vehiculo V)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarVehiculoo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", V.patenteVehiculo);
                cmd.Parameters.AddWithValue("@tipo_documento", V.tipoDocVehiculo);
                cmd.Parameters.AddWithValue("@nro_documento", V.nroDocVehiculo);
                cmd.Parameters.AddWithValue("@id_tipo_vehiculo", V.tipoVehiculo);
                cmd.Parameters.AddWithValue("@id_modelo_vehiculo", V.modeloVehiculo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return result;
        }
        public static DataTable CargarVehiculoPorPatente(string Patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "BuscarVehiculoPorText";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", Patente);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable obtenerCantVehiculosPorModelo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "CantVehiculosXModelo";

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
