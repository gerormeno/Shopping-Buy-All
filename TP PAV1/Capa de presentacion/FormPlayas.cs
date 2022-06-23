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
    public partial class FormPlayas : Form
    {
        bool banderaCmb = false;

        public FormPlayas()
        {
            InitializeComponent();
        }


        // metodos para limpiar campos del form

        private void LimpiarCamposPnlEstacionamientos()
        {
            cmbPlaya.SelectedIndex = -1;
            txtIdEstacionamiento.Text = "";
        }

        private void LimpiarCamposPnlPlayas()
        {
            txtPlaya.Text = "";
        }

        private void LimpiarCamposPnlEditarPlaya()
        {
            txtNombrePlayaSelect.Text = "";
            txtIdPlayaSelect.Text = "";
        }

        private void FormPlayas_Load(object sender, EventArgs e)
        {
            LimpiarCamposPnlEstacionamientos();
            LimpiarCamposPnlPlayas();
            CargarComboPlaya();
            CargarGrillaPlayas();
        }

        private void btnNuevoEstacionamiento_Click(object sender, EventArgs e)
        {
            
            Estacionamiento est = TomarDatosNuevoEstacionamiento();
            bool resp = AD_PlayasYEstacionamientos.InsertarEstacionamiento(est);
            if (resp)
            {
                MessageBox.Show("El estacionamiento se ingreso correctamente");
                CargarGrillaEstacionamientos(Convert.ToInt32(cmbPlaya.SelectedValue));
                txtIdEstacionamiento.Text = "";
                
            }
            else
            {
                MessageBox.Show("Hubo un error al insertar el estacionamiento");
            }
        }


        private Estacionamiento TomarDatosNuevoEstacionamiento()
        {
            int idPlaya = Convert.ToInt32(cmbPlaya.SelectedValue);
            int idEstacionamiento = AD_PlayasYEstacionamientos.ObtenerIDUltimoEstacionamiento(idPlaya);
     
            Estacionamiento estacionamiento = new Estacionamiento();
            estacionamiento.IdPlaya = idPlaya;
            estacionamiento.IdEstacionamiento = idEstacionamiento;
            return estacionamiento;
        }


        private void CargarGrillaEstacionamientos(int idPlaya)
        {
            try
            {
                dgvEstacionamientos.DataSource = AD_PlayasYEstacionamientos.ObtenerEstacionamientosPorPlaya(idPlaya);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener estacionamientos");
            }
        }


        private void CargarGrillaPlayas()
        {
            try
            {
                dgvPlayas.DataSource = AD_PlayasYEstacionamientos.ObtenerPlayas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener estacionamientos");
            }
        }


        private void CargarComboPlaya()
        {
            try
            {
                cmbPlaya.DataSource = AD_PlayasYEstacionamientos.ObtenerPlayas();
                cmbPlaya.DisplayMember = "nombre_playa";
                cmbPlaya.ValueMember = "id_playa";
                cmbPlaya.SelectedIndex = -1;
                banderaCmb = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el combo");
            } 
        }


        private void cmbPlaya_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Convert.ToString(cmbPlaya.SelectedValue) != "") && (banderaCmb))
            {
                CargarGrillaEstacionamientos(Convert.ToInt32(cmbPlaya.SelectedValue));
                btnNuevoEstacionamiento.Enabled = true;
            }
        }


        private void btnEliminarEstacionamiento_Click(object sender, EventArgs e)
        {
            int idEst = Convert.ToInt32(txtIdEstacionamiento.Text);
            int idPlaya = Convert.ToInt32(cmbPlaya.SelectedValue);
            bool res = AD_PlayasYEstacionamientos.EliminarEstacionamiento(idEst, idPlaya);
            if (res)
            {
                MessageBox.Show("La tarjeta fue eliminada con exito");
                txtIdEstacionamiento.Text = "";
                CargarGrillaEstacionamientos(Convert.ToInt32(cmbPlaya.SelectedValue));
                btnEliminarEstacionamiento.Enabled = false;
            }
        }


        private void dgvEstacionamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEliminarEstacionamiento.Enabled = true;
                int indice = e.RowIndex;
                DataGridViewRow filaSelected = dgvEstacionamientos.Rows[indice];
                int id = Convert.ToInt32(filaSelected.Cells["Estacionamientos"].Value);
                int idPlaya = Convert.ToInt32(filaSelected.Cells["IdPlaya"].Value);
                Estacionamiento estSelec = AD_PlayasYEstacionamientos.ObtenerEstacionamientoXIDyPlaya(id,idPlaya);
                txtIdEstacionamiento.Text = "";
                txtIdEstacionamiento.Text = Convert.ToString(estSelec.IdEstacionamiento);             
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnNuevaPlaya_Click(object sender, EventArgs e)
        {
            Playa p = ObtenerDatosNuevaPlaya();
            bool res = AD_PlayasYEstacionamientos.InsertarPlaya(p);

            if (res)
            {
                MessageBox.Show("La playa fue agregada con exito");
                txtNombreNuevaPlaya.Text = "";
                CargarGrillaPlayas();
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar la playa");
            }
        }


        private Playa ObtenerDatosNuevaPlaya()
        {
            Playa p = new Playa();
            p.NombrePlaya = txtNombreNuevaPlaya.Text.Trim();
            return p;
        }


        private Playa ObtenerDatosPlayaSelected()
        {
            Playa p = new Playa();
            p.IdPlaya = Convert.ToInt32(txtIdPlayaSelect.Text);
            p.NombrePlaya = txtNombrePlayaSelect.Text.Trim();
            return p;
        }


        private void dgvPlayas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnModificarPlaya.Enabled = true;
                btnEliminarPlaya.Enabled = true;
                int indice = e.RowIndex;
                DataGridViewRow filaSelected = dgvPlayas.Rows[indice];
                string id = filaSelected.Cells[0].Value.ToString();
                Playa PlayaSelected = AD_PlayasYEstacionamientos.ObtenerPlayaXID(Convert.ToInt32(id));
                LimpiarCamposPnlEditarPlaya();
                CargarCamposPnlEditar(PlayaSelected);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una celda valida");
            }
        }


        private void CargarCamposPnlEditar(Playa p)
        {
            txtIdPlayaSelect.Text = Convert.ToString(p.IdPlaya);
            txtNombrePlayaSelect.Text = p.NombrePlaya;
        }

        private void btnModificarPlaya_Click(object sender, EventArgs e)
        {
            Playa p = ObtenerDatosPlayaSelected();
            bool res = AD_PlayasYEstacionamientos.ActualizarPlaya(p);
            if (res)
            {
                MessageBox.Show("La playa fue modificada con exito");
                LimpiarCamposPnlEditarPlaya();
                CargarGrillaPlayas();
            }
        }

        private void btnEliminarPlaya_Click(object sender, EventArgs e)
        {
            Playa p = ObtenerDatosPlayaSelected();
            //Eliminar todos los estacionamientos de la playa a eliminar
            bool res1 = AD_PlayasYEstacionamientos.EliminarEstacionamientosXPlaya(p.IdPlaya);
            //Eliminar la playa
            if (res1)
            {
                bool res2 = AD_PlayasYEstacionamientos.EliminarPlaya(p);
                if (res2)
                {
                    MessageBox.Show("La playa fue eliminada con exito");
                    LimpiarCamposPnlEditarPlaya();
                    CargarGrillaPlayas();
                    CargarGrillaEstacionamientos(Convert.ToInt32(cmbPlaya.SelectedValue));
                    CargarComboPlaya();
                }
            }
            
            
        }
    }
}
