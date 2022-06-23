namespace TP_PAV1
{
    partial class FormBarrios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarrios));
            this.pnlAgregarBarrio = new System.Windows.Forms.GroupBox();
            this.txtNombreNuevoBarrio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrearBarrio = new System.Windows.Forms.Button();
            this.pnlModificarEliminarBarrio = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDBarrio = new System.Windows.Forms.TextBox();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.btnEditarBarrio = new System.Windows.Forms.Button();
            this.btnEliminarBarrio = new System.Windows.Forms.Button();
            this.pnlBuscarBarrio = new System.Windows.Forms.GroupBox();
            this.btnBuscarBarrio = new System.Windows.Forms.Button();
            this.txtBuscarNombreBarrio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBarrios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarBusqueda = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDNuevoBarrio = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAgregarBarrio.SuspendLayout();
            this.pnlModificarEliminarBarrio.SuspendLayout();
            this.pnlBuscarBarrio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAgregarBarrio
            // 
            this.pnlAgregarBarrio.Controls.Add(this.label9);
            this.pnlAgregarBarrio.Controls.Add(this.txtIDNuevoBarrio);
            this.pnlAgregarBarrio.Controls.Add(this.txtNombreNuevoBarrio);
            this.pnlAgregarBarrio.Controls.Add(this.label4);
            this.pnlAgregarBarrio.Controls.Add(this.btnCrearBarrio);
            this.pnlAgregarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAgregarBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.pnlAgregarBarrio.Location = new System.Drawing.Point(12, 468);
            this.pnlAgregarBarrio.Name = "pnlAgregarBarrio";
            this.pnlAgregarBarrio.Size = new System.Drawing.Size(276, 204);
            this.pnlAgregarBarrio.TabIndex = 13;
            this.pnlAgregarBarrio.TabStop = false;
            this.pnlAgregarBarrio.Text = "Agregar nuevo";
            // 
            // txtNombreNuevoBarrio
            // 
            this.txtNombreNuevoBarrio.Location = new System.Drawing.Point(9, 61);
            this.txtNombreNuevoBarrio.Name = "txtNombreNuevoBarrio";
            this.txtNombreNuevoBarrio.Size = new System.Drawing.Size(261, 26);
            this.txtNombreNuevoBarrio.TabIndex = 31;
            this.txtNombreNuevoBarrio.TextChanged += new System.EventHandler(this.txtNombreNuevoBarrio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre del nuevo barrio:";
            // 
            // btnCrearBarrio
            // 
            this.btnCrearBarrio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCrearBarrio.FlatAppearance.BorderSize = 0;
            this.btnCrearBarrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnCrearBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearBarrio.ForeColor = System.Drawing.Color.White;
            this.btnCrearBarrio.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearBarrio.Image")));
            this.btnCrearBarrio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearBarrio.Location = new System.Drawing.Point(6, 148);
            this.btnCrearBarrio.Name = "btnCrearBarrio";
            this.btnCrearBarrio.Size = new System.Drawing.Size(264, 50);
            this.btnCrearBarrio.TabIndex = 26;
            this.btnCrearBarrio.Text = "            Crear barrio";
            this.btnCrearBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearBarrio.UseVisualStyleBackColor = false;
            this.btnCrearBarrio.Click += new System.EventHandler(this.btnCrearBarrio_Click);
            // 
            // pnlModificarEliminarBarrio
            // 
            this.pnlModificarEliminarBarrio.Controls.Add(this.label5);
            this.pnlModificarEliminarBarrio.Controls.Add(this.txtIDBarrio);
            this.pnlModificarEliminarBarrio.Controls.Add(this.txtNombreBarrio);
            this.pnlModificarEliminarBarrio.Controls.Add(this.btnEditarBarrio);
            this.pnlModificarEliminarBarrio.Controls.Add(this.btnEliminarBarrio);
            this.pnlModificarEliminarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlModificarEliminarBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.pnlModificarEliminarBarrio.Location = new System.Drawing.Point(12, 258);
            this.pnlModificarEliminarBarrio.Name = "pnlModificarEliminarBarrio";
            this.pnlModificarEliminarBarrio.Size = new System.Drawing.Size(276, 204);
            this.pnlModificarEliminarBarrio.TabIndex = 12;
            this.pnlModificarEliminarBarrio.TabStop = false;
            this.pnlModificarEliminarBarrio.Text = "Modificar / eliminar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(172, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "ID:";
            // 
            // txtIDBarrio
            // 
            this.txtIDBarrio.Enabled = false;
            this.txtIDBarrio.Location = new System.Drawing.Point(205, 57);
            this.txtIDBarrio.Name = "txtIDBarrio";
            this.txtIDBarrio.Size = new System.Drawing.Size(65, 26);
            this.txtIDBarrio.TabIndex = 22;
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Enabled = false;
            this.txtNombreBarrio.Location = new System.Drawing.Point(9, 25);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(261, 26);
            this.txtNombreBarrio.TabIndex = 21;
            // 
            // btnEditarBarrio
            // 
            this.btnEditarBarrio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEditarBarrio.FlatAppearance.BorderSize = 0;
            this.btnEditarBarrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnEditarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarBarrio.ForeColor = System.Drawing.Color.White;
            this.btnEditarBarrio.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarBarrio.Image")));
            this.btnEditarBarrio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarBarrio.Location = new System.Drawing.Point(6, 148);
            this.btnEditarBarrio.Name = "btnEditarBarrio";
            this.btnEditarBarrio.Size = new System.Drawing.Size(264, 50);
            this.btnEditarBarrio.TabIndex = 20;
            this.btnEditarBarrio.Text = "            Editar barrio";
            this.btnEditarBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarBarrio.UseVisualStyleBackColor = false;
            this.btnEditarBarrio.Click += new System.EventHandler(this.btnEditarBarrio_Click);
            // 
            // btnEliminarBarrio
            // 
            this.btnEliminarBarrio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEliminarBarrio.FlatAppearance.BorderSize = 0;
            this.btnEliminarBarrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnEliminarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarBarrio.ForeColor = System.Drawing.Color.White;
            this.btnEliminarBarrio.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarBarrio.Image")));
            this.btnEliminarBarrio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarBarrio.Location = new System.Drawing.Point(6, 92);
            this.btnEliminarBarrio.Name = "btnEliminarBarrio";
            this.btnEliminarBarrio.Size = new System.Drawing.Size(264, 50);
            this.btnEliminarBarrio.TabIndex = 19;
            this.btnEliminarBarrio.Text = "            Eliminar barrio";
            this.btnEliminarBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarBarrio.UseVisualStyleBackColor = false;
            this.btnEliminarBarrio.Click += new System.EventHandler(this.btnEliminarBarrio_Click);
            // 
            // pnlBuscarBarrio
            // 
            this.pnlBuscarBarrio.Controls.Add(this.btnCancelarBusqueda);
            this.pnlBuscarBarrio.Controls.Add(this.btnBuscarBarrio);
            this.pnlBuscarBarrio.Controls.Add(this.txtBuscarNombreBarrio);
            this.pnlBuscarBarrio.Controls.Add(this.label1);
            this.pnlBuscarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBuscarBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.pnlBuscarBarrio.Location = new System.Drawing.Point(12, 48);
            this.pnlBuscarBarrio.Name = "pnlBuscarBarrio";
            this.pnlBuscarBarrio.Size = new System.Drawing.Size(276, 204);
            this.pnlBuscarBarrio.TabIndex = 11;
            this.pnlBuscarBarrio.TabStop = false;
            this.pnlBuscarBarrio.Text = "Buscar";
            // 
            // btnBuscarBarrio
            // 
            this.btnBuscarBarrio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBuscarBarrio.FlatAppearance.BorderSize = 0;
            this.btnBuscarBarrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnBuscarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBarrio.ForeColor = System.Drawing.Color.White;
            this.btnBuscarBarrio.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarBarrio.Image")));
            this.btnBuscarBarrio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarBarrio.Location = new System.Drawing.Point(6, 148);
            this.btnBuscarBarrio.Name = "btnBuscarBarrio";
            this.btnBuscarBarrio.Size = new System.Drawing.Size(133, 50);
            this.btnBuscarBarrio.TabIndex = 32;
            this.btnBuscarBarrio.Text = "            Buscar";
            this.btnBuscarBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarBarrio.UseVisualStyleBackColor = false;
            this.btnBuscarBarrio.Click += new System.EventHandler(this.btnBuscarBarrio_Click);
            // 
            // txtBuscarNombreBarrio
            // 
            this.txtBuscarNombreBarrio.Location = new System.Drawing.Point(9, 56);
            this.txtBuscarNombreBarrio.Name = "txtBuscarNombreBarrio";
            this.txtBuscarNombreBarrio.Size = new System.Drawing.Size(261, 26);
            this.txtBuscarNombreBarrio.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre del barrio:";
            // 
            // dgvBarrios
            // 
            this.dgvBarrios.AllowUserToAddRows = false;
            this.dgvBarrios.AllowUserToDeleteRows = false;
            this.dgvBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Barrio});
            this.dgvBarrios.Location = new System.Drawing.Point(294, 57);
            this.dgvBarrios.Name = "dgvBarrios";
            this.dgvBarrios.ReadOnly = true;
            this.dgvBarrios.Size = new System.Drawing.Size(249, 615);
            this.dgvBarrios.TabIndex = 10;
            this.dgvBarrios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarrios_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Administrar barrios";
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
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(145, 148);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(125, 50);
            this.btnCancelarBusqueda.TabIndex = 36;
            this.btnCancelarBusqueda.Text = "         Cancelar";
            this.btnCancelarBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarBusqueda.UseVisualStyleBackColor = false;
            this.btnCancelarBusqueda.Click += new System.EventHandler(this.btnCancelarBusqueda_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(191, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "ID:";
            // 
            // txtIDNuevoBarrio
            // 
            this.txtIDNuevoBarrio.Enabled = false;
            this.txtIDNuevoBarrio.Location = new System.Drawing.Point(224, 93);
            this.txtIDNuevoBarrio.Name = "txtIDNuevoBarrio";
            this.txtIDNuevoBarrio.Size = new System.Drawing.Size(46, 26);
            this.txtIDNuevoBarrio.TabIndex = 39;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_barrio";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Barrio
            // 
            this.Barrio.DataPropertyName = "nombre_barrio";
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            // 
            // FormBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(555, 684);
            this.Controls.Add(this.pnlAgregarBarrio);
            this.Controls.Add(this.pnlModificarEliminarBarrio);
            this.Controls.Add(this.pnlBuscarBarrio);
            this.Controls.Add(this.dgvBarrios);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(555, 684);
            this.Name = "FormBarrios";
            this.Text = "FormBarrios";
            this.Load += new System.EventHandler(this.FormBarrios_Load);
            this.pnlAgregarBarrio.ResumeLayout(false);
            this.pnlAgregarBarrio.PerformLayout();
            this.pnlModificarEliminarBarrio.ResumeLayout(false);
            this.pnlModificarEliminarBarrio.PerformLayout();
            this.pnlBuscarBarrio.ResumeLayout(false);
            this.pnlBuscarBarrio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlAgregarBarrio;
        private System.Windows.Forms.TextBox txtNombreNuevoBarrio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrearBarrio;
        private System.Windows.Forms.GroupBox pnlModificarEliminarBarrio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDBarrio;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.Button btnEditarBarrio;
        private System.Windows.Forms.Button btnEliminarBarrio;
        private System.Windows.Forms.GroupBox pnlBuscarBarrio;
        private System.Windows.Forms.Button btnBuscarBarrio;
        private System.Windows.Forms.TextBox txtBuscarNombreBarrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBarrios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarBusqueda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDNuevoBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
    }
}