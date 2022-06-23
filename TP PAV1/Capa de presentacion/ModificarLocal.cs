using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV1.Entidades;

namespace TP_PAV1
{
    public partial class ModificarLocal : Form
    {
        public ModificarLocal()
        {
            InitializeComponent();
        }

        private void ModificarLocal_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cargarComboTipoLocal();
            btnModificarLocal.Enabled = false;
            txtNombreLocal.Enabled = false;
            txtNumLocal.Enabled = false;
        }
        private void cargarGrilla()
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    string consulta = "SELECT locales_comerciales.nro_local, locales_comerciales.nombre_comercio, tipo_comercio.nombre_tipo_comercios FROM locales_comerciales INNER JOIN tipo_comercio ON locales_comerciales.id_tipo_comercio = tipo_comercio.id_tipo_comercios";
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    grillaLocales.DataSource = tabla;

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

        private bool ActualizarLocal(Local l)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE locales_comerciales SET nombre_comercio = @nombre, id_tipo_comercio = @id_local WHERE nro_local like @numLocal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", txtNombreLocal.Text);
                cmd.Parameters.AddWithValue("@numLocal", l.NumeroDeLocal);
                cmd.Parameters.AddWithValue("@id_local", cmbTipoLocal.SelectedValue);
                cmd.CommandType = CommandType.Text;
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


        private void cargarComboTipoLocal()
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {

                    SqlCommand cmd = new SqlCommand();


                    string consulta = "SELECT * FROM tipo_comercio";

                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    cmbTipoLocal.DataSource = tabla;
                    cmbTipoLocal.DisplayMember = "nombre_tipo_comercios";
                    cmbTipoLocal.ValueMember = "id_tipo_comercios";
                    cmbTipoLocal.SelectedIndex = -1;


                    
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

        private void btnModificarLocal_Click(object sender, EventArgs e)
        {
            Local a = ObtenerLocal(Convert.ToInt32(txtNumLocal.Text));

            bool res = ActualizarLocal(a);
            if (res)
            {
                MessageBox.Show("Local modificado con exito");
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo modificar");
            }
        }

        private void grillaLocales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int index = e.RowIndex;
                DataGridViewRow filaSeleccionada = grillaLocales.Rows[index];
                string num = filaSeleccionada.Cells["numLocal"].Value.ToString();
                Local a = ObtenerLocal(Convert.ToInt32(num));
                CargarCampos(a);
                btnModificarLocal.Enabled = true;
                txtNombreLocal.Enabled = true;
                txtNumLocal.Enabled = true;
                cmbTipoLocal.Enabled = true;
            }
        }

        private void CargarCampos(Local a)
        {
            txtNombreLocal.Text = a.NombreDeLocal.ToString();
            txtNumLocal.Text = a.NumeroDeLocal.ToString();
            cmbTipoLocal.SelectedValue = Convert.ToInt32(a.TipoDeLocal);
        }

        private Local ObtenerLocal(int numLocal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Local a = new Local();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM locales_comerciales lc, tipo_comercio tc WHERE nro_local like @numLocal AND lc.id_tipo_comercio = tc.id_tipo_comercios";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numLocal", numLocal);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    a.NombreDeLocal = Convert.ToString(dr["nombre_comercio"]);
                    a.NumeroDeLocal = Convert.ToInt32(dr["nro_local"]);
                    a.TipoDeLocal = Convert.ToInt32(dr["id_tipo_comercios"]);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cn.Close();
            }
            return a;
        }
    }
}
