
namespace TP_PAV1
{
    partial class EliminarLocal
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
            this.grillaLocales = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarLocal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoLocal = new System.Windows.Forms.ComboBox();
            this.txtNumLocal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreLocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLocales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grillaLocales
            // 
            this.grillaLocales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.grillaLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLocales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreLocal,
            this.numLocal,
            this.tipoLocal});
            this.grillaLocales.Location = new System.Drawing.Point(12, 359);
            this.grillaLocales.Name = "grillaLocales";
            this.grillaLocales.RowHeadersVisible = false;
            this.grillaLocales.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.grillaLocales.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaLocales.RowTemplate.Height = 24;
            this.grillaLocales.Size = new System.Drawing.Size(513, 266);
            this.grillaLocales.TabIndex = 28;
            this.grillaLocales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaLocales_CellClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Seleccionar Local:";
            // 
            // btnEliminarLocal
            // 
            this.btnEliminarLocal.AutoSize = true;
            this.btnEliminarLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.btnEliminarLocal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnEliminarLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLocal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarLocal.Location = new System.Drawing.Point(212, 295);
            this.btnEliminarLocal.Name = "btnEliminarLocal";
            this.btnEliminarLocal.Size = new System.Drawing.Size(83, 27);
            this.btnEliminarLocal.TabIndex = 26;
            this.btnEliminarLocal.Text = "Eliminar";
            this.btnEliminarLocal.Click += new System.EventHandler(this.btnEliminarLocal_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 206);
            this.groupBox1.TabIndex = 25;
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
            this.label1.Location = new System.Drawing.Point(152, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 34);
            this.label1.TabIndex = 24;
            this.label1.Text = "Eliminar Local";
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
            // tipoLocal
            // 
            this.tipoLocal.DataPropertyName = "nombre_tipo_comercios";
            this.tipoLocal.HeaderText = "Tipo";
            this.tipoLocal.MinimumWidth = 6;
            this.tipoLocal.Name = "tipoLocal";
            this.tipoLocal.Width = 112;
            // 
            // EliminarLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(537, 637);
            this.Controls.Add(this.grillaLocales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminarLocal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "EliminarLocal";
            this.Text = "EliminarLocal";
            this.Load += new System.EventHandler(this.EliminarLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaLocales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaLocales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnEliminarLocal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoLocal;
        private System.Windows.Forms.TextBox txtNumLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLocal;
    }
}