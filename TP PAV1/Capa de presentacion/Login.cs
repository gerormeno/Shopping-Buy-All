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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        public object AD_usuarios { get; private set; }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Complete todos los campos para poder ingresar");
            }
            else
            {
                String nombreUsuario = txtUsuario.Text;
                String Contraseña = txtContraseña.Text;
                bool resultado = false;
                try
                {
                    resultado = AD_usuario.ValidarUsuario(nombreUsuario, Contraseña);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar consultar usuario: " + ex.Message);
                }


                if (resultado)
                {
                    Usuarios U = AD_usuario.obtenerUsuarioPorNombre(nombreUsuario);
                    if (U.idPerfil ==1)
                    {
                        MenuPrincipal ventana = new MenuPrincipal(this);
                        ventana.Show();                      
                    }
                    else
                    {
                        if (U.idPerfil == 2)
                        {
                                MenuPrincipalLocal ventanaPrueba = new MenuPrincipalLocal(this);
                                ventanaPrueba.Show();
                        }
                        else
                        {

                        }

                    }
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario inexistente. Por favor intente nuevamente.");
                }
            }
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnIngresar.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
