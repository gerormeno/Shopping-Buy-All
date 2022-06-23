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
    class AD_VehiculosXClientes
    {
        public static DataTable obtenerVehiculosXCliente()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetVehiculosXClientes";

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
                    veh.modeloVehiculo = (int)dr["id_modelo_vehiculo"];
                    veh.tipoVehiculo = (int)dr["id_tipo_vehiculo"];
                    veh.nroDocVehiculo = dr["nro_documento"].ToString();
                    veh.tipoDocVehiculo = (int)dr["id_tipo_documento"];
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

        public static bool ActualizarVehiculoPorCliente(Vehiculo V)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ModificarVehiculoPorCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", V.patenteVehiculo);
                cmd.Parameters.AddWithValue("@id_tipo_documento", V.tipoDocVehiculo);
                cmd.Parameters.AddWithValue("@nro_documento",V.nroDocVehiculo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Debe seleccionar el usuario antes de modificarlo");
            }
            finally
            {
                cn.Close();
            }
            return result;
        }
    }
}
