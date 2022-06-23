using Microsoft.Reporting.WinForms;
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
    public partial class FormListados : Form
    {
        public FormListados()
        {
            InitializeComponent();
        }
                    
        private void FormListados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosTarjetasClientes.ListadoTarjetasPorCliente' Puede moverla o quitarla según sea necesario.
            this.ListadoTarjetasPorClienteTableAdapter.Fill(this.DatosTarjetasClientes.ListadoTarjetasPorCliente);
            // TODO: esta línea de código carga datos en la tabla 'TablasTPShopping.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.TablasTPShopping.clientes);
            // TODO: esta línea de código carga datos en la tabla 'DataSetRegistrosEstadias.GetRegistrosEstadiaEstacionamiento' Puede moverla o quitarla según sea necesario.
            this.GetRegistrosEstadiaEstacionamientoTableAdapter.Fill(this.DataSetRegistrosEstadias.GetRegistrosEstadiaEstacionamiento);
            // TODO: esta línea de código carga datos en la tabla 'gera2.ListadoArticulos' Puede moverla o quitarla según sea necesario.
            this.ListadoArticulosTableAdapter.Fill(this.gera2.ListadoArticulos);
            // TODO: esta línea de código carga datos en la tabla 'gera2.ListadoProfesionesXCliente' Puede moverla o quitarla según sea necesario.
            this.ListadoProfesionesXClienteTableAdapter.Fill(this.gera2.ListadoProfesionesXCliente);

            // TODO: esta línea de código carga datos en la tabla 'LocalesXTipoComercio.LocalesXTipoComercio' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
            this.reportViewer7.RefreshReport();
            this.reportViewer8.RefreshReport();
            this.reportViewer9.RefreshReport();
            this.reportViewer10.RefreshReport();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ArticuloXRubro.ObtenerArticuloXRubro();
            ReportDataSource ds = new ReportDataSource("ArticulosXRubro", tabla);

            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.DataSources.Add(ds);
            reportViewer3.LocalReport.Refresh();
        }

        private void reportViewer4_Load_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ArticuloXLocal.ObtenerArticuloXLocal();
            ReportDataSource ds = new ReportDataSource("ArticulosXLocal", tabla);

            reportViewer4.LocalReport.DataSources.Clear();
            reportViewer4.LocalReport.DataSources.Add(ds);
            reportViewer4.LocalReport.Refresh();
        }

        private void reportViewer5_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Varios.ObtenerProfesionesXCliente();
            ReportDataSource ds = new ReportDataSource("ProfesionesXCliente", tabla);

            reportViewer5.LocalReport.DataSources.Clear();
            reportViewer5.LocalReport.DataSources.Add(ds);
            reportViewer5.LocalReport.Refresh();
        }

        private void reportViewer6_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Varios.ObtenerListadoArticulos();
            ReportDataSource ds = new ReportDataSource("Articulos", tabla);

            reportViewer6.LocalReport.DataSources.Clear();
            reportViewer6.LocalReport.DataSources.Add(ds);
            reportViewer6.LocalReport.Refresh();
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Tarjetas.ObtenerTarjetasXcliente();
            ReportDataSource ds = new ReportDataSource("TarjetasXCliente", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void reportViewer2_Load_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Tarjetas.ObtenerVehiculosXcliente();
            ReportDataSource ds = new ReportDataSource("VehiculosXCliente", tabla);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.LocalReport.Refresh();
        }

        private void reportViewer8_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Cliente.obtenerClientesXBarrio();
            ReportDataSource ds = new ReportDataSource("ClientesXBarrio", tabla);

            reportViewer8.LocalReport.DataSources.Clear();
            reportViewer8.LocalReport.DataSources.Add(ds);
            reportViewer8.LocalReport.Refresh();
        }

        private void reportViewer9_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_VariosXFede.ObtenerRegistroEstadias();
            ReportDataSource ds = new ReportDataSource("RegistrosEstadias", tabla);

            reportViewer9.LocalReport.DataSources.Clear();
            reportViewer9.LocalReport.DataSources.Add(ds);
            reportViewer9.LocalReport.Refresh();
        }
    }
}
