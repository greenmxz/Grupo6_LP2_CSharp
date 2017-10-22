namespace Vista
{
    partial class frmAdmCliente
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarCliente = new System.Windows.Forms.Button();
            this.gbxButton3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarClient = new System.Windows.Forms.Button();
            this.gbxButton2 = new System.Windows.Forms.GroupBox();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.gbxButton1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.gbxContactoCliente = new System.Windows.Forms.GroupBox();
            this.cboDistritoCliente = new System.Windows.Forms.ComboBox();
            this.lblDistritoProveedor = new System.Windows.Forms.Label();
            this.txtDirCliente = new System.Windows.Forms.TextBox();
            this.lblDirProveedor = new System.Windows.Forms.Label();
            this.txtDirElecCliente = new System.Windows.Forms.TextBox();
            this.txtTlfCliente = new System.Windows.Forms.TextBox();
            this.lblDirElecProveedor = new System.Windows.Forms.Label();
            this.lblTlfProveedor = new System.Windows.Forms.Label();
            this.gbxBasicoCliente = new System.Windows.Forms.GroupBox();
            this.txtRazSocCliente = new System.Windows.Forms.TextBox();
            this.lblRazSocProveedor = new System.Windows.Forms.Label();
            this.txtRUCCliente = new System.Windows.Forms.TextBox();
            this.lblRUCProveedor = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxButton3.SuspendLayout();
            this.gbxButton2.SuspendLayout();
            this.gbxButton1.SuspendLayout();
            this.gbxContactoCliente.SuspendLayout();
            this.gbxBasicoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarCliente
            // 
            this.btnCerrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCliente.Location = new System.Drawing.Point(484, 69);
            this.btnCerrarCliente.Name = "btnCerrarCliente";
            this.btnCerrarCliente.Size = new System.Drawing.Size(80, 20);
            this.btnCerrarCliente.TabIndex = 8;
            this.btnCerrarCliente.Text = "CERRAR";
            this.btnCerrarCliente.UseVisualStyleBackColor = false;
            this.btnCerrarCliente.Click += new System.EventHandler(this.btnCerrarCliente_Click);
            // 
            // gbxButton3
            // 
            this.gbxButton3.Controls.Add(this.btnBuscarClient);
            this.gbxButton3.Location = new System.Drawing.Point(453, 297);
            this.gbxButton3.Name = "gbxButton3";
            this.gbxButton3.Size = new System.Drawing.Size(115, 70);
            this.gbxButton3.TabIndex = 15;
            this.gbxButton3.TabStop = false;
            // 
            // btnBuscarClient
            // 
            this.btnBuscarClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClient.Location = new System.Drawing.Point(12, 18);
            this.btnBuscarClient.Name = "btnBuscarClient";
            this.btnBuscarClient.Size = new System.Drawing.Size(91, 39);
            this.btnBuscarClient.TabIndex = 3;
            this.btnBuscarClient.Text = "Busca a un proveedor aquí";
            this.btnBuscarClient.UseVisualStyleBackColor = true;
            this.btnBuscarClient.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // gbxButton2
            // 
            this.gbxButton2.Controls.Add(this.btnModificarCliente);
            this.gbxButton2.Controls.Add(this.btnEliminarCliente);
            this.gbxButton2.Controls.Add(this.btnLimpiarCliente);
            this.gbxButton2.Location = new System.Drawing.Point(453, 178);
            this.gbxButton2.Name = "gbxButton2";
            this.gbxButton2.Size = new System.Drawing.Size(115, 109);
            this.gbxButton2.TabIndex = 14;
            this.gbxButton2.TabStop = false;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Location = new System.Drawing.Point(12, 16);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(91, 23);
            this.btnModificarCliente.TabIndex = 1;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Location = new System.Drawing.Point(12, 45);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(91, 23);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCliente.Location = new System.Drawing.Point(12, 74);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiarCliente.TabIndex = 6;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            // 
            // gbxButton1
            // 
            this.gbxButton1.Controls.Add(this.btnAgregarCliente);
            this.gbxButton1.Location = new System.Drawing.Point(453, 116);
            this.gbxButton1.Name = "gbxButton1";
            this.gbxButton1.Size = new System.Drawing.Size(115, 51);
            this.gbxButton1.TabIndex = 13;
            this.gbxButton1.TabStop = false;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Location = new System.Drawing.Point(12, 16);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(91, 23);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Registrar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // gbxContactoCliente
            // 
            this.gbxContactoCliente.Controls.Add(this.cboDistritoCliente);
            this.gbxContactoCliente.Controls.Add(this.lblDistritoProveedor);
            this.gbxContactoCliente.Controls.Add(this.txtDirCliente);
            this.gbxContactoCliente.Controls.Add(this.lblDirProveedor);
            this.gbxContactoCliente.Controls.Add(this.txtDirElecCliente);
            this.gbxContactoCliente.Controls.Add(this.txtTlfCliente);
            this.gbxContactoCliente.Controls.Add(this.lblDirElecProveedor);
            this.gbxContactoCliente.Controls.Add(this.lblTlfProveedor);
            this.gbxContactoCliente.Location = new System.Drawing.Point(12, 235);
            this.gbxContactoCliente.Name = "gbxContactoCliente";
            this.gbxContactoCliente.Size = new System.Drawing.Size(416, 132);
            this.gbxContactoCliente.TabIndex = 12;
            this.gbxContactoCliente.TabStop = false;
            this.gbxContactoCliente.Text = "Medios de contacto";
            // 
            // cboDistritoCliente
            // 
            this.cboDistritoCliente.FormattingEnabled = true;
            this.cboDistritoCliente.Location = new System.Drawing.Point(103, 96);
            this.cboDistritoCliente.Name = "cboDistritoCliente";
            this.cboDistritoCliente.Size = new System.Drawing.Size(179, 21);
            this.cboDistritoCliente.TabIndex = 12;
            // 
            // lblDistritoProveedor
            // 
            this.lblDistritoProveedor.AutoSize = true;
            this.lblDistritoProveedor.Location = new System.Drawing.Point(58, 99);
            this.lblDistritoProveedor.Name = "lblDistritoProveedor";
            this.lblDistritoProveedor.Size = new System.Drawing.Size(42, 13);
            this.lblDistritoProveedor.TabIndex = 11;
            this.lblDistritoProveedor.Text = "Distrito:";
            // 
            // txtDirCliente
            // 
            this.txtDirCliente.Location = new System.Drawing.Point(103, 71);
            this.txtDirCliente.Name = "txtDirCliente";
            this.txtDirCliente.Size = new System.Drawing.Size(297, 20);
            this.txtDirCliente.TabIndex = 10;
            // 
            // lblDirProveedor
            // 
            this.lblDirProveedor.AutoSize = true;
            this.lblDirProveedor.Location = new System.Drawing.Point(45, 74);
            this.lblDirProveedor.Name = "lblDirProveedor";
            this.lblDirProveedor.Size = new System.Drawing.Size(55, 13);
            this.lblDirProveedor.TabIndex = 9;
            this.lblDirProveedor.Text = "Dirección:";
            // 
            // txtDirElecCliente
            // 
            this.txtDirElecCliente.Location = new System.Drawing.Point(103, 46);
            this.txtDirElecCliente.Name = "txtDirElecCliente";
            this.txtDirElecCliente.Size = new System.Drawing.Size(297, 20);
            this.txtDirElecCliente.TabIndex = 8;
            // 
            // txtTlfCliente
            // 
            this.txtTlfCliente.Location = new System.Drawing.Point(103, 21);
            this.txtTlfCliente.Name = "txtTlfCliente";
            this.txtTlfCliente.Size = new System.Drawing.Size(97, 20);
            this.txtTlfCliente.TabIndex = 6;
            // 
            // lblDirElecProveedor
            // 
            this.lblDirElecProveedor.AutoSize = true;
            this.lblDirElecProveedor.Location = new System.Drawing.Point(4, 50);
            this.lblDirElecProveedor.Name = "lblDirElecProveedor";
            this.lblDirElecProveedor.Size = new System.Drawing.Size(96, 13);
            this.lblDirElecProveedor.TabIndex = 7;
            this.lblDirElecProveedor.Text = "Correo electrónico:";
            // 
            // lblTlfProveedor
            // 
            this.lblTlfProveedor.AutoSize = true;
            this.lblTlfProveedor.Location = new System.Drawing.Point(48, 25);
            this.lblTlfProveedor.Name = "lblTlfProveedor";
            this.lblTlfProveedor.Size = new System.Drawing.Size(52, 13);
            this.lblTlfProveedor.TabIndex = 6;
            this.lblTlfProveedor.Text = "Teléfono:";
            // 
            // gbxBasicoCliente
            // 
            this.gbxBasicoCliente.Controls.Add(this.txtRazSocCliente);
            this.gbxBasicoCliente.Controls.Add(this.lblRazSocProveedor);
            this.gbxBasicoCliente.Controls.Add(this.txtRUCCliente);
            this.gbxBasicoCliente.Controls.Add(this.lblRUCProveedor);
            this.gbxBasicoCliente.Controls.Add(this.txtCodigoCliente);
            this.gbxBasicoCliente.Controls.Add(this.lblCodigoProveedor);
            this.gbxBasicoCliente.Location = new System.Drawing.Point(12, 116);
            this.gbxBasicoCliente.Name = "gbxBasicoCliente";
            this.gbxBasicoCliente.Size = new System.Drawing.Size(416, 102);
            this.gbxBasicoCliente.TabIndex = 11;
            this.gbxBasicoCliente.TabStop = false;
            this.gbxBasicoCliente.Text = "Datos básicos";
            // 
            // txtRazSocCliente
            // 
            this.txtRazSocCliente.Location = new System.Drawing.Point(103, 70);
            this.txtRazSocCliente.Name = "txtRazSocCliente";
            this.txtRazSocCliente.Size = new System.Drawing.Size(297, 20);
            this.txtRazSocCliente.TabIndex = 5;
            // 
            // lblRazSocProveedor
            // 
            this.lblRazSocProveedor.AutoSize = true;
            this.lblRazSocProveedor.Location = new System.Drawing.Point(30, 73);
            this.lblRazSocProveedor.Name = "lblRazSocProveedor";
            this.lblRazSocProveedor.Size = new System.Drawing.Size(71, 13);
            this.lblRazSocProveedor.TabIndex = 4;
            this.lblRazSocProveedor.Text = "Razón social:";
            // 
            // txtRUCCliente
            // 
            this.txtRUCCliente.Location = new System.Drawing.Point(103, 45);
            this.txtRUCCliente.Name = "txtRUCCliente";
            this.txtRUCCliente.Size = new System.Drawing.Size(120, 20);
            this.txtRUCCliente.TabIndex = 3;
            // 
            // lblRUCProveedor
            // 
            this.lblRUCProveedor.AutoSize = true;
            this.lblRUCProveedor.Location = new System.Drawing.Point(69, 48);
            this.lblRUCProveedor.Name = "lblRUCProveedor";
            this.lblRUCProveedor.Size = new System.Drawing.Size(33, 13);
            this.lblRUCProveedor.TabIndex = 2;
            this.lblRUCProveedor.Text = "RUC:";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Enabled = false;
            this.txtCodigoCliente.Location = new System.Drawing.Point(103, 20);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoCliente.TabIndex = 1;
            // 
            // lblCodigoProveedor
            // 
            this.lblCodigoProveedor.AutoSize = true;
            this.lblCodigoProveedor.Location = new System.Drawing.Point(59, 23);
            this.lblCodigoProveedor.Name = "lblCodigoProveedor";
            this.lblCodigoProveedor.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoProveedor.TabIndex = 0;
            this.lblCodigoProveedor.Text = "Código:";
            // 
            // frmAdmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(580, 390);
            this.Controls.Add(this.gbxButton3);
            this.Controls.Add(this.gbxButton2);
            this.Controls.Add(this.gbxButton1);
            this.Controls.Add(this.gbxContactoCliente);
            this.Controls.Add(this.gbxBasicoCliente);
            this.Controls.Add(this.btnCerrarCliente);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(244, 0);
            this.Name = "frmAdmCliente";
            this.Text = "Administrar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxButton3.ResumeLayout(false);
            this.gbxButton2.ResumeLayout(false);
            this.gbxButton1.ResumeLayout(false);
            this.gbxContactoCliente.ResumeLayout(false);
            this.gbxContactoCliente.PerformLayout();
            this.gbxBasicoCliente.ResumeLayout(false);
            this.gbxBasicoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarCliente;
        private System.Windows.Forms.GroupBox gbxButton3;
        private System.Windows.Forms.Button btnBuscarClient;
        private System.Windows.Forms.GroupBox gbxButton2;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.GroupBox gbxButton1;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.GroupBox gbxContactoCliente;
        private System.Windows.Forms.ComboBox cboDistritoCliente;
        private System.Windows.Forms.Label lblDistritoProveedor;
        private System.Windows.Forms.TextBox txtDirCliente;
        private System.Windows.Forms.Label lblDirProveedor;
        private System.Windows.Forms.TextBox txtDirElecCliente;
        private System.Windows.Forms.TextBox txtTlfCliente;
        private System.Windows.Forms.Label lblDirElecProveedor;
        private System.Windows.Forms.Label lblTlfProveedor;
        private System.Windows.Forms.GroupBox gbxBasicoCliente;
        private System.Windows.Forms.TextBox txtRazSocCliente;
        private System.Windows.Forms.Label lblRazSocProveedor;
        private System.Windows.Forms.TextBox txtRUCCliente;
        private System.Windows.Forms.Label lblRUCProveedor;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblCodigoProveedor;
    }
}