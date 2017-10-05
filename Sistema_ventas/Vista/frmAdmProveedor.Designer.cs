namespace Vista
{
    partial class frmAdmProveedor
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
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.gbxBasicoProveedor = new System.Windows.Forms.GroupBox();
            this.txtRazSocProveedores = new System.Windows.Forms.TextBox();
            this.lblRazSocProveedor = new System.Windows.Forms.Label();
            this.txtRUCProveedores = new System.Windows.Forms.TextBox();
            this.lblRUCProveedor = new System.Windows.Forms.Label();
            this.txtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.gbxContactoProveedor = new System.Windows.Forms.GroupBox();
            this.cboDistritoProveedor = new System.Windows.Forms.ComboBox();
            this.lblDistritoProveedor = new System.Windows.Forms.Label();
            this.txtDirProveedores = new System.Windows.Forms.TextBox();
            this.lblDirProveedor = new System.Windows.Forms.Label();
            this.txtDirElecProveedores = new System.Windows.Forms.TextBox();
            this.txtTlfProveedores = new System.Windows.Forms.TextBox();
            this.lblDirElecProveedor = new System.Windows.Forms.Label();
            this.lblTlfProveedor = new System.Windows.Forms.Label();
            this.btnLimpiarProveedor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloProveedor = new System.Windows.Forms.Label();
            this.btnCerrarProveedor = new System.Windows.Forms.Button();
            this.gbxBasicoProveedor.SuspendLayout();
            this.gbxContactoProveedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(16, 552);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProveedor.TabIndex = 0;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Location = new System.Drawing.Point(92, 552);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProveedor.TabIndex = 1;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Location = new System.Drawing.Point(168, 552);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProveedor.TabIndex = 2;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(233, 182);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(89, 39);
            this.btnBuscarProveedor.TabIndex = 3;
            this.btnBuscarProveedor.Text = "Busca a un proveedor aquí";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // gbxBasicoProveedor
            // 
            this.gbxBasicoProveedor.Controls.Add(this.txtRazSocProveedores);
            this.gbxBasicoProveedor.Controls.Add(this.lblRazSocProveedor);
            this.gbxBasicoProveedor.Controls.Add(this.txtRUCProveedores);
            this.gbxBasicoProveedor.Controls.Add(this.lblRUCProveedor);
            this.gbxBasicoProveedor.Controls.Add(this.txtCodigoProveedor);
            this.gbxBasicoProveedor.Controls.Add(this.lblCodigoProveedor);
            this.gbxBasicoProveedor.Location = new System.Drawing.Point(17, 244);
            this.gbxBasicoProveedor.Name = "gbxBasicoProveedor";
            this.gbxBasicoProveedor.Size = new System.Drawing.Size(303, 114);
            this.gbxBasicoProveedor.TabIndex = 4;
            this.gbxBasicoProveedor.TabStop = false;
            this.gbxBasicoProveedor.Text = "Datos básicos";
            // 
            // txtRazSocProveedores
            // 
            this.txtRazSocProveedores.Location = new System.Drawing.Point(103, 70);
            this.txtRazSocProveedores.Name = "txtRazSocProveedores";
            this.txtRazSocProveedores.Size = new System.Drawing.Size(191, 20);
            this.txtRazSocProveedores.TabIndex = 5;
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
            // txtRUCProveedores
            // 
            this.txtRUCProveedores.Location = new System.Drawing.Point(103, 45);
            this.txtRUCProveedores.Name = "txtRUCProveedores";
            this.txtRUCProveedores.Size = new System.Drawing.Size(120, 20);
            this.txtRUCProveedores.TabIndex = 3;
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
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Location = new System.Drawing.Point(103, 20);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoProveedor.TabIndex = 1;
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
            // gbxContactoProveedor
            // 
            this.gbxContactoProveedor.Controls.Add(this.cboDistritoProveedor);
            this.gbxContactoProveedor.Controls.Add(this.lblDistritoProveedor);
            this.gbxContactoProveedor.Controls.Add(this.txtDirProveedores);
            this.gbxContactoProveedor.Controls.Add(this.lblDirProveedor);
            this.gbxContactoProveedor.Controls.Add(this.txtDirElecProveedores);
            this.gbxContactoProveedor.Controls.Add(this.txtTlfProveedores);
            this.gbxContactoProveedor.Controls.Add(this.lblDirElecProveedor);
            this.gbxContactoProveedor.Controls.Add(this.lblTlfProveedor);
            this.gbxContactoProveedor.Location = new System.Drawing.Point(17, 384);
            this.gbxContactoProveedor.Name = "gbxContactoProveedor";
            this.gbxContactoProveedor.Size = new System.Drawing.Size(303, 132);
            this.gbxContactoProveedor.TabIndex = 5;
            this.gbxContactoProveedor.TabStop = false;
            this.gbxContactoProveedor.Text = "Medios de contacto";
            // 
            // cboDistritoProveedor
            // 
            this.cboDistritoProveedor.FormattingEnabled = true;
            this.cboDistritoProveedor.Location = new System.Drawing.Point(103, 96);
            this.cboDistritoProveedor.Name = "cboDistritoProveedor";
            this.cboDistritoProveedor.Size = new System.Drawing.Size(191, 21);
            this.cboDistritoProveedor.TabIndex = 12;
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
            // txtDirProveedores
            // 
            this.txtDirProveedores.Location = new System.Drawing.Point(103, 71);
            this.txtDirProveedores.Name = "txtDirProveedores";
            this.txtDirProveedores.Size = new System.Drawing.Size(191, 20);
            this.txtDirProveedores.TabIndex = 10;
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
            // txtDirElecProveedores
            // 
            this.txtDirElecProveedores.Location = new System.Drawing.Point(103, 46);
            this.txtDirElecProveedores.Name = "txtDirElecProveedores";
            this.txtDirElecProveedores.Size = new System.Drawing.Size(191, 20);
            this.txtDirElecProveedores.TabIndex = 8;
            // 
            // txtTlfProveedores
            // 
            this.txtTlfProveedores.Location = new System.Drawing.Point(103, 21);
            this.txtTlfProveedores.Name = "txtTlfProveedores";
            this.txtTlfProveedores.Size = new System.Drawing.Size(97, 20);
            this.txtTlfProveedores.TabIndex = 6;
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
            // btnLimpiarProveedor
            // 
            this.btnLimpiarProveedor.Location = new System.Drawing.Point(244, 552);
            this.btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            this.btnLimpiarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarProveedor.TabIndex = 6;
            this.btnLimpiarProveedor.Text = "Limpiar";
            this.btnLimpiarProveedor.UseVisualStyleBackColor = true;
            this.btnLimpiarProveedor.Click += new System.EventHandler(this.btnLimpiarProveedor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.btnCerrarProveedor);
            this.panel1.Controls.Add(this.lblTituloProveedor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 137);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloProveedor
            // 
            this.lblTituloProveedor.AutoSize = true;
            this.lblTituloProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProveedor.Location = new System.Drawing.Point(162, 52);
            this.lblTituloProveedor.Name = "lblTituloProveedor";
            this.lblTituloProveedor.Size = new System.Drawing.Size(216, 24);
            this.lblTituloProveedor.TabIndex = 1;
            this.lblTituloProveedor.Text = "Administrar proveedores";
            // 
            // btnCerrarProveedor
            // 
            this.btnCerrarProveedor.Location = new System.Drawing.Point(289, 10);
            this.btnCerrarProveedor.Name = "btnCerrarProveedor";
            this.btnCerrarProveedor.Size = new System.Drawing.Size(33, 23);
            this.btnCerrarProveedor.TabIndex = 2;
            this.btnCerrarProveedor.Text = "X";
            this.btnCerrarProveedor.UseVisualStyleBackColor = true;
            this.btnCerrarProveedor.Click += new System.EventHandler(this.btnCerrarProveedor_Click);
            // 
            // frmAdmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiarProveedor);
            this.Controls.Add(this.gbxContactoProveedor);
            this.Controls.Add(this.gbxBasicoProveedor);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 137);
            this.Name = "frmAdmProveedor";
            this.Text = "Administración de Proveedores";
            this.Load += new System.EventHandler(this.frmAdmProveedor_Load);
            this.gbxBasicoProveedor.ResumeLayout(false);
            this.gbxBasicoProveedor.PerformLayout();
            this.gbxContactoProveedor.ResumeLayout(false);
            this.gbxContactoProveedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.GroupBox gbxBasicoProveedor;
        private System.Windows.Forms.GroupBox gbxContactoProveedor;
        private System.Windows.Forms.TextBox txtCodigoProveedor;
        private System.Windows.Forms.Label lblCodigoProveedor;
        private System.Windows.Forms.TextBox txtRUCProveedores;
        private System.Windows.Forms.Label lblRUCProveedor;
        private System.Windows.Forms.TextBox txtRazSocProveedores;
        private System.Windows.Forms.Label lblRazSocProveedor;
        private System.Windows.Forms.Label lblTlfProveedor;
        private System.Windows.Forms.Label lblDistritoProveedor;
        private System.Windows.Forms.TextBox txtDirProveedores;
        private System.Windows.Forms.Label lblDirProveedor;
        private System.Windows.Forms.TextBox txtDirElecProveedores;
        private System.Windows.Forms.TextBox txtTlfProveedores;
        private System.Windows.Forms.Label lblDirElecProveedor;
        private System.Windows.Forms.Button btnLimpiarProveedor;
        private System.Windows.Forms.ComboBox cboDistritoProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTituloProveedor;
        private System.Windows.Forms.Button btnCerrarProveedor;
    }
}