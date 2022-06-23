namespace TP_PAV1
{
    partial class FormVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehiculos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PICBuscar = new System.Windows.Forms.PictureBox();
            this.txtBuscarPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaVehiculos = new System.Windows.Forms.DataGridView();
            this.patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICAgregarVehuciulo = new System.Windows.Forms.PictureBox();
            this.PICEliminarVehiculo = new System.Windows.Forms.PictureBox();
            this.PICModificarVehiculo = new System.Windows.Forms.PictureBox();
            this.PICActualizarGrilla = new System.Windows.Forms.PictureBox();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICAgregarVehuciulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICEliminarVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICModificarVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICActualizarGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PICBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarPatente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // PICBuscar
            // 
            this.PICBuscar.Image = ((System.Drawing.Image)(resources.GetObject("PICBuscar.Image")));
            this.PICBuscar.Location = new System.Drawing.Point(381, 21);
            this.PICBuscar.Name = "PICBuscar";
            this.PICBuscar.Size = new System.Drawing.Size(34, 28);
            this.PICBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBuscar.TabIndex = 2;
            this.PICBuscar.TabStop = false;
            this.PICBuscar.Click += new System.EventHandler(this.PICBuscar_Click);
            // 
            // txtBuscarPatente
            // 
            this.txtBuscarPatente.Location = new System.Drawing.Point(120, 24);
            this.txtBuscarPatente.Name = "txtBuscarPatente";
            this.txtBuscarPatente.Size = new System.Drawing.Size(242, 25);
            this.txtBuscarPatente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente";
            // 
            // GrillaVehiculos
            // 
            this.GrillaVehiculos.AllowUserToAddRows = false;
            this.GrillaVehiculos.AllowUserToDeleteRows = false;
            this.GrillaVehiculos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrillaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patente,
            this.tipo_modelo,
            this.tipo_vehiculo,
            this.tipo_dni,
            this.nro_dni});
            this.GrillaVehiculos.GridColor = System.Drawing.SystemColors.Control;
            this.GrillaVehiculos.Location = new System.Drawing.Point(13, 88);
            this.GrillaVehiculos.Name = "GrillaVehiculos";
            this.GrillaVehiculos.ReadOnly = true;
            this.GrillaVehiculos.RowHeadersWidth = 5;
            this.GrillaVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaVehiculos.Size = new System.Drawing.Size(507, 514);
            this.GrillaVehiculos.TabIndex = 1;
            this.GrillaVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaVehiculos_CellClick);
            // 
            // patente
            // 
            this.patente.DataPropertyName = "patente";
            this.patente.HeaderText = "Patente";
            this.patente.Name = "patente";
            this.patente.ReadOnly = true;
            // 
            // tipo_modelo
            // 
            this.tipo_modelo.DataPropertyName = "id_modelo_vehiculo";
            this.tipo_modelo.HeaderText = "Modelo";
            this.tipo_modelo.Name = "tipo_modelo";
            this.tipo_modelo.ReadOnly = true;
            // 
            // tipo_vehiculo
            // 
            this.tipo_vehiculo.DataPropertyName = "id_tipo_vehiculo";
            this.tipo_vehiculo.HeaderText = "Tipo";
            this.tipo_vehiculo.Name = "tipo_vehiculo";
            this.tipo_vehiculo.ReadOnly = true;
            // 
            // tipo_dni
            // 
            this.tipo_dni.DataPropertyName = "tipo_documento";
            this.tipo_dni.HeaderText = "Tipo DNI";
            this.tipo_dni.Name = "tipo_dni";
            this.tipo_dni.ReadOnly = true;
            // 
            // nro_dni
            // 
            this.nro_dni.DataPropertyName = "nro_documento";
            this.nro_dni.HeaderText = "Nro DNI";
            this.nro_dni.Name = "nro_dni";
            this.nro_dni.ReadOnly = true;
            // 
            // PICAgregarVehuciulo
            // 
            this.PICAgregarVehuciulo.Image = ((System.Drawing.Image)(resources.GetObject("PICAgregarVehuciulo.Image")));
            this.PICAgregarVehuciulo.Location = new System.Drawing.Point(13, 608);
            this.PICAgregarVehuciulo.Name = "PICAgregarVehuciulo";
            this.PICAgregarVehuciulo.Size = new System.Drawing.Size(40, 50);
            this.PICAgregarVehuciulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICAgregarVehuciulo.TabIndex = 2;
            this.PICAgregarVehuciulo.TabStop = false;
            this.PICAgregarVehuciulo.Click += new System.EventHandler(this.PICAgregarVehuciulo_Click);
            // 
            // PICEliminarVehiculo
            // 
            this.PICEliminarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("PICEliminarVehiculo.Image")));
            this.PICEliminarVehiculo.Location = new System.Drawing.Point(105, 608);
            this.PICEliminarVehiculo.Name = "PICEliminarVehiculo";
            this.PICEliminarVehiculo.Size = new System.Drawing.Size(40, 50);
            this.PICEliminarVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICEliminarVehiculo.TabIndex = 3;
            this.PICEliminarVehiculo.TabStop = false;
            this.PICEliminarVehiculo.Click += new System.EventHandler(this.PICEliminarVehiculo_Click);
            // 
            // PICModificarVehiculo
            // 
            this.PICModificarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("PICModificarVehiculo.Image")));
            this.PICModificarVehiculo.Location = new System.Drawing.Point(59, 608);
            this.PICModificarVehiculo.Name = "PICModificarVehiculo";
            this.PICModificarVehiculo.Size = new System.Drawing.Size(40, 50);
            this.PICModificarVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICModificarVehiculo.TabIndex = 4;
            this.PICModificarVehiculo.TabStop = false;
            this.PICModificarVehiculo.Click += new System.EventHandler(this.PICModificarVehiculo_Click);
            // 
            // PICActualizarGrilla
            // 
            this.PICActualizarGrilla.Image = ((System.Drawing.Image)(resources.GetObject("PICActualizarGrilla.Image")));
            this.PICActualizarGrilla.Location = new System.Drawing.Point(151, 608);
            this.PICActualizarGrilla.Name = "PICActualizarGrilla";
            this.PICActualizarGrilla.Size = new System.Drawing.Size(40, 50);
            this.PICActualizarGrilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICActualizarGrilla.TabIndex = 5;
            this.PICActualizarGrilla.TabStop = false;
            this.PICActualizarGrilla.Click += new System.EventHandler(this.PICActualizarGrilla_Click);
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataSource = typeof(TP_PAV1.Entidades.Vehiculo);
            // 
            // FormVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(555, 684);
            this.Controls.Add(this.PICActualizarGrilla);
            this.Controls.Add(this.PICModificarVehiculo);
            this.Controls.Add(this.PICEliminarVehiculo);
            this.Controls.Add(this.PICAgregarVehuciulo);
            this.Controls.Add(this.GrillaVehiculos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(555, 684);
            this.Name = "FormVehiculos";
            this.Text = "FormVehiculos";
            this.Load += new System.EventHandler(this.FormVehiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICAgregarVehuciulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICEliminarVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICModificarVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICActualizarGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PICBuscar;
        private System.Windows.Forms.TextBox txtBuscarPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaVehiculos;
        private System.Windows.Forms.PictureBox PICAgregarVehuciulo;
        private System.Windows.Forms.PictureBox PICEliminarVehiculo;
        private System.Windows.Forms.PictureBox PICModificarVehiculo;
        private System.Windows.Forms.PictureBox PICActualizarGrilla;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_dni;
    }
}