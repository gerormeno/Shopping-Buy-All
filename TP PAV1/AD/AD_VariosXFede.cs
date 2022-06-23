using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV1.Entidades;

namespace TP_PAV1.AD
{
    public class AD_VariosXFede
    {
        public static bool AgregaClienteABD(Cliente cli)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                //string consulta = "INSERT INTO clientes (tipo_documento, nro_documento, nombre, apellido, calle, calle_nro, id_barrio,fecha_Nacimiento, id_Sexo, id_estado_civil) VALUES(@tipo_documento, @nroDocumento, @nombre, @apellido,  @calle, @calle_nro, @id_barrio, @fechaNacimiento, @idSexo, @id_estado_civil)";
                string consulta = "InsertarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_documento", cli.TipoDocumentoCliente);
                cmd.Parameters.AddWithValue("@nroDocumento", cli.DocumentoCliente);
                cmd.Parameters.AddWithValue("@nombre", cli.NombreCliente);
                cmd.Parameters.AddWithValue("@apellido", cli.ApellidoCliente);
                cmd.Parameters.AddWithValue("@calle", cli.CalleCliente);
                cmd.Parameters.AddWithValue("@calle_nro", cli.NroCasaCliente);
                cmd.Parameters.AddWithValue("@id_barrio", cli.BarrioCliente);
                cmd.Parameters.AddWithValue("@fechaNacimiento", cli.FechaNacimientoCliente);
                cmd.Parameters.AddWithValue("@idSexo", cli.SexoCliente);
                cmd.Parameters.AddWithValue("@id_estado_civil", cli.EstadoCivilCliente);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static Cliente ObtenerIdClienteXDocumento(string nroDoc, int tipoDoc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente c = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetClientexTipoYDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_documento", tipoDoc);
                cmd.Parameters.AddWithValue("@nro_documento", nroDoc);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    c.DocumentoCliente = dr["nro_documento"].ToString();
                    c.ApellidoCliente = dr["apellido"].ToString();
                    c.NombreCliente = dr["nombre"].ToString();
                    c.FechaNacimientoCliente = DateTime.Parse(dr["fecha_Nacimiento"].ToString());
                    c.SexoCliente = int.Parse(dr["id_Sexo"].ToString());
                    c.TipoDocumentoCliente = int.Parse(dr["tipo_documento"].ToString());
                    c.BarrioCliente = int.Parse(dr["id_barrio"].ToString());
                    c.CalleCliente = dr["calle"].ToString();
                    c.NroCasaCliente = int.Parse(dr["calle_nro"].ToString());
                    c.EstadoCivilCliente = int.Parse(dr["id_estado_civil"].ToString());

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

            return c;
        }

        public static DataTable ObtenerRegistroEstadias()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetRegistrosEstadiaEstacionamiento";

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
