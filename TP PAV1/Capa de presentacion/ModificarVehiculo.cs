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
    public partial class ModificarVehiculo : Form
    {
        public ModificarVehiculo(Vehiculo Veh)
        {
            InitializeComponent();

            CargarCombosMarcas();
            CargarCombosTipoDocumento();
            CargarCombosTipoVehiculo();
            txtPatenteNueva.Text = Veh.patenteVehiculo;
            cmbTipoDoc.SelectedValue = Veh.tipoDocVehiculo;
            txtNroDoc.Text = Veh.nroDocVehiculo;
            cmbMarca.SelectedValue = Veh.modeloVehiculo;
            cmbTipo.SelectedValue = Veh.tipoVehiculo;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCombosTipoDocumento()
        {
            try
            {
                cmbTipoDoc.DataSource = AD_Varios.ObtenerTiposDeDocumentos();
                cmbTipoDoc.DisplayMember = "nombre_tipo_documento";
                cmbTipoDoc.ValueMember = "id_tipo_documento";
                cmbTipoDoc.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar combo tipo de documento");
            }
        }

        private void CargarCombosMarcas()
        {
            try
            {
                cmbMarca.DataSource = AD_Varios.ObtenerMarcas();
                cmbMarca.DisplayMember = "nombre_modelo_automovil";
                cmbMarca.ValueMember = "id_modelo_automovil";
                cmbMarca.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar combo marcas");
            }
        }

        private void CargarCombosTipoVehiculo()
        {
            try
            {
                cmbTipo.DataSource = AD_Varios.obtenerTipos();
                cmbTipo.DisplayMember = "nombre_tipo";
                cmbTipo.ValueMember = "id_tipo_vehiculo";
                cmbTipo.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar combo tipo de Vehiculo");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Vehiculo V = obtenerVehiculo();
            bool resultado = AD_Vehiculo.ActualizarVehiculoPorCliente(V);
            if (resultado)
            {
                MessageBox.Show("Vehiculo Modificada con Exito!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al modificar los datos");
            }
        }

        private Vehiculo obtenerVehiculo()
        {
            Vehiculo V = new Vehiculo();
            V.patenteVehiculo = txtPatenteNueva.Text.Trim();
            V.modeloVehiculo = (int)cmbMarca.SelectedValue;
            V.tipoVehiculo = (int)cmbTipo.SelectedValue;
            V.nroDocVehiculo = txtNroDoc.Text.Trim();
            V.tipoDocVehiculo = (int)cmbTipoDoc.SelectedValue;
            return V;
        }

        private void ModificarVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
