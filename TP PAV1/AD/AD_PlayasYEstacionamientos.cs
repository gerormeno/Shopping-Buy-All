using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.AD
{
    class AD_PlayasYEstacionamientos
    {

        //Se usa para cargar el dataGrid con los estacionamientos de la playa seleccionada
        //en el comboBoxPlayas
        public static DataTable ObtenerEstacionamientosPorPlaya(int idPlaya)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "BuscarEstacionamientosPorPlaya";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPlaya", idPlaya);
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
        public static DataTable ObtenerCantEstacionamientosPorPlaya()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "CantEstacionamientosXPlaya";

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

        //Se usa para obtener los datos de un estacionamiento para despues eliminarlo
        public static Estacionamiento ObtenerEstacionamientoXIDyPlaya(int id, int playa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Estacionamiento e = new Estacionamiento();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BuscarEstacionamientosPorIDyPlaya";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@idPlaya", playa);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    e.IdEstacionamiento = Convert.ToInt32(dr["nro_estacionamiento"]);
                    e.IdPlaya = Convert.ToInt32(dr["id_playa"]);
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
            return e;
        }


        //Se usa para cargar el comboBoxPlayas y la grilla de playas
        public static DataTable ObtenerPlayas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetPlayas";

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


        public static bool InsertarEstacionamiento(Estacionamiento e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertEstacionamiento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPlaya", e.IdPlaya);
                cmd.Parameters.AddWithValue("@nro_estacionamiento", e.IdEstacionamiento);
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


        public static bool InsertarPlaya(Playa p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertPlaya";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombrePlaya", p.NombrePlaya);
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


        public static int ObtenerIDUltimoEstacionamiento(int playa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetUltimoEstacionamiento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPlaya", playa);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                if (tabla.Rows.Count != 0) 
                {
                    res = (Convert.ToInt32(tabla.Rows[0][1]) + 1);
                }
                else
                {
                    res = 1;
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
            return res;
        }


        public static bool EliminarEstacionamiento(int id, int playa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarEstacionamiento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@idPlaya", playa);
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


        public static bool EliminarEstacionamientosXPlaya(int playa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarEstacionamientosPorPlaya";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPlaya", playa);
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


        public static Playa ObtenerPlayaXID(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Playa p = new Playa();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BuscarPlayaPorID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.StoredProcedure;
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
            return p;
        }



        public static bool ActualizarPlaya(Playa p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarPlaya";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", p.IdPlaya);
                cmd.Parameters.AddWithValue("@nombre", p.NombrePlaya);
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


        public static bool EliminarPlaya(Playa p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarPlaya";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", p.IdPlaya);
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
