namespace TP_PAV1
{
    partial class FormTarjetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarjetas));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBuscarTarjeta = new System.Windows.Forms.GroupBox();
            this.btnCancelarBusqueda = new System.Windows.Forms.Button();
            this.btnBuscarTarjeta = new System.Windows.Forms.Button();
            this.txtBuscarNombreTarjeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlModificarEliminarTarjeta = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipoTarjeta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDTarjeta = new System.Windows.Forms.TextBox();
            this.txtNombreTarjeta = new System.Windows.Forms.TextBox();
            this.btnEditarTarjeta = new System.Windows.Forms.Button();
            this.btnEliminarTarjeta = new System.Windows.Forms.Button();
            this.pnlAgregarTarjeta = new System.Windows.Forms.GroupBox();
            this.txtTipoNuevaTarjeta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDNuevaTarjeta = new System.Windows.Forms.TextBox();
            this.txtNombreNuevaTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrearTarjeta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.pnlBuscarTarjeta.SuspendLayout();
            this.pnlModificarEliminarTarjeta.SuspendLayout();
            this.pnlAgregarTarjeta.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(297, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Administrar tarjetas de crédito";
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Tipo});
            this.dgvTarjetas.Location = new System.Drawing.Point(294, 57);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.ReadOnly = true;
            this.dgvTarjetas.Size = new System.Drawing.Size(249, 615);
            this.dgvTarjetas.TabIndex = 5;
            this.dgvTarjetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarjetas_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_tarjeta";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre_tarjeta";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "nombre_tipo_tarjeta";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // pnlBuscarTarjeta
            // 
            this.pnlBuscarTarjeta.Controls.Add(this.btnCancelarBusqueda);
            this.pnlBuscarTarjeta.Controls.Add(this.btnBuscarTarjeta);
            this.pnlBuscarTarjeta.Controls.Add(this.txtBuscarNombreTarjeta);
            this.pnlBuscarTarjeta.Controls.Add(this.label1);
            this.pnlBuscarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBuscarTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.pnlBuscarTarjeta.Location = new System.Drawing.Point(12, 48);
            this.pnlBuscarTarjeta.Name = "pnlBuscarTarjeta";
            this.pnlBuscarTarjeta.Size = new System.Drawing.Size(276, 151);
            this.pnlBuscarTarjeta.TabIndex = 6;
            this.pnlBuscarTarjeta.TabStop = false;
            this.pnlBuscarTarjeta.Text = "Buscar";
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCancelarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnCancelarBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnCancelarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarBusqueda.Image")));
            this.btnCancelarBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(145, 84);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(125, 50);
            this.btnCancelarBusqueda.TabIndex = 35;
            this.btnCancelarBusqueda.Text = "         Cancelar";
            this.btnCancelarBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarBusqueda.UseVisualStyleBackColor = false;
            this.btnCancelarBusqueda.Click += new System.EventHandler(this.btnCancelarBusqueda_Click);
            // 
            // btnBuscarTarjeta
            // 
            this.btnBuscarTarjeta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBuscarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnBuscarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnBuscarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTarjeta.Image")));
            this.btnBuscarTarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTarjeta.Location = new System.Drawing.Point(14, 84);
            this.btnBuscarTarjeta.Name = "btnBuscarTarjeta";
            this.btnBuscarTarjeta.Size = new System.Drawing.Size(125, 50);
            this.btnBuscarTarjeta.TabIndex = 32;
            this.btnBuscarTarjeta.Text = "            Buscar";
            this.btnBuscarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTarjeta.UseVisualStyleBackColor = false;
            this.btnBuscarTarjeta.Click += new System.EventHandler(this.btnBuscarTarjeta_Click);
            // 
            // txtBuscarNombreTarjeta
            // 
            this.txtBuscarNombreTarjeta.Location = new System.Drawing.Point(9, 43);
            this.txtBuscarNombreTarjeta.Name = "txtBuscarNombreTarjeta";
            this.txtBuscarNombreTarjeta.Size = new System.Drawing.Size(261, 26);
            this.txtBuscarNombreTarjeta.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre de la tarjeta:";
            // 
            // pnlModificarEliminarTarjeta
            // 
            this.pnlModificarEliminarTarjeta.Controls.Add(this.label10);
            this.pnlModificarEliminarTarjeta.Controls.Add(this.txtTipoTarjeta);
            this.pnlModificarEliminarTarjeta.Controls.Add(this.label7);
            this.pnlModificarEliminarTarjeta.Controls.Add(this.label5);
            this.pnlModificarEliminarTarjeta.Controls.Add(this.txtIDTarjeta);
            this.pnlModificarEliminarTarjeta.Controls.Add(this.txtNombreTarjeta);
            this.pnlModificarEliminarTarjeta.Controls.Add(this.btnEditarTarjeta);
            this.pnlModificarEliminarTarjeta.Controls.Add(this.btnEliminarTarjeta);
            this.pnlModificarEliminarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlModificarEliminarTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.pnlModificarEliminarTarjeta.Location = new System.Drawing.Point(12, 205);
            this.pnlModificarEliminarTarjeta.Name = "pnlModificarEliminarTarjeta";
            this.pnlModificarEliminarTarjeta.Size = new System.Drawing.Size(276, 235);
            this.pnlModificarEliminarTarjeta.TabIndex = 7;
            this.pnlModificarEliminarTarjeta.TabStop = false;
            this.pnlModificarEliminarTarjeta.Text = "Modificar / eliminar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 18);
            this.label10.TabIndex = 37;
            this.label10.Text = "Nombre de la tarjeta:";
            // 
            // txtTipoTarjeta
            // 
            this.txtTipoTarjeta.Enabled = false;
            this.txtTipoTarjeta.Location = new System.Drawing.Point(54, 75);
            this.txtTipoTarjeta.Name = "txtTipoTarjeta";
            this.txtTipoTarjeta.Size = new System.Drawing.Size(128, 26);
            this.txtTipoTarjeta.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(185, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "ID:";
            // 
            // txtIDTarjeta
            // 
            this.txtIDTarjeta.Enabled = false;
            this.txtIDTarjeta.Location = new System.Drawing.Point(218, 75);
            this.txtIDTarjeta.Name = "txtIDTarjeta";
            this.txtIDTarjeta.Size = new System.Drawing.Size(49, 26);
            this.txtIDTarjeta.TabIndex = 22;
            // 
            // txtNombreTarjeta
            // 
            this.txtNombreTarjeta.Enabled = false;
            this.txtNombreTarjeta.Location = new System.Drawing.Point(6, 43);
            this.txtNombreTarjeta.Name = "txtNombreTarjeta";
            this.txtNombreTarjeta.Size = new System.Drawing.Size(261, 26);
            this.txtNombreTarjeta.TabIndex = 21;
            // 
            // btnEditarTarjeta
            // 
            this.btnEditarTarjeta.Enabled = false;
            this.btnEditarTarjeta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEditarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnEditarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnEditarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnEditarTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarTarjeta.Image")));
            this.btnEditarTarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarTarjeta.Location = new System.Drawing.Point(6, 172);
            this.btnEditarTarjeta.Name = "btnEditarTarjeta";
            this.btnEditarTarjeta.Size = new System.Drawing.Size(264, 50);
            this.btnEditarTarjeta.TabIndex = 20;
            this.btnEditarTarjeta.Text = "            Editar tarjeta";
            this.btnEditarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarTarjeta.UseVisualStyleBackColor = false;
            this.btnEditarTarjeta.Click += new System.EventHandler(this.btnEditarTarjeta_Click);
            // 
            // btnEliminarTarjeta
            // 
            this.btnEliminarTarjeta.Enabled = false;
            this.btnEliminarTarjeta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEliminarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnEliminarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnEliminarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTarjeta.Image")));
            this.btnEliminarTarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarTarjeta.Location = new System.Drawing.Point(6, 116);
            this.btnEliminarTarjeta.Name = "btnEliminarTarjeta";
            this.btnEliminarTarjeta.Size = new System.Drawing.Size(264, 50);
            this.btnEliminarTarjeta.TabIndex = 19;
            this.btnEliminarTarjeta.Text = "            Eliminar tarjeta";
            this.btnEliminarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarTarjeta.UseVisualStyleBackColor = false;
            this.btnEliminarTarjeta.Click += new System.EventHandler(this.btnEliminarTarjeta_Click);
            // 
            // pnlAgregarTarjeta
            // 
            this.pnlAgregarTarjeta.Controls.Add(this.txtTipoNuevaTarjeta);
            this.pnlAgregarTarjeta.Controls.Add(this.label8);
            this.pnlAgregarTarjeta.Controls.Add(this.label9);
            this.pnlAgregarTarjeta.Controls.Add(this.txtIDNuevaTarjeta);
            this.pnlAgregarTarjeta.Controls.Add(this.txtNombreNuevaTarjeta);
            this.pnlAgregarTarjeta.Controls.Add(this.label4);
            this.pnlAgregarTarjeta.Controls.Add(this.btnCrearTarjeta);
            this.pnlAgregarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAgregarTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.pnlAgregarTarjeta.Location = new System.Drawing.Point(12, 446);
            this.pnlAgregarTarjeta.Name = "pnlAgregarTarjeta";
            this.pnlAgregarTarjeta.Size = new System.Drawing.Size(276, 226);
            this.pnlAgregarTarjeta.TabIndex = 8;
            this.pnlAgregarTarjeta.TabStop = false;
            this.pnlAgregarTarjeta.Text = "Agregar nueva";
            // 
            // txtTipoNuevaTarjeta
            // 
            this.txtTipoNuevaTarjeta.Location = new System.Drawing.Point(54, 84);
            this.txtTipoNuevaTarjeta.Name = "txtTipoNuevaTarjeta";
            this.txtTipoNuevaTarjeta.Size = new System.Drawing.Size(128, 26);
            this.txtTipoNuevaTarjeta.TabIndex = 40;
            this.txtTipoNuevaTarjeta.TextChanged += new System.EventHandler(this.txtTipoNuevaTarjeta_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(188, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "ID:";
            // 
            // txtIDNuevaTarjeta
            // 
            this.txtIDNuevaTarjeta.Enabled = false;
            this.txtIDNuevaTarjeta.Location = new System.Drawing.Point(221, 84);
            this.txtIDNuevaTarjeta.Name = "txtIDNuevaTarjeta";
            this.txtIDNuevaTarjeta.Size = new System.Drawing.Size(46, 26);
            this.txtIDNuevaTarjeta.TabIndex = 37;
            // 
            // txtNombreNuevaTarjeta
            // 
            this.txtNombreNuevaTarjeta.Location = new System.Drawing.Point(6, 52);
            this.txtNombreNuevaTarjeta.Name = "txtNombreNuevaTarjeta";
            this.txtNombreNuevaTarjeta.Size = new System.Drawing.Size(261, 26);
            this.txtNombreNuevaTarjeta.TabIndex = 31;
            this.txtNombreNuevaTarjeta.TextChanged += new System.EventHandler(this.txtNombreNuevaTarjeta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre de la nueva tarjeta:";
            // 
            // btnCrearTarjeta
            // 
            this.btnCrearTarjeta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCrearTarjeta.FlatAppearance.BorderSize = 0;
            this.btnCrearTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnCrearTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnCrearTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearTarjeta.Image")));
            this.btnCrearTarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearTarjeta.Location = new System.Drawing.Point(6, 148);
            this.btnCrearTarjeta.Name = "btnCrearTarjeta";
            this.btnCrearTarjeta.Size = new System.Drawing.Size(264, 50);
            this.btnCrearTarjeta.TabIndex = 26;
            this.btnCrearTarjeta.Text = "            Crear tarjeta";
            this.btnCrearTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearTarjeta.UseVisualStyleBackColor = false;
            this.btnCrearTarjeta.Click += new System.EventHandler(this.btnCrearTarjeta_Click);
            // 
            // FormTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(555, 684);
            this.Controls.Add(this.pnlAgregarTarjeta);
            this.Controls.Add(this.pnlModificarEliminarTarjeta);
            this.Controls.Add(this.pnlBuscarTarjeta);
            this.Controls.Add(this.dgvTarjetas);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(555, 684);
            this.Name = "FormTarjetas";
            this.Text = "FormTarjetas";
            this.Load += new System.EventHandler(this.FormTarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.pnlBuscarTarjeta.ResumeLayout(false);
            this.pnlBuscarTarjeta.PerformLayout();
            this.pnlModificarEliminarTarjeta.ResumeLayout(false);
            this.pnlModificarEliminarTarjeta.PerformLayout();
            this.pnlAgregarTarjeta.ResumeLayout(false);
            this.pnlAgregarTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTarjetas;
        private System.Windows.Forms.GroupBox pnlBuscarTarjeta;
        private System.Windows.Forms.GroupBox pnlModificarEliminarTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox pnlAgregarTarjeta;
        private System.Windows.Forms.Button btnCrearTarjeta;
        private System.Windows.Forms.Button btnEliminarTarjeta;
        private System.Windows.Forms.Button btnEditarTarjeta;
        private System.Windows.Forms.TextBox txtBuscarNombreTarjeta;
        private System.Windows.Forms.TextBox txtNombreNuevaTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDTarjeta;
        private System.Windows.Forms.TextBox txtNombreTarjeta;
        private System.Windows.Forms.Button btnBuscarTarjeta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTipoTarjeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoNuevaTarjeta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDNuevaTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Button btnCancelarBusqueda;
    }
}