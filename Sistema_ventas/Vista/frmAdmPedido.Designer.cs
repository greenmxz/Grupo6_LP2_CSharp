namespace Vista
{
    partial class frmAdmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmPedido));
            this.gBoxProd = new System.Windows.Forms.GroupBox();
            this.btnQuitarClienteXPedido = new System.Windows.Forms.Button();
            this.txtNombProd = new System.Windows.Forms.TextBox();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.btnAgregarClienteXPedido = new System.Windows.Forms.Button();
            this.txtCantProd = new System.Windows.Forms.TextBox();
            this.btnModificarClienteXPedido = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarProdXPedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRazSocCliente = new System.Windows.Forms.TextBox();
            this.txtRUCCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePedido = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarClienteXPedido = new System.Windows.Forms.Button();
            this.gBoxCli = new System.Windows.Forms.GroupBox();
            this.btnCerrarPedido = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxPed2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.gbxPed1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxProd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.gBoxCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxPed2.SuspendLayout();
            this.gbxPed1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxProd
            // 
            this.gBoxProd.Controls.Add(this.btnQuitarClienteXPedido);
            this.gBoxProd.Controls.Add(this.txtNombProd);
            this.gBoxProd.Controls.Add(this.txtCodigoProd);
            this.gBoxProd.Controls.Add(this.btnAgregarClienteXPedido);
            this.gBoxProd.Controls.Add(this.txtCantProd);
            this.gBoxProd.Controls.Add(this.btnModificarClienteXPedido);
            this.gBoxProd.Controls.Add(this.label5);
            this.gBoxProd.Controls.Add(this.btnBuscarProdXPedido);
            this.gBoxProd.Controls.Add(this.label3);
            this.gBoxProd.Controls.Add(this.label2);
            this.gBoxProd.Location = new System.Drawing.Point(9, 211);
            this.gBoxProd.Name = "gBoxProd";
            this.gBoxProd.Size = new System.Drawing.Size(566, 100);
            this.gBoxProd.TabIndex = 1;
            this.gBoxProd.TabStop = false;
            this.gBoxProd.Text = "Datos del producto";
            // 
            // btnQuitarClienteXPedido
            // 
            this.btnQuitarClienteXPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarClienteXPedido.Location = new System.Drawing.Point(479, 67);
            this.btnQuitarClienteXPedido.Name = "btnQuitarClienteXPedido";
            this.btnQuitarClienteXPedido.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarClienteXPedido.TabIndex = 9;
            this.btnQuitarClienteXPedido.Text = "Quitar";
            this.btnQuitarClienteXPedido.UseVisualStyleBackColor = true;
            this.btnQuitarClienteXPedido.Click += new System.EventHandler(this.btnQuitarClienteXPedido_Click);
            // 
            // txtNombProd
            // 
            this.txtNombProd.Enabled = false;
            this.txtNombProd.Location = new System.Drawing.Point(103, 45);
            this.txtNombProd.Name = "txtNombProd";
            this.txtNombProd.Size = new System.Drawing.Size(351, 20);
            this.txtNombProd.TabIndex = 8;
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Enabled = false;
            this.txtCodigoProd.Location = new System.Drawing.Point(103, 20);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(116, 20);
            this.txtCodigoProd.TabIndex = 7;
            // 
            // btnAgregarClienteXPedido
            // 
            this.btnAgregarClienteXPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarClienteXPedido.Location = new System.Drawing.Point(479, 17);
            this.btnAgregarClienteXPedido.Name = "btnAgregarClienteXPedido";
            this.btnAgregarClienteXPedido.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClienteXPedido.TabIndex = 6;
            this.btnAgregarClienteXPedido.Text = "Agregar";
            this.btnAgregarClienteXPedido.UseVisualStyleBackColor = true;
            this.btnAgregarClienteXPedido.Click += new System.EventHandler(this.btnAgregarClienteXPedido_Click);
            // 
            // txtCantProd
            // 
            this.txtCantProd.Location = new System.Drawing.Point(103, 70);
            this.txtCantProd.Name = "txtCantProd";
            this.txtCantProd.Size = new System.Drawing.Size(97, 20);
            this.txtCantProd.TabIndex = 6;
            this.txtCantProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantProd_KeyPress);
            // 
            // btnModificarClienteXPedido
            // 
            this.btnModificarClienteXPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarClienteXPedido.Location = new System.Drawing.Point(479, 42);
            this.btnModificarClienteXPedido.Name = "btnModificarClienteXPedido";
            this.btnModificarClienteXPedido.Size = new System.Drawing.Size(75, 23);
            this.btnModificarClienteXPedido.TabIndex = 3;
            this.btnModificarClienteXPedido.Text = "Modificar";
            this.btnModificarClienteXPedido.UseVisualStyleBackColor = true;
            this.btnModificarClienteXPedido.Click += new System.EventHandler(this.btnModificarClienteXPedido_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad:";
            // 
            // btnBuscarProdXPedido
            // 
            this.btnBuscarProdXPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProdXPedido.Location = new System.Drawing.Point(233, 17);
            this.btnBuscarProdXPedido.Name = "btnBuscarProdXPedido";
            this.btnBuscarProdXPedido.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProdXPedido.TabIndex = 2;
            this.btnBuscarProdXPedido.Text = "Buscar";
            this.btnBuscarProdXPedido.UseVisualStyleBackColor = true;
            this.btnBuscarProdXPedido.Click += new System.EventHandler(this.btnBuscarProdXPedido_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPedido);
            this.groupBox2.Location = new System.Drawing.Point(10, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del pedido";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal});
            this.dgvPedido.Location = new System.Drawing.Point(14, 24);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(404, 85);
            this.dgvPedido.TabIndex = 0;
            this.dgvPedido.Click += new System.EventHandler(this.dgvPedido_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "P.U.";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 80;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 90;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(454, 110);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(90, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Razón social:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "RUC:";
            // 
            // txtRazSocCliente
            // 
            this.txtRazSocCliente.Enabled = false;
            this.txtRazSocCliente.Location = new System.Drawing.Point(103, 45);
            this.txtRazSocCliente.Name = "txtRazSocCliente";
            this.txtRazSocCliente.Size = new System.Drawing.Size(210, 20);
            this.txtRazSocCliente.TabIndex = 5;
            // 
            // txtRUCCliente
            // 
            this.txtRUCCliente.Enabled = false;
            this.txtRUCCliente.Location = new System.Drawing.Point(103, 20);
            this.txtRUCCliente.Name = "txtRUCCliente";
            this.txtRUCCliente.Size = new System.Drawing.Size(115, 20);
            this.txtRUCCliente.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha:";
            // 
            // dateTimePedido
            // 
            this.dateTimePedido.Location = new System.Drawing.Point(56, 110);
            this.dateTimePedido.Name = "dateTimePedido";
            this.dateTimePedido.Size = new System.Drawing.Size(337, 20);
            this.dateTimePedido.TabIndex = 8;
            // 
            // btnBuscarClienteXPedido
            // 
            this.btnBuscarClienteXPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClienteXPedido.Location = new System.Drawing.Point(232, 18);
            this.btnBuscarClienteXPedido.Name = "btnBuscarClienteXPedido";
            this.btnBuscarClienteXPedido.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarClienteXPedido.TabIndex = 9;
            this.btnBuscarClienteXPedido.Text = "Buscar";
            this.btnBuscarClienteXPedido.UseVisualStyleBackColor = true;
            this.btnBuscarClienteXPedido.Click += new System.EventHandler(this.btnBuscarClienteXPedido_Click);
            // 
            // gBoxCli
            // 
            this.gBoxCli.Controls.Add(this.label6);
            this.gBoxCli.Controls.Add(this.label7);
            this.gBoxCli.Controls.Add(this.btnBuscarClienteXPedido);
            this.gBoxCli.Controls.Add(this.txtRazSocCliente);
            this.gBoxCli.Controls.Add(this.txtRUCCliente);
            this.gBoxCli.Location = new System.Drawing.Point(10, 137);
            this.gBoxCli.Name = "gBoxCli";
            this.gBoxCli.Size = new System.Drawing.Size(429, 72);
            this.gBoxCli.TabIndex = 10;
            this.gBoxCli.TabStop = false;
            this.gBoxCli.Text = "Datos del cliente";
            // 
            // btnCerrarPedido
            // 
            this.btnCerrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPedido.Location = new System.Drawing.Point(495, 70);
            this.btnCerrarPedido.Name = "btnCerrarPedido";
            this.btnCerrarPedido.Size = new System.Drawing.Size(80, 20);
            this.btnCerrarPedido.TabIndex = 13;
            this.btnCerrarPedido.Text = "CERRAR";
            this.btnCerrarPedido.UseVisualStyleBackColor = false;
            this.btnCerrarPedido.Click += new System.EventHandler(this.btnCerrarPedido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // gbxPed2
            // 
            this.gbxPed2.Controls.Add(this.btnCancelar);
            this.gbxPed2.Controls.Add(this.btnBuscarPedido);
            this.gbxPed2.Location = new System.Drawing.Point(460, 313);
            this.gbxPed2.Name = "gbxPed2";
            this.gbxPed2.Size = new System.Drawing.Size(115, 122);
            this.gbxPed2.TabIndex = 16;
            this.gbxPed2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(12, 81);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedido.Location = new System.Drawing.Point(12, 25);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(91, 39);
            this.btnBuscarPedido.TabIndex = 3;
            this.btnBuscarPedido.Text = "Busca a un pedido aquí";
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // gbxPed1
            // 
            this.gbxPed1.Controls.Add(this.btnAgregarPedido);
            this.gbxPed1.Location = new System.Drawing.Point(460, 147);
            this.gbxPed1.Name = "gbxPed1";
            this.gbxPed1.Size = new System.Drawing.Size(115, 51);
            this.gbxPed1.TabIndex = 15;
            this.gbxPed1.TabStop = false;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.Location = new System.Drawing.Point(12, 17);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(91, 23);
            this.btnAgregarPedido.TabIndex = 0;
            this.btnAgregarPedido.Text = "Nuevo";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "PEN";
            // 
            // frmAdmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxPed2);
            this.Controls.Add(this.gbxPed1);
            this.Controls.Add(this.btnCerrarPedido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gBoxCli);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dateTimePedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBoxProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmPedido";
            this.Text = "frmAdmPedido";
            this.gBoxProd.ResumeLayout(false);
            this.gBoxProd.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.gBoxCli.ResumeLayout(false);
            this.gBoxCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxPed2.ResumeLayout(false);
            this.gbxPed1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxProd;
        private System.Windows.Forms.Button btnBuscarProdXPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificarClienteXPedido;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.TextBox txtCantProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarClienteXPedido;
        private System.Windows.Forms.TextBox txtNombProd;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRazSocCliente;
        private System.Windows.Forms.TextBox txtRUCCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePedido;
        private System.Windows.Forms.Button btnBuscarClienteXPedido;
        private System.Windows.Forms.GroupBox gBoxCli;
        private System.Windows.Forms.Button btnQuitarClienteXPedido;
        private System.Windows.Forms.Button btnCerrarPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxPed2;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.GroupBox gbxPed1;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}