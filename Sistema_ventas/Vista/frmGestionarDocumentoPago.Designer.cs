namespace Vista {
    partial class frmGestionarDocumentoPago {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarDocumentoPago));
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarDocum = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxAnula2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarDocum = new System.Windows.Forms.Button();
            this.gbxAnula1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarDocum = new System.Windows.Forms.Button();
            this.btnEnviarDocum = new System.Windows.Forms.Button();
            this.btnGuardarDocum = new System.Windows.Forms.Button();
            this.btnCancelarDocum = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxAnula2.SuspendLayout();
            this.gbxAnula1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Fecha de emisión:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarDocum
            // 
            this.btnCerrarDocum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarDocum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarDocum.Location = new System.Drawing.Point(495, 70);
            this.btnCerrarDocum.Name = "btnCerrarDocum";
            this.btnCerrarDocum.Size = new System.Drawing.Size(80, 20);
            this.btnCerrarDocum.TabIndex = 46;
            this.btnCerrarDocum.Text = "CERRAR";
            this.btnCerrarDocum.UseVisualStyleBackColor = false;
            this.btnCerrarDocum.Click += new System.EventHandler(this.btnCerrarDocum_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Número de pedido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 184);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de pedido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProd,
            this.Cantidad,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(20, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(387, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // NombreProd
            // 
            this.NombreProd.HeaderText = "Nombre del producto";
            this.NombreProd.Name = "NombreProd";
            this.NombreProd.ReadOnly = true;
            this.NombreProd.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 80);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Razón social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "RUC:";
            // 
            // gbxAnula2
            // 
            this.gbxAnula2.Controls.Add(this.btnBuscarDocum);
            this.gbxAnula2.Location = new System.Drawing.Point(458, 230);
            this.gbxAnula2.Name = "gbxAnula2";
            this.gbxAnula2.Size = new System.Drawing.Size(115, 70);
            this.gbxAnula2.TabIndex = 56;
            this.gbxAnula2.TabStop = false;
            // 
            // btnBuscarDocum
            // 
            this.btnBuscarDocum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDocum.Location = new System.Drawing.Point(12, 18);
            this.btnBuscarDocum.Name = "btnBuscarDocum";
            this.btnBuscarDocum.Size = new System.Drawing.Size(91, 39);
            this.btnBuscarDocum.TabIndex = 3;
            this.btnBuscarDocum.Text = "Busca a un pedido aquí";
            this.btnBuscarDocum.UseVisualStyleBackColor = true;
            this.btnBuscarDocum.Click += new System.EventHandler(this.btnBuscarDocum_Click);
            // 
            // gbxAnula1
            // 
            this.gbxAnula1.Controls.Add(this.btnLimpiarDocum);
            this.gbxAnula1.Controls.Add(this.btnEnviarDocum);
            this.gbxAnula1.Controls.Add(this.btnGuardarDocum);
            this.gbxAnula1.Controls.Add(this.btnCancelarDocum);
            this.gbxAnula1.Location = new System.Drawing.Point(356, 140);
            this.gbxAnula1.Name = "gbxAnula1";
            this.gbxAnula1.Size = new System.Drawing.Size(217, 84);
            this.gbxAnula1.TabIndex = 55;
            this.gbxAnula1.TabStop = false;
            // 
            // btnLimpiarDocum
            // 
            this.btnLimpiarDocum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDocum.Location = new System.Drawing.Point(114, 45);
            this.btnLimpiarDocum.Name = "btnLimpiarDocum";
            this.btnLimpiarDocum.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiarDocum.TabIndex = 7;
            this.btnLimpiarDocum.Text = "Limpiar";
            this.btnLimpiarDocum.UseVisualStyleBackColor = true;
            // 
            // btnEnviarDocum
            // 
            this.btnEnviarDocum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarDocum.Location = new System.Drawing.Point(12, 16);
            this.btnEnviarDocum.Name = "btnEnviarDocum";
            this.btnEnviarDocum.Size = new System.Drawing.Size(91, 23);
            this.btnEnviarDocum.TabIndex = 1;
            this.btnEnviarDocum.Text = "Enviar";
            this.btnEnviarDocum.UseVisualStyleBackColor = true;
            this.btnEnviarDocum.Click += new System.EventHandler(this.btnEnviarDocum_Click);
            // 
            // btnGuardarDocum
            // 
            this.btnGuardarDocum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDocum.Location = new System.Drawing.Point(12, 45);
            this.btnGuardarDocum.Name = "btnGuardarDocum";
            this.btnGuardarDocum.Size = new System.Drawing.Size(91, 23);
            this.btnGuardarDocum.TabIndex = 2;
            this.btnGuardarDocum.Text = "Guardar";
            this.btnGuardarDocum.UseVisualStyleBackColor = true;
            // 
            // btnCancelarDocum
            // 
            this.btnCancelarDocum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDocum.Location = new System.Drawing.Point(114, 16);
            this.btnCancelarDocum.Name = "btnCancelarDocum";
            this.btnCancelarDocum.Size = new System.Drawing.Size(91, 23);
            this.btnCancelarDocum.TabIndex = 6;
            this.btnCancelarDocum.Text = "Cancelar";
            this.btnCancelarDocum.UseVisualStyleBackColor = true;
            this.btnCancelarDocum.Click += new System.EventHandler(this.btnCancelarDocum_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Total de Venta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(504, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "IGV";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(458, 342);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(115, 20);
            this.textBox7.TabIndex = 52;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(458, 387);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(115, 20);
            this.textBox8.TabIndex = 51;
            // 
            // frmGestionarDocumentoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 430);
            this.Controls.Add(this.gbxAnula2);
            this.Controls.Add(this.gbxAnula1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarDocum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarDocumentoPago";
            this.Text = "frmGestionarDocumentoPago";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAnula2.ResumeLayout(false);
            this.gbxAnula1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarDocum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxAnula2;
        private System.Windows.Forms.Button btnBuscarDocum;
        private System.Windows.Forms.GroupBox gbxAnula1;
        private System.Windows.Forms.Button btnEnviarDocum;
        private System.Windows.Forms.Button btnGuardarDocum;
        private System.Windows.Forms.Button btnCancelarDocum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnLimpiarDocum;
    }
}