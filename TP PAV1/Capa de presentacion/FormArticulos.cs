using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV1
{
    public partial class FormArticulos : Form
    {
        public FormArticulos()
        {
            InitializeComponent();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
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


                    string consulta = "SELECT * FROM articulos";

                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    grillaArticulos.DataSource = tabla;

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

        private void cargarGrillaFiltrada(String articulo)
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {

                    SqlCommand cmd = new SqlCommand();


                    string consulta = "SELECT * FROM articulos WHERE nombre_articulo = @articulo";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@articulo", articulo);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    grillaArticulos.DataSource = tabla;

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

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            AgregarArticulo ventana = new AgregarArticulo();
            ventana.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            ModificarArticulo ventana = new ModificarArticulo();
            ventana.Show();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            EliminarArticulo ventana = new EliminarArticulo();
            ventana.Show();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            if (txtNombreArticulo.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un articulo");
            }
            else
            {
                cargarGrillaFiltrada(txtNombreArticulo.Text);
                txtNombreArticulo.Text = "";
            }
        }

    }
}
