namespace TP_PAV1
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.grillaUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtBuscarUsuarioNombre = new System.Windows.Forms.TextBox();
            this.PICagregar = new System.Windows.Forms.PictureBox();
            this.PICborrar = new System.Windows.Forms.PictureBox();
            this.PICeditar = new System.Windows.Forms.PictureBox();
            this.PICreload = new System.Windows.Forms.PictureBox();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICagregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICborrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICeditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICreload)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaUsuarios
            // 
            this.grillaUsuarios.AllowUserToAddRows = false;
            this.grillaUsuarios.AllowUserToDeleteRows = false;
            this.grillaUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Contraseña,
            this.Correo});
            this.grillaUsuarios.Location = new System.Drawing.Point(12, 129);
            this.grillaUsuarios.Name = "grillaUsuarios";
            this.grillaUsuarios.ReadOnly = true;
            this.grillaUsuarios.RowHeadersVisible = false;
            this.grillaUsuarios.Size = new System.Drawing.Size(514, 466);
            this.grillaUsuarios.TabIndex = 0;
            this.grillaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaUsuarios_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarUsuario);
            this.groupBox1.Controls.Add(this.txtBuscarUsuarioNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(427, 31);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(60, 20);
            this.btnBuscarUsuario.TabIndex = 3;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtBuscarUsuarioNombre
            // 
            this.txtBuscarUsuarioNombre.Location = new System.Drawing.Point(149, 30);
            this.txtBuscarUsuarioNombre.Name = "txtBuscarUsuarioNombre";
            this.txtBuscarUsuarioNombre.Size = new System.Drawing.Size(257, 20);
            this.txtBuscarUsuarioNombre.TabIndex = 2;
            // 
            // PICagregar
            // 
            this.PICagregar.Image = ((System.Drawing.Image)(resources.GetObject("PICagregar.Image")));
            this.PICagregar.Location = new System.Drawing.Point(12, 605);
            this.PICagregar.Name = "PICagregar";
            this.PICagregar.Size = new System.Drawing.Size(40, 34);
            this.PICagregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICagregar.TabIndex = 6;
            this.PICagregar.TabStop = false;
            this.PICagregar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PICborrar
            // 
            this.PICborrar.Image = ((System.Drawing.Image)(resources.GetObject("PICborrar.Image")));
            this.PICborrar.Location = new System.Drawing.Point(58, 605);
            this.PICborrar.Name = "PICborrar";
            this.PICborrar.Size = new System.Drawing.Size(40, 34);
            this.PICborrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICborrar.TabIndex = 7;
            this.PICborrar.TabStop = false;
            this.PICborrar.Click += new System.EventHandler(this.PICborrar_Click);
            // 
            // PICeditar
            // 
            this.PICeditar.Image = ((System.Drawing.Image)(resources.GetObject("PICeditar.Image")));
            this.PICeditar.Location = new System.Drawing.Point(104, 605);
            this.PICeditar.Name = "PICeditar";
            this.PICeditar.Size = new System.Drawing.Size(40, 34);
            this.PICeditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICeditar.TabIndex = 8;
            this.PICeditar.TabStop = false;
            this.PICeditar.Click += new System.EventHandler(this.PICeditar_Click);
            // 
            // PICreload
            // 
            this.PICreload.Image = ((System.Drawing.Image)(resources.GetObject("PICreload.Image")));
            this.PICreload.Location = new System.Drawing.Point(150, 605);
            this.PICreload.Name = "PICreload";
            this.PICreload.Size = new System.Drawing.Size(31, 34);
            this.PICreload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICreload.TabIndex = 9;
            this.PICreload.TabStop = false;
            this.PICreload.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 130;
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Width = 130;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 248;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(555, 684);
            this.Controls.Add(this.PICreload);
            this.Controls.Add(this.PICeditar);
            this.Controls.Add(this.PICborrar);
            this.Controls.Add(this.PICagregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grillaUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(555, 684);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICagregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICborrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICeditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICreload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuarioNombre;
        private System.Windows.Forms.PictureBox PICagregar;
        private System.Windows.Forms.PictureBox PICborrar;
        private System.Windows.Forms.PictureBox PICeditar;
        private System.Windows.Forms.PictureBox PICreload;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}