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
    public partial class FormProfesiones : Form
    {
        public FormProfesiones()
        {
            InitializeComponent();
        }

        private void FormProfesiones_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            
            CargarGrilla();
           
        }

        private void LimpiarCampos()
        {
            txtProfesion.Text = "";

        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;

        }

        

        private void CargarGrilla()
        {
            try
            {
                grdProfesiones.DataSource = AD_Profesiones.ObtenerListadoProfesionesReducido();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener clientes");
            }

        }

        private void grdProfesiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar.Enabled = false;
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                

                DataGridViewRow filaSeleccionada = grdProfesiones.Rows[indice];
                string Profesion = filaSeleccionada.Cells["nombre_profesion"].Value.ToString();
                

                //Cliente c = AD_VariosXFede.ObtenerIdClienteXDocumento(nroDoc);

                LimpiarCampos();
                txtProfesion.Text = Profesion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Profesion prof = new Profesion();
            prof.nombreProfesion = txtProfesion.Text.Trim();

            bool resultado = AD_Profesiones.AgregaProfesionABD(prof);
            if (resultado)
            {
                MessageBox.Show("Cliente agregado correctamente");
                LimpiarCampos();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Profesion prof = new Profesion();
            prof.nombreProfesion = txtProfesion.Text.Trim();
            prof.id = int.Parse(grdProfesiones.CurrentRow.Cells["id_Profesiones"].Value.ToString());

            
            bool resultado = AD_Profesiones.ActualizarProfesion(prof);

            if (resultado)
            {
                MessageBox.Show("Profesion actualizada con exito");
                LimpiarCampos();
                CargarGrilla();
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;

               
                
            }
            else
            {
                MessageBox.Show("Error al actualizar Profesion");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Profesion prof = new Profesion();
            prof.nombreProfesion = txtProfesion.Text.Trim();
            prof.id = int.Parse(grdProfesiones.CurrentRow.Cells["id_Profesiones"].Value.ToString());
            string msjAlert = "Desea eliminar la Profesion: \n " + prof.nombreProfesion;

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBox.Show(msjAlert, "Error", buttons);


            bool resultado = AD_Profesiones.EliminarProfesion(prof);

            if (resultado)
            {
                MessageBox.Show("Cliente Eliminado exitosamente");
                LimpiarCampos();
                CargarGrilla();
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;


            }
            else
            {
                MessageBox.Show("Error al actualizar Cliente");
            }
        }
    }
    
    
}
