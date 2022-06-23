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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            CargarComboTiposDocumentos();
            CargarComboBarrios();
            CargarGrilla();
            cmbTipoDoc.Enabled = true;
            txtNroDoc.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNacimiento.Text = "";

            txtNroDoc.Text = "";

            rdBtnMasculino.Checked = false;
            rdBtnFemenino.Checked = false;
            rdBtnFemenino.Checked = false;

            txtCalle.Text = "";
            txtNroDomicilio.Text = "";

            rdBtnSoltero.Checked = false;
            rdBtnCasado.Checked = false;
            cmbBarrio.SelectedIndex = -1;

          
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnEliminar.Enabled = false;
            btnAgregarCliente.Enabled = true;
            cmbTipoDoc.Enabled = true;
            txtNroDoc.Enabled = true;

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

        private void CargarComboBarrios()
        {
            try
            {
                cmbBarrio.DataSource = AD_Cliente.ObtenerTabla("barrios");
                cmbBarrio.DisplayMember = "nombre_barrio";
                cmbBarrio.ValueMember = "id_barrio";
                cmbBarrio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo barrios");
            }
        }

        private void CargarGrilla()
        {
            try
            {
                grdClientes.DataSource = AD_Cliente.ObtenerListadoClientesReducido();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener clientes");
            }

        }

        private Cliente ObtenerDatosCliente()
        {
           
            Cliente c = new Cliente();
            c.NombreCliente = txtNombre.Text.Trim();
            c.ApellidoCliente = txtApellido.Text.Trim();
            c.FechaNacimientoCliente = DateTime.Parse(txtFechaNacimiento.Text);

            c.TipoDocumentoCliente = (int)(cmbTipoDoc.SelectedValue);
            c.DocumentoCliente = txtNroDoc.Text.Trim();

            if (rdBtnFemenino.Checked)
            {
                c.SexoCliente = 1;
            }
            else if (rdBtnMasculino.Checked)
            {
                c.SexoCliente = 2;
            }
            else if (rdBtnOtro.Checked)
            {
                c.SexoCliente = 3;
            }

            c.BarrioCliente = (int)(cmbBarrio.SelectedValue);
            c.CalleCliente = txtCalle.Text.Trim();
            c.NroCasaCliente = int.Parse(txtNroDomicilio.Text.Trim());

            if (rdBtnSoltero.Checked)
            {
                c.EstadoCivilCliente = 1;
            }
            else if (rdBtnCasado.Checked)
            {
                c.EstadoCivilCliente = 2;
            }
            
            return c;
        }

        private string validarCampos()
        {
            string encabezado = "Los siguientes campos deben ser completados:\n";
            string resultado = "";

            if(txtNombre.Text == "")
            {
                resultado += "- Nombre\n";
            };
            
            if(txtApellido.Text == "")
            {
                resultado += "- Apellido\n";
            };
           
            if (txtFechaNacimiento.Text == "  /  /")
            {
                resultado += "- Fecha de nacimiento\n";
            }

            if (cmbTipoDoc.SelectedIndex == -1)
                {
                    resultado += "- Tipo de documento\n";
                };

            if (txtNroDoc.Text == "")
            {
                resultado += "- Numero de documento\n";
            }

           
            if(!rdBtnFemenino.Checked && !rdBtnMasculino.Checked && !rdBtnOtro.Checked)
            {
                resultado += "- Sexo\n";
            }
            
            if (cmbBarrio.SelectedIndex == -1)
            {
                resultado += "- Barrio\n";
            }

            if (txtCalle.Text == "")
            {
                resultado += "- Calle\n";
            }

            if (txtNroDomicilio.Text == "")
            {
                resultado += "- Numero de domicilio\n";
            }
         
            if (!rdBtnSoltero.Checked && !rdBtnCasado.Checked)
            {
                resultado += "- Estado civil\n";
            }

            if(resultado != "")
            {
                encabezado += resultado;
                resultado = encabezado;
            }

            return resultado;

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            string validacionResultado = validarCampos();
            if (validacionResultado != "")
            {
                MessageBox.Show(validacionResultado, "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cliente c = ObtenerDatosCliente();
            bool resultado = AD_VariosXFede.AgregaClienteABD(c);
            if (resultado)
            {
                MessageBox.Show("Cliente agregado correctamente");
                LimpiarCampos();
                CargarComboBarrios();
                CargarComboTiposDocumentos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente");
            }
        }

        private void grdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnAgregarCliente.Enabled = false;
                cmbTipoDoc.Enabled = false;
                txtNroDoc.Enabled = false;


                DataGridViewRow filaSeleccionada = grdClientes.Rows[indice];
                string nroDoc = filaSeleccionada.Cells["nroDoc"].Value.ToString();
                int tipoDoc = int.Parse(filaSeleccionada.Cells["tipoDoc"].Value.ToString());

                Cliente c = AD_VariosXFede.ObtenerIdClienteXDocumento(nroDoc, tipoDoc);

                LimpiarCampos();
                CargarCampos(c);
            }
        }

        private void CargarCampos(Cliente c)
        {
            txtNombre.Text = c.NombreCliente;
            txtApellido.Text = c.ApellidoCliente;
            DateTime fecha = c.FechaNacimientoCliente;
            string dia = "";
            string mes = "";
            string año = "";
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();
            txtFechaNacimiento.Text = dia + mes + año;

            cmbTipoDoc.SelectedValue = c.TipoDocumentoCliente;
            txtNroDoc.Text = c.DocumentoCliente;

            if (c.SexoCliente == 1)
            {
                rdBtnFemenino.Checked = true;
            }
            else if (c.SexoCliente == 2)
            {
                rdBtnMasculino.Checked = true;
            }
            else
            {
                rdBtnOtro.Checked = true;
            }

            cmbBarrio.SelectedValue = c.BarrioCliente;
            txtCalle.Text = c.CalleCliente;
            txtNroDomicilio.Text = c.NroCasaCliente.ToString();
            

            if (c.EstadoCivilCliente == 1)
            {
                rdBtnSoltero .Checked = true;
            }
            else if(c.EstadoCivilCliente == 2)
            {
                rdBtnCasado.Checked = true;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string validacionResultado = validarCampos();
            if (validacionResultado != "")
            {
                MessageBox.Show(validacionResultado, "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string doc = grdClientes.CurrentRow.Cells["nroDoc"].Value.ToString();
            string tipoDoc = grdClientes.CurrentRow.Cells["tipoDoc"].Value.ToString();
            Cliente cli = ObtenerDatosCliente();
            bool resultado = AD_Cliente.ActualizarCliente(cli);

            if (resultado)
            {
                MessageBox.Show("Cliente actualizado con exito");
                LimpiarCampos();
                CargarGrilla();
               
                CargarComboTiposDocumentos();
                btnActualizar.Enabled = false;
                btnAgregarCliente.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al actualizar Cliente");
            }
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            Cliente c = ObtenerDatosCliente();
            string msjAlert = "Desea eliminar el cliente: \n " + c.ApellidoCliente + " " + c.NombreCliente + " Tipo y nro de doc.: " + c.TipoDocumentoCliente + " " + c.DocumentoCliente;
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBox.Show(msjAlert ,"Error", buttons);
            

            bool resultado = AD_Cliente.EliminarCliente(c);

            if (resultado)
            {
                MessageBox.Show("Cliente Eliminado exitosamente");
                LimpiarCampos();
                CargarGrilla();

                CargarComboTiposDocumentos();
                btnActualizar.Enabled = false;
                btnAgregarCliente.Enabled = true;
                btnEliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al eliminar el Cliente");
            }
        }
    }

}
