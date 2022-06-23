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
using TP_PAV1.Entidades;

namespace TP_PAV1
{
    public partial class FormVentas : Form
    {
        bool ban = false;
        bool ban2 = false;
        Articulo art = new Articulo();
        int monto = 0;
       
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            CargarComboLocales();
            
        }

        Cliente Cli = new Cliente();





        private void CargarComboLocales()
        {
            try
            {
                cmbLocales.DataSource = AD_Varios.obtenerLocales();
                cmbLocales.DisplayMember = "nombre_comercio";
                cmbLocales.ValueMember = "nro_local";
                cmbLocales.SelectedIndex = -1;
                ban = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el combo locales");
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            
            Cli = AD_Cliente.ObtenerClienteXDNI(txtNroDni.Text);
            txtNombreCliente.Text = Cli.NombreCliente + " " +Cli.ApellidoCliente;
        }

        private void CargarComboArticulos()
        {
            try
            {
                cmbArticulos.DataSource = AD_Varios.obtenerArticulosPorLocal(Convert.ToInt32( cmbLocales.SelectedValue));
                cmbArticulos.DisplayMember = "nombre_articulo";
                cmbArticulos.ValueMember = "id_articulo";
                cmbArticulos.SelectedIndex = -1;
                ban2 = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el combo articulos");
            }
        }

        private void cmbLocales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocales.SelectedIndex != -1 && ban == true)
            {
                CargarComboArticulos();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cmbLocales.Enabled = false;
            txtNroDni.Enabled = false;
            string nomArticulo = art.NombreArticulo;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int precio = Convert.ToInt32(txtPrecio.Text);
            monto = monto + (cantidad * precio);
            txtMontoTotal.Text = monto.ToString();

            // Fila nueva
            DataGridViewRow fila = new DataGridViewRow();
            //Celda IdArt
            DataGridViewTextBoxCell celdaIdArt = new DataGridViewTextBoxCell();
            celdaIdArt.Value = art.Id_articulo;
            fila.Cells.Add(celdaIdArt);
            //Celda Articulo nombre
            DataGridViewTextBoxCell celdaArticulo = new DataGridViewTextBoxCell();
            celdaArticulo.Value = nomArticulo;
            fila.Cells.Add(celdaArticulo);
            DataGridViewTextBoxCell celdaCantidad = new DataGridViewTextBoxCell();
            celdaCantidad.Value = cantidad;
            fila.Cells.Add(celdaCantidad);
            DataGridViewTextBoxCell celdaPrecio = new DataGridViewTextBoxCell();
            celdaPrecio.Value = cantidad * precio;
            fila.Cells.Add(celdaPrecio);
            grillaArticulosAgregados.Rows.Add(fila);

            cmbArticulos.SelectedIndex = -1;
            txtPrecio.Text = "";
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ban2 == true)
            {
                art = AD_Varios.ObtenerArticuloPorId(Convert.ToInt32(cmbArticulos.SelectedValue));
                txtPrecio.Text = Convert.ToString(art.Precio_articulo);
            }
            
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<int> ListaArticulos = new List<int>();
            for (int i = 0; i < grillaArticulosAgregados.Rows.Count; i++)
            {
                ListaArticulos.Add(int.Parse(grillaArticulosAgregados.Rows[i].Cells[0].Value.ToString()));
            }


            bool resultado = AD_Ventas.altaNuevaCompra(ObtenerUltimaIdCompra(),(int)cmbLocales.SelectedValue,Cli.TipoDocumentoCliente,Cli.DocumentoCliente,DateTime.Now,monto,ListaArticulos,Convert.ToInt32(txtCantidad.Text));

            if (resultado)
            {
                MessageBox.Show("Completado!");
                monto = 0;
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private int ObtenerUltimaIdCompra()
        {
            int id = AD_Ventas.ObtenerUltimaCompra();
            return id + 1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            cmbLocales.SelectedIndex = -1;
            txtNroDni.Text = "";
            txtNombreCliente.Text = "";
            cmbArticulos.SelectedIndex = -1;
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            grillaArticulosAgregados.Rows.Clear();
            cmbLocales.Enabled = true;
            txtNroDni.Enabled = true;
            txtMontoTotal.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
