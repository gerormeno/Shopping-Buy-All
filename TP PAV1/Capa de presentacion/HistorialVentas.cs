using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV1.AD;
using TP_PAV1.Entidades;



namespace TP_PAV1
{
    public partial class HistorialVentas : Form
    {
        public HistorialVentas()
        {
            InitializeComponent();
        }

        private void HistorialVentas_Load(object sender, EventArgs e)
        {
            CargarComboTiposDocumentos();

        }

        private void CargarComboTiposDocumentos()
        {

            try
            {
                cmbTipoDoc.DataSource = AD_Cliente.ObtenerTabla("tipo_documento");
                cmbTipoDoc.DisplayMember = "nombre_tipo_documento";
                cmbTipoDoc.ValueMember = "id_tipo_documento";
                cmbTipoDoc.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo tipo documento");
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string numero = txtNroDoc.Text;
            int tipoDoc = (int)(cmbTipoDoc.SelectedValue);

            Cliente cli = new Cliente();

            cli = AD_VariosXFede.ObtenerIdClienteXDocumento(numero, tipoDoc);

            txtNombre.Text = cli.NombreCliente;
            txtApellido.Text = cli.ApellidoCliente;


        }

        private void mostrarCompras_Click(object sender, EventArgs e)

        {

            string numero = txtNroDoc.Text;
            int tipoDoc = (int)(cmbTipoDoc.SelectedValue);
            //string desde = dateDesde.Text + "T00:00:00.000";
            string hasta = dateHasta.Text + " 23:59:59.000";
            string desde = dateDesde.Text;
            //string hasta = dateHasta.Text;

            DateTime Desde = Convert.ToDateTime(desde);
            DateTime Hasta = Convert.ToDateTime(hasta);
            

            
            {
                try
                {
                    grdCompras.DataSource = AD_HistorialVentas.ObtenerListadoHistorialCompras(numero, tipoDoc, Desde, Hasta);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al obtener clientes");
                }

                grdCompras.Columns[3].DefaultCellStyle.Format = "c2";
                grdCompras.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
                grdCompras.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }




        }

        private void grdCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grdCompras.Rows[indice];
            int nroCompra= Convert.ToInt32(filaSeleccionada.Cells["nro_compra"].Value.ToString());
            DialogResult r = MessageBox.Show("Desea mostrar el detalle", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {

                DetalleVenta ventana = new DetalleVenta(nroCompra);
                ventana.ShowDialog();

            }
        }
    }
}
