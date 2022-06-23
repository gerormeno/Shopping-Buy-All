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
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnAltaArticulo_Click(object sender, EventArgs e)
        {
            if (txtNombreArticulo.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un articulo");
            }
            else
            {
                bool resultado = InsertarArticulo(txtNombreArticulo.Text);
                if (resultado)
                {
                    MessageBox.Show("Articulo agregado con exito");
                    txtNombreArticulo.Text = "";
                    txtNombreArticulo.Focus();
                }
            }
        }


        private bool InsertarArticulo(string articulo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO articulos (nombre_articulo) VALUES (@articulo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@articulo", articulo);
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
    }
}
