using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV1.AD;
using TP_PAV1.Entidades;

namespace TP_PAV1
{
    public partial class FormRegistroEgresos : Form
    {

        public FormRegistroEgresos()
        {
            InitializeComponent();

        }
        private void FormRegistroEgresos_Load(object sender, EventArgs e)
        {
            cargarGrillaEgresos();
        }

        private void cargarGrillaEgresos()
        {
            GrillaRegistroEgresos.DataSource = AD_RegistroEstacionamiento.ObtenerRegistros();
        }

        private void PICActualizarGrilla_Click(object sender, EventArgs e)
        {
            cargarGrillaEgresos();
        }

        private void PICBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtHoraSalida.Text = "";
                txtMonto.Text = "";
                DataTable tablaresultado = AD_RegistroEstacionamiento.ObtenerRegistroPorPatente(txtBuscarPatente.Text.Trim());
                if (tablaresultado.Rows.Count > 0)
                {
                    txtPlaya.Text = AD_RegistroEstacionamiento.ObtenerPlayaXID(Convert.ToInt32(tablaresultado.Rows[0][0])).ToString(); ;
                    txtNroEstacionamiento.Text = tablaresultado.Rows[0][1].ToString();
                    txtFecha.Text = (tablaresultado.Rows[0][3]).ToString();
                    txtHoraIngreso.Text = tablaresultado.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningun vehiculo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalcularMonto_Click(object sender, EventArgs e)
        {
            CalcularMonto();
        }

        public void CalcularMonto()
        {
            DateTime horaIngreso = DateTime.Parse(txtHoraIngreso.Text);
            int cantNum = Convert.ToInt32(txtHoraSalida.Text.Length.ToString());

            if (txtHoraSalida.Text.Equals("") || cantNum < 8 || Convert.ToDateTime(txtHoraSalida.Text) < horaIngreso)
            {
                MessageBox.Show("Recuerde que: \n -El campo 'Hora de salida' no puede estar vacio. \n -El formato de hora es 'hh:mm:ss'. \n -El horario de salida debe ser mayor al horario de ingreso.");
            }
            else
            {
                DateTime horaEgreso = DateTime.Parse(txtHoraSalida.Text);
                TimeSpan calculoHoras = horaEgreso - horaIngreso;

                string horaString = calculoHoras.ToString();
                int horaInt = Convert.ToInt32(horaString.Substring(0, 2));
                int minInt = Convert.ToInt32(horaString.Substring(3, 2));
                double montoMin = (minInt * 3.334);
                int montoHora = horaInt * 200;
                int montoTotal = Convert.ToInt32(montoHora + montoMin);
                txtMonto.Text = ("$ " + montoTotal).ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtBuscarPatente.Text.Equals("") || txtHoraSalida.Text.Equals(""))
            {
                MessageBox.Show("Algun campo se encuentra vacio");
            }
            else
            {
                DateTime horaIngreso = DateTime.Parse(txtHoraIngreso.Text);
                int cantNum = Convert.ToInt32(txtHoraSalida.Text.Length.ToString());

                if (txtHoraSalida.Text.Equals("") || cantNum < 8 || Convert.ToDateTime(txtHoraSalida.Text) < horaIngreso)
                {
                    MessageBox.Show("Recuerde que: \n -El campo 'Hora de salida' no puede estar vacio. \n -El formato de hora es 'hh:mm:ss'. \n -El horario de salida debe ser mayor al horario de ingreso.");
                }
                else
                {
                    string var = txtMonto.Text.Substring(1);
                    bool resulMonto = AD_RegistroEstacionamiento.InsertarMonto(Convert.ToInt32(var), txtBuscarPatente.Text);
                    TimeSpan horaEgreso = TimeSpan.Parse(txtHoraSalida.Text);
                    bool resul = AD_RegistroEstacionamiento.InsertarHoraHasta(horaEgreso, txtBuscarPatente.Text);
                    if (resul)
                    {

                        MessageBox.Show("Registro cargado correctamente");
                        cargarGrillaEgresos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cargar el registro");
                    }
                }



            }

        }
    }
}
