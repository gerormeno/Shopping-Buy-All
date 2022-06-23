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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        Usuarios Usu = new Usuarios();
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            grillaUsuarios.ClearSelection();
            cargarGrilla();
                   
        }
        private void cargarGrilla()
        {
            grillaUsuarios.DataSource = AD_usuario.obtenerUsuarios();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AgregarUsuario ventanaAgregarUsuario = new AgregarUsuario();
            ventanaAgregarUsuario.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void grillaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaUsuarios.Rows[indice];
            string Usuario = filaSeleccionada.Cells["usuario"].Value.ToString();
            Usu = AD_usuario.obtenerUsuarioPorNombre(Usuario);
            
        }

        private void PICborrar_Click(object sender, EventArgs e)
        {
            DialogResult r=  MessageBox.Show("Estas seguro que deseas borrar el usuario " + Usu.UsuarioPersona, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == r)
            {
                AD_usuario.EliminarUsuario(Usu.UsuarioPersona);
            }
        }

        private void PICeditar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que deseas Modificar el usuario " + Usu.UsuarioPersona, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == r)
            {
                ModificarUsuario VentanaModificarUsuario = new ModificarUsuario(Usu);
                VentanaModificarUsuario.Show();
            }

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            grillaUsuarios.DataSource = AD_usuario.CargarUsuariosPorNombre(txtBuscarUsuarioNombre.Text);
        }
    }
    
}
