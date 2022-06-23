using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV1.AD;

namespace TP_PAV1
{
    public partial class FormBarrios : Form
    {
        public FormBarrios()
        {
            InitializeComponent();
        }
        private void FormBarrios_Load(object sender, EventArgs e)
        {
            LimpiarCamposPnlAgregarBarrio();
            LimpiarCampospnlBuscarBarrio();
            LimpiarCampospnlModificarEliminarBarrio();
            CargarGrilla();
        }

        // metodos para limpiar los campos del form
        private void LimpiarCampospnlBuscarBarrio()
        {
            txtBuscarNombreBarrio.Text = "";
        }
        private void LimpiarCampospnlModificarEliminarBarrio()
        {
            txtNombreBarrio.Text = "";
            txtIDBarrio.Text = "";
        }
        private void LimpiarCamposPnlAgregarBarrio()
        {
            txtNombreNuevoBarrio.Text = "";
        }
        // --------------

        // metodos para manejar la grilla
        private void CargarGrilla()
        {
            try
            {
                dgvBarrios.DataSource = AD_Barrios.ObtenerBarrios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener barrios de la base de datos. Intente nuevamente.");
            }
        }
        private void CargarGrillaBusqueda(string criterio)
        {
            try
            {
                dgvBarrios.DataSource = AD_Barrios.BuscarBarriosPorNombre(criterio);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener el barrio buscado. Intente nuevamente");
            }
        }
        // --------------

        //Metodos para obtener los datos de los textbox de los campos agregar y modificar/eliminar
        private Barrio ObtenerDatosBarrio()
        {
            Barrio b = new Barrio();
            b.IdBarrio = Convert.ToInt32(txtIDBarrio.Text);
            b.NombreBarrio = txtNombreBarrio.Text.Trim();
            return b;
        }
        private Barrio ObtenerDatosNuevoBarrio()
        {
            Barrio b = new Barrio();
            b.NombreBarrio = txtNombreNuevoBarrio.Text.Trim();
            return b;
        }
        // --------------

        //eventos botones
        private void btnCrearBarrio_Click(object sender, EventArgs e)
        {
            Barrio b = ObtenerDatosNuevoBarrio();
            bool res = AD_Barrios.InsertarBarrio(b);

            if (res)
            {
                MessageBox.Show("El nuevo barrio fue agregado con exito");
                LimpiarCamposPnlAgregarBarrio();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el barrio. Intente nuevamente.");
            }
        }
        private void btnBuscarBarrio_Click(object sender, EventArgs e)
        {
            string criterio = Convert.ToString(txtBuscarNombreBarrio.Text);
            CargarGrillaBusqueda(criterio);
            if (dgvBarrios.RowCount.Equals(0))
            {
                MessageBox.Show("No se encontro ningún barrio que coincida con el texto ingresado");
            }
        }
        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarCampospnlBuscarBarrio();
        }
        private void btnEditarBarrio_Click(object sender, EventArgs e)
        {
            Barrio b = ObtenerDatosBarrio();
            bool res = AD_Barrios.ActualizarBarrio(b);
            if (res)
            {
                MessageBox.Show("El barrio fue modificado con exito");
                LimpiarCampospnlModificarEliminarBarrio();
                CargarGrilla();
            }
        }
        private void btnEliminarBarrio_Click(object sender, EventArgs e)
        {
            Barrio b = ObtenerDatosBarrio();
            bool res = AD_Barrios.EliminarBarrio(b);
            if (res)
            {
                MessageBox.Show("El barrio fue eliminado con exito");
                LimpiarCampospnlModificarEliminarBarrio();
                CargarGrilla();
            }
        }
        // --------------

        //Metodos para que cuando se empiece a cargar un nuevo barrio se muestre el id que tendra
        private void txtNombreNuevoBarrio_TextChanged(object sender, EventArgs e)
        {
            txtIDNuevoBarrio.Text = Convert.ToString(AD_Barrios.ObtenerIDUltimoBarrio());
        }

        private void dgvBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEditarBarrio.Enabled = true;
                btnEliminarBarrio.Enabled = true;
                txtNombreBarrio.Enabled = true;
                int indice = e.RowIndex;
                DataGridViewRow filaSelected = dgvBarrios.Rows[indice];
                string id = filaSelected.Cells["ID"].Value.ToString();
                Barrio barrioSelec = AD_Barrios.ObtenerBarrioXID(Convert.ToInt32(id));
                LimpiarCampospnlModificarEliminarBarrio();
                CargarCamposModifElim(barrioSelec);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una celda valida");
            }
        }

        private void CargarCamposModifElim(Barrio b)
        {
            txtIDBarrio.Text = b.IdBarrio.ToString();
            txtNombreBarrio.Text = b.NombreBarrio.ToString();
        }

        // --------------



    }
}
