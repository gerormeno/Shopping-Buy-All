namespace TP_PAV1
{
    partial class FormPlayas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayas));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPlayas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPlaya = new System.Windows.Forms.ComboBox();
            this.txtPlaya = new System.Windows.Forms.TextBox();
            this.dgvEstacionamientos = new System.Windows.Forms.DataGridView();
            this.Estacionamientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPlaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarEstacionamiento = new System.Windows.Forms.Button();
            this.pnlEstacionamientos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEstacionamiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoEstacionamiento = new System.Windows.Forms.Button();
            this.pnlPlayas = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdPlayaSelect = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModificarPlaya = new System.Windows.Forms.Button();
            this.txtNombrePlayaSelect = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreNuevaPlaya = new System.Windows.Forms.TextBox();
            this.btnNuevaPlaya = new System.Windows.Forms.Button();
            this.btnBuscarPlaya = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarPlaya = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionamientos)).BeginInit();
            this.pnlEstacionamientos.SuspendLayout();
            this.pnlPlayas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Administrar playas y estacionamientos";
            // 
            // dgvPlayas
            // 
            this.dgvPlayas.AllowUserToAddRows = false;
            this.dgvPlayas.AllowUserToDeleteRows = false;
            this.dgvPlayas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPlayas.ColumnHeadersHeight = 28;
            this.dgvPlayas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre});
            this.dgvPlayas.Location = new System.Drawing.Point(259, 25);
            this.dgvPlayas.Name = "dgvPlayas";
            this.dgvPlayas.ReadOnly = true;
            this.dgvPlayas.RowHeadersVisible = false;
            this.dgvPlayas.RowHeadersWidth = 20;
            this.dgvPlayas.Size = new System.Drawing.Size(266, 279);
            this.dgvPlayas.TabIndex = 12;
            this.dgvPlayas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayas_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_playa";
            this.ID.HeaderText = "ID ";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre_playa";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // cmbPlaya
            // 
            this.cmbPlaya.FormattingEnabled = true;
            this.cmbPlaya.Location = new System.Drawing.Point(9, 61);
            this.cmbPlaya.Name = "cmbPlaya";
            this.cmbPlaya.Size = new System.Drawing.Size(238, 28);
            this.cmbPlaya.TabIndex = 13;
            this.cmbPlaya.SelectedIndexChanged += new System.EventHandler(this.cmbPlaya_SelectedIndexChanged);
            // 
            // txtPlaya
            // 
            this.txtPlaya.Location = new System.Drawing.Point(6, 46);
            this.txtPlaya.Name = "txtPlaya";
            this.txtPlaya.Size = new System.Drawing.Size(149, 26);
            this.txtPlaya.TabIndex = 15;
            // 
            // dgvEstacionamientos
            // 
            this.dgvEstacionamientos.AllowUserToAddRows = false;
            this.dgvEstacionamientos.AllowUserToDeleteRows = false;
            this.dgvEstacionamientos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEstacionamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstacionamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estacionamientos,
            this.IdPlaya});
            this.dgvEstacionamientos.Location = new System.Drawing.Point(259, 25);
            this.dgvEstacionamientos.Name = "dgvEstacionamientos";
            this.dgvEstacionamientos.ReadOnly = true;
            this.dgvEstacionamientos.RowHeadersVisible = false;
            this.dgvEstacionamientos.Size = new System.Drawing.Size(266, 278);
            this.dgvEstacionamientos.TabIndex = 16;
            this.dgvEstacionamientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstacionamientos_CellClick);
            // 
            // Estacionamientos
            // 
            this.Estacionamientos.DataPropertyName = "nro_estacionamiento";
            this.Estacionamientos.HeaderText = "Estacionamiento";
            this.Estacionamientos.Name = "Estacionamientos";
            this.Estacionamientos.ReadOnly = true;
            this.Estacionamientos.Width = 150;
            // 
            // IdPlaya
            // 
            this.IdPlaya.DataPropertyName = "id_playa";
            this.IdPlaya.HeaderText = "Playa";
            this.IdPlaya.Name = "IdPlaya";
            this.IdPlaya.ReadOnly = true;
            // 
            // btnEliminarEstacionamiento
            // 
            this.btnEliminarEstacionamiento.Enabled = false;
            this.btnEliminarEstacionamiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEliminarEstacionamiento.FlatAppearance.BorderSize = 0;
            this.btnEliminarEstacionamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnEliminarEstacionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstacionamiento.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEstacionamiento.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEstacionamiento.Image")));
            this.btnEliminarEstacionamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEstacionamiento.Location = new System.Drawing.Point(9, 253);
            this.btnEliminarEstacionamiento.Name = "btnEliminarEstacionamiento";
            this.btnEliminarEstacionamiento.Size = new System.Drawing.Size(238, 50);
            this.btnEliminarEstacionamiento.TabIndex = 18;
            this.btnEliminarEstacionamiento.Text = "            Eliminar estacionamiento";
            this.btnEliminarEstacionamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEstacionamiento.UseVisualStyleBackColor = false;
            this.btnEliminarEstacionamiento.Click += new System.EventHandler(this.btnEliminarEstacionamiento_Click);
            // 
            // pnlEstacionamientos
            // 
            this.pnlEstacionamientos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEstacionamientos.Controls.Add(this.label3);
            this.pnlEstacionamientos.Controls.Add(this.txtIdEstacionamiento);
            this.pnlEstacionamientos.Controls.Add(this.label1);
            this.pnlEstacionamientos.Controls.Add(this.btnNuevoEstacionamiento);
            this.pnlEstacionamientos.Controls.Add(this.btnEliminarEstacionamiento);
            this.pnlEstacionamientos.Controls.Add(this.cmbPlaya);
            this.pnlEstacionamientos.Controls.Add(this.dgvEstacionamientos);
            this.pnlEstacionamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEstacionamientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.pnlEstacionamientos.Location = new System.Drawing.Point(12, 48);
            this.pnlEstacionamientos.Name = "pnlEstacionamientos";
            this.pnlEstacionamientos.Size = new System.Drawing.Size(531, 310);
            this.pnlEstacionamientos.TabIndex = 24;
            this.pnlEstacionamientos.TabStop = false;
            this.pnlEstacionamientos.Text = "Estacionamientos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Estacionamiento seleccionado:";
            // 
            // txtIdEstacionamiento
            // 
            this.txtIdEstacionamiento.Enabled = false;
            this.txtIdEstacionamiento.Location = new System.Drawing.Point(9, 113);
            this.txtIdEstacionamiento.Name = "txtIdEstacionamiento";
            this.txtIdEstacionamiento.Size = new System.Drawing.Size(104, 26);
            this.txtIdEstacionamiento.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Seleccione playa:";
            // 
            // btnNuevoEstacionamiento
            // 
            this.btnNuevoEstacionamiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNuevoEstacionamiento.FlatAppearance.BorderSize = 0;
            this.btnNuevoEstacionamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnNuevoEstacionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEstacionamiento.ForeColor = System.Drawing.Color.White;
            this.btnNuevoEstacionamiento.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEstacionamiento.Image")));
            this.btnNuevoEstacionamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEstacionamiento.Location = new System.Drawing.Point(9, 197);
            this.btnNuevoEstacionamiento.Name = "btnNuevoEstacionamiento";
            this.btnNuevoEstacionamiento.Size = new System.Drawing.Size(238, 50);
            this.btnNuevoEstacionamiento.TabIndex = 25;
            this.btnNuevoEstacionamiento.Text = "            Nuevo estacionamiento";
            this.btnNuevoEstacionamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEstacionamiento.UseVisualStyleBackColor = false;
            this.btnNuevoEstacionamiento.Click += new System.EventHandler(this.btnNuevoEstacionamiento_Click);
            // 
            // pnlPlayas
            // 
            this.pnlPlayas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPlayas.Controls.Add(this.label8);
            this.pnlPlayas.Controls.Add(this.txtIdPlayaSelect);
            this.pnlPlayas.Controls.Add(this.label7);
            this.pnlPlayas.Controls.Add(this.btnModificarPlaya);
            this.pnlPlayas.Controls.Add(this.txtNombrePlayaSelect);
            this.pnlPlayas.Controls.Add(this.groupBox1);
            this.pnlPlayas.Controls.Add(this.btnBuscarPlaya);
            this.pnlPlayas.Controls.Add(this.label5);
            this.pnlPlayas.Controls.Add(this.btnEliminarPlaya);
            this.pnlPlayas.Controls.Add(this.label4);
            this.pnlPlayas.Controls.Add(this.dgvPlayas);
            this.pnlPlayas.Controls.Add(this.txtPlaya);
            this.pnlPlayas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPlayas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.pnlPlayas.Location = new System.Drawing.Point(12, 364);
            this.pnlPlayas.Name = "pnlPlayas";
            this.pnlPlayas.Size = new System.Drawing.Size(531, 310);
            this.pnlPlayas.TabIndex = 25;
            this.pnlPlayas.TabStop = false;
            this.pnlPlayas.Text = "Playas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(53, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "ID:";
            // 
            // txtIdPlayaSelect
            // 
            this.txtIdPlayaSelect.Enabled = false;
            this.txtIdPlayaSelect.Location = new System.Drawing.Point(86, 218);
            this.txtIdPlayaSelect.Name = "txtIdPlayaSelect";
            this.txtIdPlayaSelect.Size = new System.Drawing.Size(90, 26);
            this.txtIdPlayaSelect.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nombre:";
            // 
            // btnModificarPlaya
            // 
            this.btnModificarPlaya.Enabled = false;
            this.btnModificarPlaya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnModificarPlaya.FlatAppearance.BorderSize = 0;
            this.btnModificarPlaya.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnModificarPlaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPlaya.ForeColor = System.Drawing.Color.White;
            this.btnModificarPlaya.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarPlaya.Image")));
            this.btnModificarPlaya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPlaya.Location = new System.Drawing.Point(126, 254);
            this.btnModificarPlaya.Name = "btnModificarPlaya";
            this.btnModificarPlaya.Size = new System.Drawing.Size(109, 50);
            this.btnModificarPlaya.TabIndex = 37;
            this.btnModificarPlaya.Text = "Modificar";
            this.btnModificarPlaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPlaya.UseVisualStyleBackColor = false;
            this.btnModificarPlaya.Click += new System.EventHandler(this.btnModificarPlaya_Click);
            // 
            // txtNombrePlayaSelect
            // 
            this.txtNombrePlayaSelect.Location = new System.Drawing.Point(86, 186);
            this.txtNombrePlayaSelect.Name = "txtNombrePlayaSelect";
            this.txtNombrePlayaSelect.Size = new System.Drawing.Size(149, 26);
            this.txtNombrePlayaSelect.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreNuevaPlaya);
            this.groupBox1.Controls.Add(this.btnNuevaPlaya);
            this.groupBox1.Location = new System.Drawing.Point(6, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 106);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Playa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nombre:";
            // 
            // txtNombreNuevaPlaya
            // 
            this.txtNombreNuevaPlaya.Location = new System.Drawing.Point(80, 24);
            this.txtNombreNuevaPlaya.Name = "txtNombreNuevaPlaya";
            this.txtNombreNuevaPlaya.Size = new System.Drawing.Size(149, 26);
            this.txtNombreNuevaPlaya.TabIndex = 36;
            // 
            // btnNuevaPlaya
            // 
            this.btnNuevaPlaya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNuevaPlaya.FlatAppearance.BorderSize = 0;
            this.btnNuevaPlaya.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnNuevaPlaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaPlaya.ForeColor = System.Drawing.Color.White;
            this.btnNuevaPlaya.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaPlaya.Image")));
            this.btnNuevaPlaya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaPlaya.Location = new System.Drawing.Point(9, 56);
            this.btnNuevaPlaya.Name = "btnNuevaPlaya";
            this.btnNuevaPlaya.Size = new System.Drawing.Size(220, 40);
            this.btnNuevaPlaya.TabIndex = 29;
            this.btnNuevaPlaya.Text = "            Nueva playa";
            this.btnNuevaPlaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaPlaya.UseVisualStyleBackColor = false;
            this.btnNuevaPlaya.Click += new System.EventHandler(this.btnNuevaPlaya_Click);
            // 
            // btnBuscarPlaya
            // 
            this.btnBuscarPlaya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBuscarPlaya.FlatAppearance.BorderSize = 0;
            this.btnBuscarPlaya.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnBuscarPlaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPlaya.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPlaya.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPlaya.Image")));
            this.btnBuscarPlaya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPlaya.Location = new System.Drawing.Point(161, 46);
            this.btnBuscarPlaya.Name = "btnBuscarPlaya";
            this.btnBuscarPlaya.Size = new System.Drawing.Size(92, 26);
            this.btnBuscarPlaya.TabIndex = 34;
            this.btnBuscarPlaya.Text = "       Buscar";
            this.btnBuscarPlaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPlaya.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(149, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "ID:";
            // 
            // btnEliminarPlaya
            // 
            this.btnEliminarPlaya.Enabled = false;
            this.btnEliminarPlaya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEliminarPlaya.FlatAppearance.BorderSize = 0;
            this.btnEliminarPlaya.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnEliminarPlaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlaya.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPlaya.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarPlaya.Image")));
            this.btnEliminarPlaya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPlaya.Location = new System.Drawing.Point(9, 254);
            this.btnEliminarPlaya.Name = "btnEliminarPlaya";
            this.btnEliminarPlaya.Size = new System.Drawing.Size(104, 50);
            this.btnEliminarPlaya.TabIndex = 27;
            this.btnEliminarPlaya.Text = "Eliminar";
            this.btnEliminarPlaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPlaya.UseVisualStyleBackColor = false;
            this.btnEliminarPlaya.Click += new System.EventHandler(this.btnEliminarPlaya_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Buscar playa:";
            // 
            // FormPlayas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(555, 684);
            this.Controls.Add(this.pnlPlayas);
            this.Controls.Add(this.pnlEstacionamientos);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(555, 684);
            this.Name = "FormPlayas";
            this.Text = "FormPlayas";
            this.Load += new System.EventHandler(this.FormPlayas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionamientos)).EndInit();
            this.pnlEstacionamientos.ResumeLayout(false);
            this.pnlEstacionamientos.PerformLayout();
            this.pnlPlayas.ResumeLayout(false);
            this.pnlPlayas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPlayas;
        private System.Windows.Forms.ComboBox cmbPlaya;
        private System.Windows.Forms.TextBox txtPlaya;
        private System.Windows.Forms.DataGridView dgvEstacionamientos;
        private System.Windows.Forms.Button btnEliminarEstacionamiento;
        private System.Windows.Forms.GroupBox pnlEstacionamientos;
        private System.Windows.Forms.GroupBox pnlPlayas;
        private System.Windows.Forms.Button btnNuevoEstacionamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevaPlaya;
        private System.Windows.Forms.Button btnEliminarPlaya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarPlaya;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdEstacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estacionamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPlaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnModificarPlaya;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreNuevaPlaya;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdPlayaSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombrePlayaSelect;
    }
}