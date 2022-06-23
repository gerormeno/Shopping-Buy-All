using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV1
{
    public partial class MenuPrincipal : Form
    {
        Login LoginAnterior = new Login();
        public MenuPrincipal(Login VentanaLogin)
        {
            InitializeComponent();
            PersonalizarDiseño();

            LoginAnterior = VentanaLogin;
        }


        private void PersonalizarDiseño()
        {
            pnlClientesSubmenu.Visible = false;
            pnlComerciosSubmenu.Visible = false;
            pnlParkingSubmenu.Visible = false;
            pnlSistemaSubmenu.Visible = false;
        }

        // para esconder las opciones desplegables del menu
        private void EsconderSubmenu()
        {
            if (pnlClientesSubmenu.Visible==true)
            {
                pnlClientesSubmenu.Visible = false;
            }
            if (pnlComerciosSubmenu.Visible == true)
            {
                pnlComerciosSubmenu.Visible = false;
            }
            if (pnlParkingSubmenu.Visible == true)
            {
                pnlParkingSubmenu.Visible = false;
            }
            if (pnlSistemaSubmenu.Visible == true)
            {
                pnlSistemaSubmenu.Visible = false;
            }
        }

        // para mostrar las opciones desplegables del menu
        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                EsconderSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
                
            }
        }

        private Form formularioActivo = null;

        // para abrir un nuevo formulario (debe ir adentro del evento click de algun boton del menu):
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlFormularioHijo.Controls.Add(formularioHijo);
            pnlFormularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            EsconderSubmenu();
        }

        // eventos de los botones del menú:


        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnlClientesSubmenu);
            //codigo
        }

        private void btnComercios_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnlComerciosSubmenu);
            //codigo
        }

        private void btnParking_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnlParkingSubmenu);
            //codigo
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(pnlSistemaSubmenu);
            //codigo
        }

        private void btnABMClientes_Click(object sender, EventArgs e)
        {
            //nuestro codigo
            EsconderSubmenu();
            AbrirFormularioHijo(new FormClientes());
            this.Text = ("BUY ALL - ABM Clientes");
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            //nuestro codigo
            EsconderSubmenu();
            AbrirFormularioHijo(new FormTarjetas());
            this.Text = ("BUY ALL - Tarjetas de crédito");
        }

        private void btnProfesiones_Click(object sender, EventArgs e)
        {
            //nuestro codigo
            EsconderSubmenu();
            AbrirFormularioHijo(new FormProfesiones());
            this.Text = ("BUY ALL - Profesiones");
        }

        private void btnBarrios_Click(object sender, EventArgs e)
        {
            //nuestro codigo
            EsconderSubmenu();
            AbrirFormularioHijo(new FormBarrios());
            this.Text = ("BUY ALL - Barrios");
        }

        private void btnLocales_Click(object sender, EventArgs e)
        {
            //nuestro codigo
            EsconderSubmenu();
            AbrirFormularioHijo(new FormLocales());
            this.Text = ("BUY ALL - Locales");
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            //nuestro codigo
            EsconderSubmenu();
            AbrirFormularioHijo(new FormArticulos());
            this.Text = ("BUY ALL - Artículos");
        }

        private void btnPlayas_Click(object sender, EventArgs e)
        {
            //nuestro codigo
            EsconderSubmenu();
            AbrirFormularioHijo(new FormPlayas());
            this.Text = ("BUY ALL - Playas y Estacionamiento");
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            //nuestro codigo
            EsconderSubmenu();
            AbrirFormularioHijo(new FormVehiculos());
            this.Text = ("BUY ALL - Vehículos");
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //nuestro codigo
            EsconderSubmenu();
            AbrirFormularioHijo(new FormUsuarios());
            this.Text = ("BUY ALL - Usuarios");
        }

        private void btnCambiarContraseñas_Click(object sender, EventArgs e)
        {
            //nuestro codigo
            EsconderSubmenu();
            AbrirFormularioHijo(new FormCambiarContrasena());
            this.Text = ("BUY ALL - Cambiar contraseñas");
        }

        // no tocar jaja
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                Login ventana = new Login();
                ventana.Show();
                this.Close();
            }
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                
            }
        }

        private void btnCerrarSesionOK_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                Login ventana = new Login();
                ventana.Show();
                this.Close();
            }
        }

        private void btnSalirOK_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                LoginAnterior.Close();
                this.Close();
               
            }
        }
    }
}
