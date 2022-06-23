using TP_PAV1.DataSets;

namespace TP_PAV1
{
    partial class FormEstadistica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VentasPorClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProcedimientosVentasX = new TP_PAV1.DataSets.ProcedimientosVentasX();
            this.dataSetLocalesMasVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLocalesMasVentas = new TP_PAV1.DataSets.DataSetLocalesMasVentas();
            this.localescomercialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablasTPShopping = new TP_PAV1.DataSets.TablasTPShopping();
            this.LocalesXTipoComercioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LocalesXTipoComercio = new TP_PAV1.DataSets.LocalesXTipoComercio();
            this.TablaClientesXBarrioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetClientesXBarrio = new TP_PAV1.DataSets.DataSetClientesXBarrio();
            this.label2 = new System.Windows.Forms.Label();
            this.VentasPorClienteTableAdapter = new TP_PAV1.DataSets.ProcedimientosVentasXTableAdapters.VentasPorClienteTableAdapter();
            this.locales_comercialesTableAdapter = new TP_PAV1.DataSets.TablasTPShoppingTableAdapters.locales_comercialesTableAdapter();
            this.locales_comercialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LocalesXTipoComercioTableAdapter = new TP_PAV1.DataSets.LocalesXTipoComercioTableAdapters.LocalesXTipoComercioTableAdapter();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.reportViewer10 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.reportViewer9 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.reportViewer8 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.reportViewer7 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteCantidadArticulosPorTipo = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.VentasPorClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedimientosVentasX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocalesMasVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocalesMasVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localescomercialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasTPShopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalesXTipoComercioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalesXTipoComercio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientesXBarrioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientesXBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locales_comercialesBindingSource)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ReporteCantidadArticulosPorTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentasPorClienteBindingSource
            // 
            this.VentasPorClienteBindingSource.DataMember = "VentasPorCliente";
            this.VentasPorClienteBindingSource.DataSource = this.ProcedimientosVentasX;
            // 
            // ProcedimientosVentasX
            // 
            this.ProcedimientosVentasX.DataSetName = "ProcedimientosVentasX";
            this.ProcedimientosVentasX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetLocalesMasVentasBindingSource
            // 
            this.dataSetLocalesMasVentasBindingSource.DataSource = this.dataSetLocalesMasVentas;
            this.dataSetLocalesMasVentasBindingSource.Position = 0;
            this.dataSetLocalesMasVentasBindingSource.CurrentChanged += new System.EventHandler(this.dataSetLocalesMasVentasBindingSource_CurrentChanged);
            // 
            // dataSetLocalesMasVentas
            // 
            this.dataSetLocalesMasVentas.DataSetName = "DataSetLocalesMasVentas";
            this.dataSetLocalesMasVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localescomercialesBindingSource
            // 
            this.localescomercialesBindingSource.DataMember = "locales_comerciales";
            this.localescomercialesBindingSource.DataSource = this.tablasTPShopping;
            // 
            // tablasTPShopping
            // 
            this.tablasTPShopping.DataSetName = "TablasTPShopping";
            this.tablasTPShopping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LocalesXTipoComercioBindingSource
            // 
            this.LocalesXTipoComercioBindingSource.DataMember = "LocalesXTipoComercio";
            this.LocalesXTipoComercioBindingSource.DataSource = this.LocalesXTipoComercio;
            // 
            // LocalesXTipoComercio
            // 
            this.LocalesXTipoComercio.DataSetName = "LocalesXTipoComercio";
            this.LocalesXTipoComercio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TablaClientesXBarrioBindingSource
            // 
            this.TablaClientesXBarrioBindingSource.DataMember = "TablaClientesXBarrio";
            this.TablaClientesXBarrioBindingSource.DataSource = this.DataSetClientesXBarrio;
            // 
            // DataSetClientesXBarrio
            // 
            this.DataSetClientesXBarrio.DataSetName = "DataSetClientesXBarrio";
            this.DataSetClientesXBarrio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estadisticas";
            // 
            // VentasPorClienteTableAdapter
            // 
            this.VentasPorClienteTableAdapter.ClearBeforeFill = true;
            // 
            // locales_comercialesTableAdapter
            // 
            this.locales_comercialesTableAdapter.ClearBeforeFill = true;
            // 
            // locales_comercialesBindingSource
            // 
            this.locales_comercialesBindingSource.DataMember = "locales_comerciales";
            this.locales_comercialesBindingSource.DataSource = this.tablasTPShopping;
            // 
            // LocalesXTipoComercioTableAdapter
            // 
            this.LocalesXTipoComercioTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.reportViewer10);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(523, 592);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Ventas por barrio";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // reportViewer10
            // 
            this.reportViewer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer10.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteVentasXBarrio.rdlc";
            this.reportViewer10.Location = new System.Drawing.Point(3, 3);
            this.reportViewer10.Name = "reportViewer10";
            this.reportViewer10.ServerReport.BearerToken = null;
            this.reportViewer10.Size = new System.Drawing.Size(517, 586);
            this.reportViewer10.TabIndex = 0;
            this.reportViewer10.Load += new System.EventHandler(this.reportViewer10_Load);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.reportViewer9);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(523, 592);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Locales con mas ventas";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // reportViewer9
            // 
            this.reportViewer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer9.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteFedeCambiarNombreDespDeMerge.rdlc";
            this.reportViewer9.Location = new System.Drawing.Point(3, 3);
            this.reportViewer9.Name = "reportViewer9";
            this.reportViewer9.ServerReport.BearerToken = null;
            this.reportViewer9.Size = new System.Drawing.Size(517, 586);
            this.reportViewer9.TabIndex = 0;
            this.reportViewer9.Load += new System.EventHandler(this.reportViewer9_Load);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.reportViewer8);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(523, 592);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Cantidad de ventas por clientes";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // reportViewer8
            // 
            this.reportViewer8.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProcedimientosAlmacenados";
            reportDataSource1.Value = this.VentasPorClienteBindingSource;
            this.reportViewer8.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer8.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteCantVentasPorCliente.rdlc";
            this.reportViewer8.Location = new System.Drawing.Point(3, 3);
            this.reportViewer8.Name = "reportViewer8";
            this.reportViewer8.ServerReport.BearerToken = null;
            this.reportViewer8.Size = new System.Drawing.Size(517, 586);
            this.reportViewer8.TabIndex = 0;
            this.reportViewer8.Load += new System.EventHandler(this.reportViewer8_Load_1);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.reportViewer7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(523, 592);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Cantidad de ventas por articulo";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // reportViewer7
            // 
            this.reportViewer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer7.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteVentasPorArticulo.rdlc";
            this.reportViewer7.Location = new System.Drawing.Point(3, 3);
            this.reportViewer7.Name = "reportViewer7";
            this.reportViewer7.ServerReport.BearerToken = null;
            this.reportViewer7.Size = new System.Drawing.Size(517, 586);
            this.reportViewer7.TabIndex = 0;
            this.reportViewer7.Load += new System.EventHandler(this.reportViewer7_Load_1);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(523, 592);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Locales por rubro";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            this.reportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteComprasPorCliente.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(3, 3);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(517, 586);
            this.reportViewer6.TabIndex = 0;
            this.reportViewer6.Load += new System.EventHandler(this.reportViewer6_Load);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(523, 592);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Uso de playa";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "TP_PAV1.ListadoDePlayasMasUtilizados.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(517, 586);
            this.reportViewer5.TabIndex = 0;
            this.reportViewer5.Load += new System.EventHandler(this.reportViewer5_Load);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(523, 592);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cantidad de estacionamientos por playa";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "TP_PAV1.agus2.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(517, 586);
            this.reportViewer4.TabIndex = 0;
            this.reportViewer4.Load += new System.EventHandler(this.reportViewer4_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(523, 592);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cantidad articulos por local";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "TP_PAV1.agus1.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(517, 586);
            this.reportViewer3.TabIndex = 0;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehiculos por marcar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteCantidadVehiculosPorMarca.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(517, 586);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cantidad clientes por profesión";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteCantidadArticulosPorTipo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(517, 586);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteCantidadArticulosPorTipo
            // 
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage1);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage2);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage3);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage4);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage5);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage6);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage7);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage8);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage9);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage10);
            this.ReporteCantidadArticulosPorTipo.Location = new System.Drawing.Point(12, 54);
            this.ReporteCantidadArticulosPorTipo.Name = "ReporteCantidadArticulosPorTipo";
            this.ReporteCantidadArticulosPorTipo.SelectedIndex = 0;
            this.ReporteCantidadArticulosPorTipo.Size = new System.Drawing.Size(531, 618);
            this.ReporteCantidadArticulosPorTipo.TabIndex = 11;
            this.ReporteCantidadArticulosPorTipo.Tag = "";
            // 
            // FormEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(555, 640);
            this.Controls.Add(this.ReporteCantidadArticulosPorTipo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(555, 590);
            this.Name = "FormEstadistica";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasPorClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedimientosVentasX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocalesMasVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocalesMasVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localescomercialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasTPShopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalesXTipoComercioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalesXTipoComercio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientesXBarrioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientesXBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locales_comercialesBindingSource)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ReporteCantidadArticulosPorTipo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource VentasPorClienteBindingSource;
        private ProcedimientosVentasX ProcedimientosVentasX;
        private DataSets.ProcedimientosVentasXTableAdapters.VentasPorClienteTableAdapter VentasPorClienteTableAdapter;
        private TablasTPShopping tablasTPShopping;
        private System.Windows.Forms.BindingSource localescomercialesBindingSource;
        private DataSets.TablasTPShoppingTableAdapters.locales_comercialesTableAdapter locales_comercialesTableAdapter;
        private System.Windows.Forms.BindingSource dataSetLocalesMasVentasBindingSource;
        private DataSetLocalesMasVentas dataSetLocalesMasVentas;
        private System.Windows.Forms.BindingSource TablaClientesXBarrioBindingSource;
        private DataSetClientesXBarrio DataSetClientesXBarrio;
        private System.Windows.Forms.BindingSource locales_comercialesBindingSource;
        private System.Windows.Forms.BindingSource LocalesXTipoComercioBindingSource;
        private LocalesXTipoComercio LocalesXTipoComercio;
        private DataSets.LocalesXTipoComercioTableAdapters.LocalesXTipoComercioTableAdapter LocalesXTipoComercioTableAdapter;
        private System.Windows.Forms.TabPage tabPage10;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer10;
        private System.Windows.Forms.TabPage tabPage9;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer9;
        private System.Windows.Forms.TabPage tabPage8;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer8;
        private System.Windows.Forms.TabPage tabPage7;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer7;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabControl ReporteCantidadArticulosPorTipo;
    }
}