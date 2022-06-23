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
    public partial class EliminarArticulo : Form
    {
        public EliminarArticulo()
        {
            InitializeComponent();
        }

        private void EliminarArticulo_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            btnEliminarArticulo.Enabled = false;
            txtNombreArticulo.Enabled = false;
            txtId.Enabled = false;
        }
        private void CargarGrilla()
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
        private bool EliminarArticuloBD(Articulo a)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM articulos WHERE id_articulo like @id_articulo ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@articulo", txtNombreArticulo.Text);
                cmd.Parameters.AddWithValue("@id_articulo", a.Id_articulo);
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
        private void grillaArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaArticulos.Rows[index];
            string id = filaSeleccionada.Cells["idArticulo"].Value.ToString();
            Articulo a = ObtenerArticulo(Convert.ToInt32(id));
            CargarCampos(a);
            btnEliminarArticulo.Enabled = true;
            txtNombreArticulo.Enabled = true;
            txtId.Enabled = true;
        }

        private void CargarCampos(Articulo a)
        {
            txtNombreArticulo.Text = a.NombreArticulo.ToString();
            txtId.Text = a.Id_articulo.ToString();
        }

        private Articulo ObtenerArticulo(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Articulo a = new Articulo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM articulos WHERE id_articulo like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    a.NombreArticulo = Convert.ToString(dr["nombre_articulo"]);
                    a.Id_articulo = Convert.ToInt32(dr["id_articulo"]);
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

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            Articulo a = ObtenerArticulo(Convert.ToInt32(txtId.Text));

            bool res = EliminarArticuloBD(a);
            if (res)
            {
                MessageBox.Show("Persona eliminada con exito");
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

    }
}
