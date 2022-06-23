
namespace TP_PAV1
{
    partial class ModificarLocal
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarLocal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoLocal = new System.Windows.Forms.ComboBox();
            this.txtNumLocal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreLocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaLocales = new System.Windows.Forms.DataGridView();
            this.nombreLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_comercio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLocales)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Seleccionar Local:";
            // 
            // btnModificarLocal
            // 
            this.btnModificarLocal.AutoSize = true;
            this.btnModificarLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.btnModificarLocal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnModificarLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLocal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarLocal.Location = new System.Drawing.Point(212, 305);
            this.btnModificarLocal.Name = "btnModificarLocal";
            this.btnModificarLocal.Size = new System.Drawing.Size(93, 27);
            this.btnModificarLocal.TabIndex = 21;
            this.btnModificarLocal.Text = "Modificar";
            this.btnModificarLocal.Click += new System.EventHandler(this.btnModificarLocal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoLocal);
            this.groupBox1.Controls.Add(this.txtNumLocal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreLocal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 206);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar local";
            // 
            // cmbTipoLocal
            // 
            this.cmbTipoLocal.FormattingEnabled = true;
            this.cmbTipoLocal.Location = new System.Drawing.Point(140, 159);
            this.cmbTipoLocal.Name = "cmbTipoLocal";
            this.cmbTipoLocal.Size = new System.Drawing.Size(168, 24);
            this.cmbTipoLocal.TabIndex = 11;
            // 
            // txtNumLocal
            // 
            this.txtNumLocal.Location = new System.Drawing.Point(140, 111);
            this.txtNumLocal.Name = "txtNumLocal";
            this.txtNumLocal.Size = new System.Drawing.Size(98, 22);
            this.txtNumLocal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero de local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(28, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de local";
            // 
            // txtNombreLocal
            // 
            this.txtNombreLocal.Location = new System.Drawing.Point(140, 56);
            this.txtNombreLocal.Name = "txtNombreLocal";
            this.txtNombreLocal.Size = new System.Drawing.Size(297, 22);
            this.txtNombreLocal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(173, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Modificar Local";
            // 
            // grillaLocales
            // 
            this.grillaLocales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.grillaLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLocales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreLocal,
            this.numLocal,
            this.id_tipo_comercio});
            this.grillaLocales.Location = new System.Drawing.Point(12, 369);
            this.grillaLocales.Name = "grillaLocales";
            this.grillaLocales.RowHeadersVisible = false;
            this.grillaLocales.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.grillaLocales.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaLocales.RowTemplate.Height = 24;
            this.grillaLocales.Size = new System.Drawing.Size(512, 256);
            this.grillaLocales.TabIndex = 23;
            this.grillaLocales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaLocales_CellClick);
            // 
            // nombreLocal
            // 
            this.nombreLocal.DataPropertyName = "nombre_comercio";
            this.nombreLocal.HeaderText = "Nombre de local";
            this.nombreLocal.MinimumWidth = 6;
            this.nombreLocal.Name = "nombreLocal";
            this.nombreLocal.Width = 250;
            // 
            // numLocal
            // 
            this.numLocal.DataPropertyName = "nro_local";
            this.numLocal.HeaderText = "Nro local";
            this.numLocal.MinimumWidth = 6;
            this.numLocal.Name = "numLocal";
            this.numLocal.Width = 150;
            // 
            // id_tipo_comercio
            // 
            this.id_tipo_comercio.DataPropertyName = "nombre_tipo_comercios";
            this.id_tipo_comercio.HeaderText = "Tipo";
            this.id_tipo_comercio.MinimumWidth = 6;
            this.id_tipo_comercio.Name = "id_tipo_comercio";
            this.id_tipo_comercio.Width = 112;
            // 
            // ModificarLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(537, 637);
            this.Controls.Add(this.grillaLocales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificarLocal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ModificarLocal";
            this.Text = "ModificarLocal";
            this.Load += new System.EventHandler(this.ModificarLocal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLocales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnModificarLocal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoLocal;
        private System.Windows.Forms.TextBox txtNumLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaLocales;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_comercio;
    }
}