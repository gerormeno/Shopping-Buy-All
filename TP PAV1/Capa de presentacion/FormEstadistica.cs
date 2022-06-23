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
    public partial class FormEstadistica : Form
    {
        public FormEstadistica()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            FormBarrios b = new FormBarrios();
            b.Show();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tablasTPShopping.locales_comerciales' Puede moverla o quitarla según sea necesario.
            this.locales_comercialesTableAdapter.Fill(this.tablasTPShopping.locales_comerciales);
            // TODO: esta línea de código carga datos en la tabla 'ProcedimientosVentasX.VentasPorCliente' Puede moverla o quitarla según sea necesario.
            this.VentasPorClienteTableAdapter.Fill(this.ProcedimientosVentasX.VentasPorCliente);

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

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD.AD_Profesiones.obtenerCantClienteXProfesion();

            ReportDataSource ds = new ReportDataSource("ClientesXProfesiones", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD.AD_Vehiculo.obtenerCantVehiculosPorModelo();

            ReportDataSource ds = new ReportDataSource("VehiculosPorModelo", tabla);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.LocalReport.Refresh();

        }

        private void reportViewer6_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Varios.obtenerEstadisticasLocales();

            ReportDataSource ds = new ReportDataSource("DatosTiposLocal", tabla);

            reportViewer6.LocalReport.DataSources.Clear();
            reportViewer6.LocalReport.DataSources.Add(ds);
            reportViewer6.LocalReport.Refresh();
        }

        private void reportViewer7_Load_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Ventas.obtenerVentasPorArticulo();

            ReportDataSource ds = new ReportDataSource("ProcedimientosVentas", tabla);

            reportViewer7.LocalReport.DataSources.Clear();
            reportViewer7.LocalReport.DataSources.Add(ds);
            reportViewer7.LocalReport.Refresh();
        }

        private void reportViewer8_Load_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Ventas.obtenerVentasPorCliente();

            ReportDataSource ds = new ReportDataSource("ProcedimientosAlmacenados", tabla);

            //DataSet dts = new DataSet();
            reportViewer8.LocalReport.DataSources.Clear();
            reportViewer8.LocalReport.DataSources.Add(ds);
            reportViewer8.LocalReport.Refresh();
        }

        private void reportViewer5_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_RegistroEstacionamiento_Ingreso.ObtenerEstadisticasRegistros();
            ReportDataSource ds = new ReportDataSource("DatosRegistrosEstacionamiento", tabla);

            reportViewer5.LocalReport.DataSources.Clear();
            reportViewer5.LocalReport.DataSources.Add(ds);
            reportViewer5.LocalReport.Refresh();
        }

        private void reportViewer9_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Ventas.obtenerLocalesXMayorCompras();
            ReportDataSource ds = new ReportDataSource("LocalesMasVenta", tabla);

            reportViewer9.LocalReport.DataSources.Clear();
            reportViewer9.LocalReport.DataSources.Add(ds);
            reportViewer9.LocalReport.Refresh();
        }

        private void reportViewer10_Load(object sender, EventArgs e)
        {
            
            DataTable tabla = new DataTable();
            tabla = AD_Ventas.ObtenerVentasPorBarrio();
            ReportDataSource ds = new ReportDataSource("VentasXBarrio", tabla);

            reportViewer10.LocalReport.DataSources.Clear();
            reportViewer10.LocalReport.DataSources.Add(ds);
            reportViewer10.LocalReport.Refresh();
        }

        private void dataSetLocalesMasVentasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer3_Load_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ArticuloXLocal.ObtenerCantArticuloXLocal();
            ReportDataSource ds = new ReportDataSource("ArticulosXLocal", tabla);

            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.DataSources.Add(ds);
            reportViewer3.LocalReport.Refresh();
        }

        private void reportViewer4_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_PlayasYEstacionamientos.ObtenerCantEstacionamientosPorPlaya();
            ReportDataSource ds = new ReportDataSource("EstacionamientoXPlaya", tabla);

            reportViewer4.LocalReport.DataSources.Clear();
            reportViewer4.LocalReport.DataSources.Add(ds);
            reportViewer4.LocalReport.Refresh();
        }
    }
}