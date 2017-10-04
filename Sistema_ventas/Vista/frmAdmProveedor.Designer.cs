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
            this.gbxContactoProveedor = new System.Windows.Forms.GroupBox();
            this.lblCodigoProveedor = new System.Windows.Forms.Label();
            this.txtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.lblRUCProveedor = new System.Windows.Forms.Label();
            this.txtRUCProveedores = new System.Windows.Forms.TextBox();
            this.lblRazSocProveedor = new System.Windows.Forms.Label();
            this.txtRazSocProveedores = new System.Windows.Forms.TextBox();
            this.lblTlfProveedor = new System.Windows.Forms.Label();
            this.lblDirElecProveedor = new System.Windows.Forms.Label();
            this.txtTlfProveedores = new System.Windows.Forms.TextBox();
            this.txtDirElecProveedores = new System.Windows.Forms.TextBox();
            this.lblDirProveedor = new System.Windows.Forms.Label();
            this.txtDirProveedores = new System.Windows.Forms.TextBox();
            this.btnLimpiarProveedor = new System.Windows.Forms.Button();
            this.lblDistritoProveedor = new System.Windows.Forms.Label();
            this.cboDistritoProveedor = new System.Windows.Forms.ComboBox();
            this.gbxBasicoProveedor.SuspendLayout();
            this.gbxContactoProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(12, 20);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProveedor.TabIndex = 0;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Location = new System.Drawing.Point(88, 20);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProveedor.TabIndex = 1;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Location = new System.Drawing.Point(164, 20);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProveedor.TabIndex = 2;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(350, 12);
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
            this.gbxBasicoProveedor.Location = new System.Drawing.Point(12, 66);
            this.gbxBasicoProveedor.Name = "gbxBasicoProveedor";
            this.gbxBasicoProveedor.Size = new System.Drawing.Size(427, 114);
            this.gbxBasicoProveedor.TabIndex = 4;
            this.gbxBasicoProveedor.TabStop = false;
            this.gbxBasicoProveedor.Text = "Datos básicos";
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
            this.gbxContactoProveedor.Location = new System.Drawing.Point(12, 186);
            this.gbxContactoProveedor.Name = "gbxContactoProveedor";
            this.gbxContactoProveedor.Size = new System.Drawing.Size(427, 132);
            this.gbxContactoProveedor.TabIndex = 5;
            this.gbxContactoProveedor.TabStop = false;
            this.gbxContactoProveedor.Text = "Medios de contacto";
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
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Location = new System.Drawing.Point(103, 20);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoProveedor.TabIndex = 1;
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
            // txtRUCProveedores
            // 
            this.txtRUCProveedores.Location = new System.Drawing.Point(103, 45);
            this.txtRUCProveedores.Name = "txtRUCProveedores";
            this.txtRUCProveedores.Size = new System.Drawing.Size(120, 20);
            this.txtRUCProveedores.TabIndex = 3;
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
            // txtRazSocProveedores
            // 
            this.txtRazSocProveedores.Location = new System.Drawing.Point(103, 70);
            this.txtRazSocProveedores.Name = "txtRazSocProveedores";
            this.txtRazSocProveedores.Size = new System.Drawing.Size(308, 20);
            this.txtRazSocProveedores.TabIndex = 5;
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
            // lblDirElecProveedor
            // 
            this.lblDirElecProveedor.AutoSize = true;
            this.lblDirElecProveedor.Location = new System.Drawing.Point(4, 50);
            this.lblDirElecProveedor.Name = "lblDirElecProveedor";
            this.lblDirElecProveedor.Size = new System.Drawing.Size(96, 13);
            this.lblDirElecProveedor.TabIndex = 7;
            this.lblDirElecProveedor.Text = "Correo electrónico:";
            // 
            // txtTlfProveedores
            // 
            this.txtTlfProveedores.Location = new System.Drawing.Point(103, 21);
            this.txtTlfProveedores.Name = "txtTlfProveedores";
            this.txtTlfProveedores.Size = new System.Drawing.Size(97, 20);
            this.txtTlfProveedores.TabIndex = 6;
            // 
            // txtDirElecProveedores
            // 
            this.txtDirElecProveedores.Location = new System.Drawing.Point(103, 46);
            this.txtDirElecProveedores.Name = "txtDirElecProveedores";
            this.txtDirElecProveedores.Size = new System.Drawing.Size(308, 20);
            this.txtDirElecProveedores.TabIndex = 8;
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
            // txtDirProveedores
            // 
            this.txtDirProveedores.Location = new System.Drawing.Point(103, 71);
            this.txtDirProveedores.Name = "txtDirProveedores";
            this.txtDirProveedores.Size = new System.Drawing.Size(307, 20);
            this.txtDirProveedores.TabIndex = 10;
            // 
            // btnLimpiarProveedor
            // 
            this.btnLimpiarProveedor.Location = new System.Drawing.Point(240, 20);
            this.btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            this.btnLimpiarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarProveedor.TabIndex = 6;
            this.btnLimpiarProveedor.Text = "Limpiar";
            this.btnLimpiarProveedor.UseVisualStyleBackColor = true;
            this.btnLimpiarProveedor.Click += new System.EventHandler(this.btnLimpiarProveedor_Click);
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
            // cboDistritoProveedor
            // 
            this.cboDistritoProveedor.FormattingEnabled = true;
            this.cboDistritoProveedor.Location = new System.Drawing.Point(103, 96);
            this.cboDistritoProveedor.Name = "cboDistritoProveedor";
            this.cboDistritoProveedor.Size = new System.Drawing.Size(200, 21);
            this.cboDistritoProveedor.TabIndex = 12;
            // 
            // frmAdmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 329);
            this.Controls.Add(this.btnLimpiarProveedor);
            this.Controls.Add(this.gbxContactoProveedor);
            this.Controls.Add(this.gbxBasicoProveedor);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Name = "frmAdmProveedor";
            this.Text = "Administración de Proveedores";
            this.gbxBasicoProveedor.ResumeLayout(false);
            this.gbxBasicoProveedor.PerformLayout();
            this.gbxContactoProveedor.ResumeLayout(false);
            this.gbxContactoProveedor.PerformLayout();
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
    }
}