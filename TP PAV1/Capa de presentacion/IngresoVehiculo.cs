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
    public partial class FormIngresoVehiculo : Form
    {
        public FormIngresoVehiculo()
        {
            InitializeComponent();
        }

        private void FormIngresoVehiculo_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboPlaya();
            CargarGrillaIngresos();
        }

        private void LimpiarCampos()
        {
            txtFecha.Text = "";
            txtNroEstacionamiento.Text = "";
            txtPatente.Text = "";
            cmbPlaya.SelectedItem = -1;
        }

        private void CargarComboPlaya()
        {
            try
            {
                cmbPlaya.DataSource = AD_PlayasYEstacionamientos.ObtenerPlayas();
                cmbPlaya.DisplayMember = "nombre_playa";
                cmbPlaya.ValueMember = "id_playa";
                cmbPlaya.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el combo");
            }
        }

        private void CargarGrillaIngresos()
        {
            dgvIngreso.DataSource = AD_RegistroEstacionamiento_Ingreso.ObtenerRegistros();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrillaIngresos();
        }

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();
            DataTable tablaAutos = AD_RegistroEstacionamiento_Ingreso.ObtenerVehiculoPorPatente(txtPatente.Text);
            if (tablaAutos.Rows.Count > 0)
            {
                //MessageBox.Show("si se encontro el auto");
                if (txtNroEstacionamiento.Text == "" || 
                    cmbPlaya.SelectedIndex == -1)
                {
                    MessageBox.Show("Recuerde que: \n - Ningún campo puede estar vacio." +
                        " \n - El formato de hora es 'hh:mm:ss'. ");
                }
                else
                {
                    bool ingresoExitoso = AD_RegistroEstacionamiento_Ingreso.RegistrarIngreso(
                        Convert.ToInt32(cmbPlaya.SelectedValue),
                        txtPatente.Text,
                        Convert.ToInt32(txtNroEstacionamiento.Text),
                        Convert.ToDateTime(txtFecha.Text)
                        );
                    if (ingresoExitoso)
                    {
                        MessageBox.Show("Ingreso registrado con éxito");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el ingreso. Intente nuevamente. ");
                    }
                }
            }
            else
            {
                MessageBox.Show("La patente ingresada no corresponde a ningun vehiculo " +
                    "dado de alta en el sistema");
            }
            
           
        }
    }
}
