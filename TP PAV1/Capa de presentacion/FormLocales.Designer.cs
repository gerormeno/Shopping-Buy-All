namespace TP_PAV1
{
    partial class FormLocales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminarLocal = new System.Windows.Forms.Label();
            this.agregarLocal = new System.Windows.Forms.Label();
            this.modificarLocal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grillaLocales = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Label();
            this.nombreLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tipo_comercios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscarLocal = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLocales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(238, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Locales comerciales";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.eliminarLocal);
            this.groupBox2.Controls.Add(this.agregarLocal);
            this.groupBox2.Controls.Add(this.modificarLocal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.groupBox2.Location = new System.Drawing.Point(575, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 200);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "🔩";
            // 
            // eliminarLocal
            // 
            this.eliminarLocal.AutoSize = true;
            this.eliminarLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.eliminarLocal.Location = new System.Drawing.Point(20, 131);
            this.eliminarLocal.Name = "eliminarLocal";
            this.eliminarLocal.Size = new System.Drawing.Size(91, 17);
            this.eliminarLocal.TabIndex = 7;
            this.eliminarLocal.Text = "Eliminar local";
            this.eliminarLocal.Click += new System.EventHandler(this.eliminarLocal_Click);
            // 
            // agregarLocal
            // 
            this.agregarLocal.AutoSize = true;
            this.agregarLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.agregarLocal.Location = new System.Drawing.Point(20, 49);
            this.agregarLocal.Name = "agregarLocal";
            this.agregarLocal.Size = new System.Drawing.Size(92, 17);
            this.agregarLocal.TabIndex = 6;
            this.agregarLocal.Text = "Agregar local";
            this.agregarLocal.Click += new System.EventHandler(this.agregarLocal_Click);
            // 
            // modificarLocal
            // 
            this.modificarLocal.AutoSize = true;
            this.modificarLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.modificarLocal.Location = new System.Drawing.Point(20, 91);
            this.modificarLocal.Name = "modificarLocal";
            this.modificarLocal.Size = new System.Drawing.Size(98, 17);
            this.modificarLocal.TabIndex = 5;
            this.modificarLocal.Text = "Modificar local";
            this.modificarLocal.Click += new System.EventHandler(this.modificarLocal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(407, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 2;
            // 
            // grillaLocales
            // 
            this.grillaLocales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.grillaLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLocales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreLocal,
            this.numLocal,
            this.nombre_tipo_comercios});
            this.grillaLocales.Location = new System.Drawing.Point(12, 353);
            this.grillaLocales.Name = "grillaLocales";
            this.grillaLocales.RowHeadersVisible = false;
            this.grillaLocales.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.grillaLocales.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaLocales.RowTemplate.Height = 24;
            this.grillaLocales.Size = new System.Drawing.Size(704, 336);
            this.grillaLocales.TabIndex = 9;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.btnActualizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(12, 692);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(132, 22);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar datos";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // nombreLocal
            // 
            this.nombreLocal.DataPropertyName = "nombre_comercio";
            this.nombreLocal.HeaderText = "Nombre de local";
            this.nombreLocal.MinimumWidth = 6;
            this.nombreLocal.Name = "nombreLocal";
            this.nombreLocal.Width = 350;
            // 
            // numLocal
            // 
            this.numLocal.DataPropertyName = "nro_local";
            this.numLocal.HeaderText = "Nro local";
            this.numLocal.MinimumWidth = 6;
            this.numLocal.Name = "numLocal";
            this.numLocal.Width = 125;
            // 
            // nombre_tipo_comercios
            // 
            this.nombre_tipo_comercios.DataPropertyName = "nombre_tipo_comercios";
            this.nombre_tipo_comercios.HeaderText = "Tipo";
            this.nombre_tipo_comercios.MinimumWidth = 6;
            this.nombre_tipo_comercios.Name = "nombre_tipo_comercios";
            this.nombre_tipo_comercios.Width = 139;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(407, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(194, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de local";
            // 
            // buscarLocal
            // 
            this.buscarLocal.Location = new System.Drawing.Point(110, 111);
            this.buscarLocal.Name = "buscarLocal";
            this.buscarLocal.Size = new System.Drawing.Size(297, 22);
            this.buscarLocal.TabIndex = 4;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.AutoSize = true;
            this.btnBuscarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.btnBuscarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBuscarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(226, 156);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(75, 27);
            this.btnBuscarArticulo.TabIndex = 16;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBuscarArticulo);
            this.groupBox1.Controls.Add(this.buscarLocal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 200);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "🔎";
            // 
            // FormLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(740, 842);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grillaLocales);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(740, 842);
            this.Name = "FormLocales";
            this.Text = "FormLocales";
            this.Load += new System.EventHandler(this.FormLocales_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLocales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label modificarLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eliminarLocal;
        private System.Windows.Forms.Label agregarLocal;
        private System.Windows.Forms.DataGridView grillaLocales;
        private System.Windows.Forms.Label btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tipo_comercios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buscarLocal;
        private System.Windows.Forms.Label btnBuscarArticulo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}