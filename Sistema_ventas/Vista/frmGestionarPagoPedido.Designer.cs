namespace Vista {
    partial class frmGestionarPagoPedido {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarPagoPedido));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarPago = new System.Windows.Forms.Button();
            this.cboEstadoPedido = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAnula2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPago = new System.Windows.Forms.Button();
            this.gbxAnula1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarPago = new System.Windows.Forms.Button();
            this.btnCancelarPago = new System.Windows.Forms.Button();
            this.btnLimpiarPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxAnula2.SuspendLayout();
            this.gbxAnula1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarPago
            // 
            this.btnCerrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPago.Location = new System.Drawing.Point(495, 70);
            this.btnCerrarPago.Name = "btnCerrarPago";
            this.btnCerrarPago.Size = new System.Drawing.Size(80, 20);
            this.btnCerrarPago.TabIndex = 47;
            this.btnCerrarPago.Text = "CERRAR";
            this.btnCerrarPago.UseVisualStyleBackColor = false;
            this.btnCerrarPago.Click += new System.EventHandler(this.btnCerrarPago_Click);
            // 
            // cboEstadoPedido
            // 
            this.cboEstadoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoPedido.FormattingEnabled = true;
            this.cboEstadoPedido.Location = new System.Drawing.Point(297, 116);
            this.cboEstadoPedido.Name = "cboEstadoPedido";
            this.cboEstadoPedido.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoPedido.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Estado pedido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Total de Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "IGV";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(457, 343);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(115, 20);
            this.textBox5.TabIndex = 53;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(457, 382);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 20);
            this.textBox4.TabIndex = 52;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 184);
            this.groupBox2.TabIndex = 51;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 146);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Número de pedido:";
            // 
            // gbxAnula2
            // 
            this.gbxAnula2.Controls.Add(this.btnBuscarPago);
            this.gbxAnula2.Location = new System.Drawing.Point(457, 228);
            this.gbxAnula2.Name = "gbxAnula2";
            this.gbxAnula2.Size = new System.Drawing.Size(115, 70);
            this.gbxAnula2.TabIndex = 59;
            this.gbxAnula2.TabStop = false;
            // 
            // btnBuscarPago
            // 
            this.btnBuscarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPago.Location = new System.Drawing.Point(12, 18);
            this.btnBuscarPago.Name = "btnBuscarPago";
            this.btnBuscarPago.Size = new System.Drawing.Size(91, 39);
            this.btnBuscarPago.TabIndex = 3;
            this.btnBuscarPago.Text = "Busca a un pedido aquí";
            this.btnBuscarPago.UseVisualStyleBackColor = true;
            this.btnBuscarPago.Click += new System.EventHandler(this.btnBuscarPago_Click);
            // 
            // gbxAnula1
            // 
            this.gbxAnula1.Controls.Add(this.btnGuardarPago);
            this.gbxAnula1.Controls.Add(this.btnCancelarPago);
            this.gbxAnula1.Controls.Add(this.btnLimpiarPago);
            this.gbxAnula1.Location = new System.Drawing.Point(457, 109);
            this.gbxAnula1.Name = "gbxAnula1";
            this.gbxAnula1.Size = new System.Drawing.Size(115, 109);
            this.gbxAnula1.TabIndex = 58;
            this.gbxAnula1.TabStop = false;
            // 
            // btnGuardarPago
            // 
            this.btnGuardarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPago.Location = new System.Drawing.Point(12, 16);
            this.btnGuardarPago.Name = "btnGuardarPago";
            this.btnGuardarPago.Size = new System.Drawing.Size(91, 23);
            this.btnGuardarPago.TabIndex = 1;
            this.btnGuardarPago.Text = "Pagar";
            this.btnGuardarPago.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPago
            // 
            this.btnCancelarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPago.Location = new System.Drawing.Point(12, 45);
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.Size = new System.Drawing.Size(91, 23);
            this.btnCancelarPago.TabIndex = 2;
            this.btnCancelarPago.Text = "Cancelar";
            this.btnCancelarPago.UseVisualStyleBackColor = true;
            this.btnCancelarPago.Click += new System.EventHandler(this.btnCancelarPago_Click);
            // 
            // btnLimpiarPago
            // 
            this.btnLimpiarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPago.Location = new System.Drawing.Point(12, 74);
            this.btnLimpiarPago.Name = "btnLimpiarPago";
            this.btnLimpiarPago.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiarPago.TabIndex = 6;
            this.btnLimpiarPago.Text = "Limpiar";
            this.btnLimpiarPago.UseVisualStyleBackColor = true;
            // 
            // frmGestionarPagoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 430);
            this.Controls.Add(this.gbxAnula2);
            this.Controls.Add(this.gbxAnula1);
            this.Controls.Add(this.cboEstadoPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarPago);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarPagoPedido";
            this.Text = "frmGestionarPagoPedido";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarPago;
        private System.Windows.Forms.ComboBox cboEstadoPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxAnula2;
        private System.Windows.Forms.Button btnBuscarPago;
        private System.Windows.Forms.GroupBox gbxAnula1;
        private System.Windows.Forms.Button btnGuardarPago;
        private System.Windows.Forms.Button btnCancelarPago;
        private System.Windows.Forms.Button btnLimpiarPago;
    }
}