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
    public partial class ModificarUsuario : Form
    {
        public  ModificarUsuario(Usuarios U)
        {
           
            InitializeComponent();
            
            txtUsuarioNuevo.Text = U.UsuarioPersona.ToString();
            txtContraseñaNuevo.Text = U.contraseñaPersona.ToString();
            txtRepetirContraseñaNuevo.Text = U.contraseñaPersona.ToString();
            txtCorreoNuevo.Text = U.correoPersona.ToString();
            txtId.Text = U.IdPersona.ToString();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarModificacion_Click(object sender, EventArgs e)
        {
            Usuarios Usu = obtenerUsuario();
            bool resultado = AD_usuario.ActualizarUsuario(Usu);
            if (resultado)
            {
                MessageBox.Show("Persona Modificada con Exito!");
            }
            else
            {
                MessageBox.Show("Error al modificar los datos");
            }
        }

        private Usuarios obtenerUsuario()
        {
            Usuarios u = new Usuarios();
            u.UsuarioPersona = txtUsuarioNuevo.Text;
            u.IdPersona = Convert.ToInt32(txtId.Text);
            u.contraseñaPersona = txtContraseñaNuevo.Text;
            u.correoPersona = txtCorreoNuevo.Text;
            return u;
        }
    }
}
