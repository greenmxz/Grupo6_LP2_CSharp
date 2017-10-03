namespace Vista
{
    partial class frmAdmClienteModificar
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
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblRUC = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCoreroElectronico = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.lblTelefono);
            this.gbDatosCliente.Controls.Add(this.lblDireccion);
            this.gbDatosCliente.Controls.Add(this.lblCoreroElectronico);
            this.gbDatosCliente.Controls.Add(this.lblRazonSocial);
            this.gbDatosCliente.Controls.Add(this.lblRUC);
            this.gbDatosCliente.Controls.Add(this.lblCodigo);
            this.gbDatosCliente.Controls.Add(this.txtTelefono);
            this.gbDatosCliente.Controls.Add(this.txtDireccion);
            this.gbDatosCliente.Controls.Add(this.txtCorreoElectronico);
            this.gbDatosCliente.Controls.Add(this.txtRazonSocial);
            this.gbDatosCliente.Controls.Add(this.txtRUC);
            this.gbDatosCliente.Controls.Add(this.txtCodigo);
            this.gbDatosCliente.Location = new System.Drawing.Point(23, 12);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(274, 190);
            this.gbDatosCliente.TabIndex = 0;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(132, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(132, 47);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(100, 20);
            this.txtRUC.TabIndex = 1;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(132, 74);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(132, 101);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoElectronico.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(132, 128);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(132, 155);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código:";
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.Location = new System.Drawing.Point(25, 53);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRUC.Size = new System.Drawing.Size(33, 13);
            this.lblRUC.TabIndex = 7;
            this.lblRUC.Text = "RUC:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(25, 81);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 8;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // lblCoreroElectronico
            // 
            this.lblCoreroElectronico.AutoSize = true;
            this.lblCoreroElectronico.Location = new System.Drawing.Point(25, 108);
            this.lblCoreroElectronico.Name = "lblCoreroElectronico";
            this.lblCoreroElectronico.Size = new System.Drawing.Size(97, 13);
            this.lblCoreroElectronico.TabIndex = 9;
            this.lblCoreroElectronico.Text = "Correo Eléctronico:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(25, 135);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(25, 162);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(332, 12);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(51, 218);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(180, 218);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmAdmClienteModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 278);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.gbDatosCliente);
            this.Name = "frmAdmClienteModificar";
            this.Text = "Modificar Cliente";
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCoreroElectronico;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}