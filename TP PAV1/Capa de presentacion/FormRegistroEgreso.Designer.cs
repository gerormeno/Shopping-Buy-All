
namespace TP_PAV1
{
    partial class FormRegistroEgresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroEgresos));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.PICActualizarGrilla = new System.Windows.Forms.PictureBox();
            this.GrillaRegistroEgresos = new System.Windows.Forms.DataGridView();
            this.patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_playa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_estacionamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_estacionamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtPlaya = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNroEstacionamiento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnCalcularMonto = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoraIngreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PICBuscar = new System.Windows.Forms.PictureBox();
            this.txtBuscarPatente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICActualizarGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRegistroEgresos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcularMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 779);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Guardar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(351, 779);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Actualizar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(272, 721);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 49);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PICActualizarGrilla
            // 
            this.PICActualizarGrilla.Image = ((System.Drawing.Image)(resources.GetObject("PICActualizarGrilla.Image")));
            this.PICActualizarGrilla.Location = new System.Drawing.Point(354, 720);
            this.PICActualizarGrilla.Margin = new System.Windows.Forms.Padding(4);
            this.PICActualizarGrilla.Name = "PICActualizarGrilla";
            this.PICActualizarGrilla.Size = new System.Drawing.Size(55, 50);
            this.PICActualizarGrilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICActualizarGrilla.TabIndex = 37;
            this.PICActualizarGrilla.TabStop = false;
            this.PICActualizarGrilla.Click += new System.EventHandler(this.PICActualizarGrilla_Click);
            // 
            // GrillaRegistroEgresos
            // 
            this.GrillaRegistroEgresos.AllowUserToAddRows = false;
            this.GrillaRegistroEgresos.AllowUserToDeleteRows = false;
            this.GrillaRegistroEgresos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrillaRegistroEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaRegistroEgresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patente,
            this.id_playa,
            this.nro_estacionamiento,
            this.fecha_estacionamiento,
            this.hora_desde,
            this.hora_hasta,
            this.Monto});
            this.GrillaRegistroEgresos.GridColor = System.Drawing.SystemColors.Control;
            this.GrillaRegistroEgresos.Location = new System.Drawing.Point(13, 346);
            this.GrillaRegistroEgresos.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaRegistroEgresos.Name = "GrillaRegistroEgresos";
            this.GrillaRegistroEgresos.ReadOnly = true;
            this.GrillaRegistroEgresos.RowHeadersWidth = 5;
            this.GrillaRegistroEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaRegistroEgresos.Size = new System.Drawing.Size(682, 367);
            this.GrillaRegistroEgresos.TabIndex = 36;
            // 
            // patente
            // 
            this.patente.DataPropertyName = "patente";
            this.patente.HeaderText = "Patente";
            this.patente.MinimumWidth = 6;
            this.patente.Name = "patente";
            this.patente.ReadOnly = true;
            this.patente.Width = 125;
            // 
            // id_playa
            // 
            this.id_playa.DataPropertyName = "nombre_playa";
            this.id_playa.HeaderText = "Playa";
            this.id_playa.MinimumWidth = 6;
            this.id_playa.Name = "id_playa";
            this.id_playa.ReadOnly = true;
            this.id_playa.Width = 125;
            // 
            // nro_estacionamiento
            // 
            this.nro_estacionamiento.DataPropertyName = "nro_estacionamiento";
            this.nro_estacionamiento.HeaderText = "Nro Estacionamiento";
            this.nro_estacionamiento.MinimumWidth = 6;
            this.nro_estacionamiento.Name = "nro_estacionamiento";
            this.nro_estacionamiento.ReadOnly = true;
            this.nro_estacionamiento.Width = 115;
            // 
            // fecha_estacionamiento
            // 
            this.fecha_estacionamiento.DataPropertyName = "fecha_estacionamiento";
            this.fecha_estacionamiento.HeaderText = "Fecha";
            this.fecha_estacionamiento.MinimumWidth = 6;
            this.fecha_estacionamiento.Name = "fecha_estacionamiento";
            this.fecha_estacionamiento.ReadOnly = true;
            this.fecha_estacionamiento.Width = 125;
            // 
            // hora_desde
            // 
            this.hora_desde.DataPropertyName = "hora_desde";
            this.hora_desde.HeaderText = "Hora ingreso";
            this.hora_desde.MinimumWidth = 6;
            this.hora_desde.Name = "hora_desde";
            this.hora_desde.ReadOnly = true;
            this.hora_desde.Width = 125;
            // 
            // hora_hasta
            // 
            this.hora_hasta.DataPropertyName = "hora_hasta";
            this.hora_hasta.HeaderText = "Hora Salida";
            this.hora_hasta.MinimumWidth = 6;
            this.hora_hasta.Name = "hora_hasta";
            this.hora_hasta.ReadOnly = true;
            this.hora_hasta.Width = 125;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtPlaya);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNroEstacionamiento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.btnCalcularMonto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHoraSalida);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHoraIngreso);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PICBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarPatente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(17, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(676, 341);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de egreso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(497, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Monto";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(289, 99);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(66, 25);
            this.txtFecha.TabIndex = 23;
            // 
            // txtPlaya
            // 
            this.txtPlaya.Enabled = false;
            this.txtPlaya.Location = new System.Drawing.Point(108, 168);
            this.txtPlaya.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaya.Name = "txtPlaya";
            this.txtPlaya.Size = new System.Drawing.Size(159, 25);
            this.txtPlaya.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(51, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Playa:";
            // 
            // txtNroEstacionamiento
            // 
            this.txtNroEstacionamiento.Enabled = false;
            this.txtNroEstacionamiento.Location = new System.Drawing.Point(489, 168);
            this.txtNroEstacionamiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroEstacionamiento.Name = "txtNroEstacionamiento";
            this.txtNroEstacionamiento.Size = new System.Drawing.Size(37, 25);
            this.txtNroEstacionamiento.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(293, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nro de estacionamiento:";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(463, 275);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(133, 25);
            this.txtMonto.TabIndex = 18;
            // 
            // btnCalcularMonto
            // 
            this.btnCalcularMonto.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularMonto.Image")));
            this.btnCalcularMonto.Location = new System.Drawing.Point(392, 269);
            this.btnCalcularMonto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularMonto.Name = "btnCalcularMonto";
            this.btnCalcularMonto.Size = new System.Drawing.Size(53, 45);
            this.btnCalcularMonto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCalcularMonto.TabIndex = 17;
            this.btnCalcularMonto.TabStop = false;
            this.btnCalcularMonto.Click += new System.EventHandler(this.btnCalcularMonto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(392, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Calcular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hora de salida: ";
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(172, 286);
            this.txtHoraSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(95, 25);
            this.txtHoraSalida.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(235, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hora de ingreso: ";
            // 
            // txtHoraIngreso
            // 
            this.txtHoraIngreso.Enabled = false;
            this.txtHoraIngreso.Location = new System.Drawing.Point(172, 243);
            this.txtHoraIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoraIngreso.Name = "txtHoraIngreso";
            this.txtHoraIngreso.Size = new System.Drawing.Size(95, 25);
            this.txtHoraIngreso.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Patente";
            // 
            // PICBuscar
            // 
            this.PICBuscar.Image = ((System.Drawing.Image)(resources.GetObject("PICBuscar.Image")));
            this.PICBuscar.Location = new System.Drawing.Point(489, 26);
            this.PICBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.PICBuscar.Name = "PICBuscar";
            this.PICBuscar.Size = new System.Drawing.Size(58, 48);
            this.PICBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBuscar.TabIndex = 2;
            this.PICBuscar.TabStop = false;
            this.PICBuscar.Click += new System.EventHandler(this.PICBuscar_Click);
            // 
            // txtBuscarPatente
            // 
            this.txtBuscarPatente.Location = new System.Drawing.Point(160, 42);
            this.txtBuscarPatente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPatente.Name = "txtBuscarPatente";
            this.txtBuscarPatente.Size = new System.Drawing.Size(321, 25);
            this.txtBuscarPatente.TabIndex = 1;
            // 
            // FormRegistroEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(722, 795);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.PICActualizarGrilla);
            this.Controls.Add(this.GrillaRegistroEgresos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistroEgresos";
            this.Text = "FormRegistroEgreso";
            this.Load += new System.EventHandler(this.FormRegistroEgresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICActualizarGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRegistroEgresos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcularMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.PictureBox PICActualizarGrilla;
        private System.Windows.Forms.DataGridView GrillaRegistroEgresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_playa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_estacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_estacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtPlaya;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNroEstacionamiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.PictureBox btnCalcularMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoraIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PICBuscar;
        private System.Windows.Forms.TextBox txtBuscarPatente;
    }
}