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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelarNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarNuevoUsuario_Click(object sender, EventArgs e)
        {
            string UsuNuevo = txtUsuarioNuevo.Text.ToString();
            string ContraNuevo = txtContraseñaNuevo.Text.ToString();
            string ContraRepetirNuevo = txtRepetirContraseñaNuevo.Text.ToString();
            string CorreoNuevo = txtCorreoNuevo.Text.ToString();

            if (txtUsuarioNuevo.Text.Equals("") || txtContraseñaNuevo.Text.Equals("") || txtCorreoNuevo.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (ContraNuevo.Equals(ContraRepetirNuevo))
                {
                    bool resultado = AD_usuario.InsertarUsuario(UsuNuevo, ContraNuevo, CorreoNuevo);
                    if (resultado)
                    {
                        MessageBox.Show("Usuario Nuevo Agregado con Exito!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar nuevo usuario");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no Coiciden");
                }
            }
            
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
