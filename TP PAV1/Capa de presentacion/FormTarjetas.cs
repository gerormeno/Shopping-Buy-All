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
    public partial class FormTarjetas : Form
    {
        public FormTarjetas()
        {
            InitializeComponent();
        }
        private void FormTarjetas_Load(object sender, EventArgs e)
        {
            LimpiarCamposAgregarTarjeta();
            LimpiarCamposBuscarTarjeta();
            LimpiarCamposModificarEliminarTarjeta();
            CargarGrilla();
        }

        //Metodos para cargar la grilla principal o la grilla filtrada para la busqueda
        private void CargarGrilla()
        {
            try
            {
                dgvTarjetas.DataSource = AD_Tarjetas.ObtenerTarjetasXTipoTarjeta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tarjetas");
            }
        }
        private void CargarGrillaBusqueda(string criterio)
        {
            try
            {
                dgvTarjetas.DataSource = AD_Tarjetas.BuscarTarjetasPorNombre(criterio);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener las tarjetas buscada");
            }
        }
        // --------------

        // metodos para limpiar campos del form
        private void LimpiarCamposBuscarTarjeta()
        {
            txtBuscarNombreTarjeta.Text = "";
        }
        private void LimpiarCamposModificarEliminarTarjeta()
        {
            txtNombreTarjeta.Text = "";
            txtIDTarjeta.Text = "";
            txtTipoTarjeta.Text = "";
        }
        private void LimpiarCamposAgregarTarjeta()
        {
            txtNombreNuevaTarjeta.Text = "";
            txtTipoNuevaTarjeta.Text = "";
            txtIDNuevaTarjeta.Text = "";
        }
        // --------------

        //Metodos para obtener los datos de los textbox de los campos agregar y modificar/eliminar
        private Tarjeta_credito ObtenerDatosTarjeta()
        {
            Tarjeta_credito t = new Tarjeta_credito();
            t.IdTarjeta = Convert.ToInt32(txtIDTarjeta.Text);
            t.NombreTarjeta = txtNombreTarjeta.Text.Trim();
            t.IdTipoTarjeta = Convert.ToInt32(txtTipoTarjeta.Text);
            return t;
        }
        private Tarjeta_credito ObtenerDatosNuevaTarjeta()
        {
            Tarjeta_credito t = new Tarjeta_credito();
            t.NombreTarjeta = txtNombreNuevaTarjeta.Text.Trim();
            t.IdTipoTarjeta = Convert.ToInt32(txtTipoNuevaTarjeta.Text);
            return t;
        }
        // --------------

        //eventos botones
        private void btnCrearTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta_credito t = ObtenerDatosNuevaTarjeta();
            bool res = AD_Tarjetas.InsertarTarjeta(t);

            if (res)
            {
                MessageBox.Show("La tarjeta fue agregada con exito");
                LimpiarCamposAgregarTarjeta();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar la tarjeta");
            }
        }
        private void btnBuscarTarjeta_Click(object sender, EventArgs e)
        {
            string criterio = Convert.ToString(txtBuscarNombreTarjeta.Text);
            CargarGrillaBusqueda(criterio);
            if (dgvTarjetas.RowCount.Equals(0))
            {
                MessageBox.Show("No se encontro ninguna tarjeta que coincida con el texto ingresado");
            }
        }
        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarCamposBuscarTarjeta();
        }
        private void btnEditarTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta_credito t = ObtenerDatosTarjeta();
            bool res = AD_Tarjetas.ActualizarTarjeta(t);
            if (res)
            {
                MessageBox.Show("La tarjeta fue modificada con exito");
                LimpiarCamposModificarEliminarTarjeta();
                CargarGrilla();
            }
        }
        private void btnEliminarTarjeta_Click(object sender, EventArgs e)
        {
            Tarjeta_credito t = ObtenerDatosTarjeta();
            bool res = AD_Tarjetas.EliminarTarjeta(t);
            if (res)
            {
                MessageBox.Show("La tarjeta fue eliminada con exito");
                LimpiarCamposModificarEliminarTarjeta();
                CargarGrilla();
            }
        }
        // --------------

        //Metodos para que cuando se empiece a cargar una nueva tarjeta se muestre el id que tendra

        private void txtNombreNuevaTarjeta_TextChanged(object sender, EventArgs e)
        {
            txtIDNuevaTarjeta.Text = Convert.ToString(AD_Tarjetas.ObtenerIDUltimaTarjeta());
        }
        private void txtTipoNuevaTarjeta_TextChanged(object sender, EventArgs e)
        {
            txtIDNuevaTarjeta.Text = Convert.ToString(AD_Tarjetas.ObtenerIDUltimaTarjeta());
        }



        private void dgvTarjetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEditarTarjeta.Enabled = true;
                btnEliminarTarjeta.Enabled = true;
                int indice = e.RowIndex;
                DataGridViewRow filaSelected = dgvTarjetas.Rows[indice];
                string id = filaSelected.Cells["ID"].Value.ToString();
                Tarjeta_credito tarjetaSelec = AD_Tarjetas.ObtenerTarjetaXID(Convert.ToInt32(id));
                LimpiarCamposModificarEliminarTarjeta();
                CargarCamposModifElim(tarjetaSelec);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una celda valida");
            }
        }


        private void CargarCamposModifElim(Tarjeta_credito t)
        {
            txtIDTarjeta.Text = Convert.ToString(t.IdTarjeta);
            txtNombreTarjeta.Text = t.NombreTarjeta;
            txtTipoTarjeta.Text = Convert.ToString(t.IdTipoTarjeta);
        }
    }
}
