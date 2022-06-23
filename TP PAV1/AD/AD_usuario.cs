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
    public class AD_usuario
    {
        public static bool ValidarUsuario(string nombre, string contraseña)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM usuarios WHERE usuario like @nombreUsu AND contraseña like @pass";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombre);
                cmd.Parameters.AddWithValue("@pass", contraseña);
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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public static bool InsertarUsuario(string nombreDeUsuario, string password,string Correo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevoUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@contraseña", password);
                cmd.Parameters.AddWithValue("@correo", Correo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return result;

        }

        public static DataTable obtenerUsuarios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetUsuarios";

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

        public static Usuarios obtenerUsuarioPorNombre(String NombreUsu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Usuarios U = new Usuarios();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BuscarUsuarioPorNombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", NombreUsu);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    U.IdPersona = (int)dr["id"];
                    U.UsuarioPersona = dr["usuario"].ToString();
                    U.contraseñaPersona = dr["contraseña"].ToString();
                    U.correoPersona = dr["correo"].ToString();
                    U.idPerfil = (int)dr["idPerfil"];
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
            return U;
        }

        public static void EliminarUsuario(String NombreUsu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Usuarios U = new Usuarios();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", NombreUsu);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un usuario antes de eliminarlo");
            }
            finally
            {
                cn.Close();
            }
           
        }

        public static bool ActualizarUsuario(Usuarios U)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ModificarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", U.IdPersona);
                cmd.Parameters.AddWithValue("@Usuario", U.UsuarioPersona);
                cmd.Parameters.AddWithValue("@Contraseña", U.contraseñaPersona);
                cmd.Parameters.AddWithValue("@Correo", U.correoPersona);
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

        public static Usuarios obtenerNombresDeUsuarios(String NombreUsu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Usuarios U = new Usuarios();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BuscarUsuarioPorNombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", NombreUsu);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    U.IdPersona = (int)dr["id"];
                    U.UsuarioPersona = dr["usuario"].ToString();
                    U.contraseñaPersona = dr["contraseña"].ToString();
                    U.correoPersona = dr["correo"].ToString();
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
            return U;
        }

        public static DataTable CargarUsuariosPorNombre(string NombreUsu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "BuscarUsuarioPorNombre";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", NombreUsu);
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
