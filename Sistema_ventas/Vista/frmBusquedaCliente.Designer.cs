namespace Vista
{
    partial class frmBusquedaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaCliente));
            this.dgvBusquedaCliente = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrarBusqCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelecCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusquedaCliente
            // 
            this.dgvBusquedaCliente.AllowUserToAddRows = false;
            this.dgvBusquedaCliente.AllowUserToDeleteRows = false;
            this.dgvBusquedaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.RUC,
            this.RazonSocial});
            this.dgvBusquedaCliente.Location = new System.Drawing.Point(23, 119);
            this.dgvBusquedaCliente.Name = "dgvBusquedaCliente";
            this.dgvBusquedaCliente.ReadOnly = true;
            this.dgvBusquedaCliente.Size = new System.Drawing.Size(385, 233);
            this.dgvBusquedaCliente.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // RUC
            // 
            this.RUC.HeaderText = "RUC";
            this.RUC.Name = "RUC";
            this.RUC.ReadOnly = true;
            this.RUC.Width = 80;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 200;
            // 
            // btnCerrarBusqCliente
            // 
            this.btnCerrarBusqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarBusqCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarBusqCliente.Location = new System.Drawing.Point(330, 70);
            this.btnCerrarBusqCliente.Name = "btnCerrarBusqCliente";
            this.btnCerrarBusqCliente.Size = new System.Drawing.Size(80, 20);
            this.btnCerrarBusqCliente.TabIndex = 8;
            this.btnCerrarBusqCliente.Text = "CERRAR";
            this.btnCerrarBusqCliente.UseVisualStyleBackColor = true;
            this.btnCerrarBusqCliente.Click += new System.EventHandler(this.btnCerrarBusqCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelecCli
            // 
            this.btnSelecCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecCli.Location = new System.Drawing.Point(135, 366);
            this.btnSelecCli.Name = "btnSelecCli";
            this.btnSelecCli.Size = new System.Drawing.Size(150, 23);
            this.btnSelecCli.TabIndex = 7;
            this.btnSelecCli.Text = "SELECCIONAR";
            this.btnSelecCli.UseVisualStyleBackColor = true;
            this.btnSelecCli.Click += new System.EventHandler(this.btnSelecCli_Click);
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 400);
            this.Controls.Add(this.btnCerrarBusqCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelecCli);
            this.Controls.Add(this.dgvBusquedaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedaCliente";
            this.Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBusquedaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.Button btnCerrarBusqCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelecCli;
    }
}