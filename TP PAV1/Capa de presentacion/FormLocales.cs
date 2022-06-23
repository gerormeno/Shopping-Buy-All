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
    public partial class FormLocales : Form
    {
        public FormLocales()
        {
            InitializeComponent();
        }

        private void FormLocales_Load(object sender, EventArgs e)
        {
            cargarGrilla();
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

        private void cargarGrillaFiltrada(string local)
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {

                    SqlCommand cmd = new SqlCommand();


                    string consulta = "SELECT locales_comerciales.nombre_comercio, locales_comerciales.nro_local, tipo_comercio.nombre_tipo_comercios FROM locales_comerciales INNER JOIN tipo_comercio ON locales_comerciales.id_tipo_comercio = tipo_comercio.id_tipo_comercios WHERE locales_comerciales.nombre_comercio = @nombre_comercio";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombre_comercio", local);
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

        private void agregarLocal_Click(object sender, EventArgs e)
        {
            AgregarLocal ventana = new AgregarLocal();
            ventana.Show();
        }

        private void modificarLocal_Click(object sender, EventArgs e)
        {
            ModificarLocal ventana = new ModificarLocal();
            ventana.Show();
        }

        private void eliminarLocal_Click(object sender, EventArgs e)
        {
            EliminarLocal ventana = new EliminarLocal();
            ventana.Show();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            if (buscarLocal.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un nombre o numero de local");
            }
            else
            {
                cargarGrillaFiltrada(buscarLocal.Text);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}
