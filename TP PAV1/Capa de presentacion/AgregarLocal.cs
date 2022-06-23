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

namespace TP_PAV1
{
    public partial class AgregarLocal : Form
    {
        public AgregarLocal()
        {
            InitializeComponent();
        }

        private void btnAltaLocal_Click(object sender, EventArgs e)
        {
            if (txtNombreLocal.Text.Equals("") || txtNumLocal.Text.Equals("") || cmbTipoLocal.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar nombre y numero de local");
            }
            else
            {
                bool resultado = InsertarLocal(txtNombreLocal.Text,Convert.ToInt32(txtNumLocal.Text),cmbTipoLocal.SelectedIndex);
                if (resultado)
                {
                    MessageBox.Show("Local agregado con exito");
                    txtNombreLocal.Text = "";
                    txtNombreLocal.Focus();
                }
            }
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


        private bool InsertarLocal(string local, int nroLocal,int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO locales_comerciales (nombre_comercio,nro_local,id_tipo_comercio) VALUES (@nombre,@numero,@id_tipo_comercio)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", local);
                cmd.Parameters.AddWithValue("@numero", nroLocal);
                cmd.Parameters.AddWithValue("@id_tipo_comercio", id);
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

        private void AgregarLocal_Load(object sender, EventArgs e)
        {
            cargarComboTipoLocal();
        }
    }
}
