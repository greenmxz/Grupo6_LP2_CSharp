namespace Vista
{
    partial class frmBusquedaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaPedido));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrarBusqPedido = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelecPed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPedido,
            this.TotalVenta,
            this.RUC,
            this.NombreCliente});
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(390, 233);
            this.dataGridView1.TabIndex = 1;
            // 
            // NumeroPedido
            // 
            this.NumeroPedido.HeaderText = "Numero de pedido";
            this.NumeroPedido.Name = "NumeroPedido";
            this.NumeroPedido.ReadOnly = true;
            this.NumeroPedido.Width = 90;
            // 
            // TotalVenta
            // 
            this.TotalVenta.HeaderText = "Total";
            this.TotalVenta.Name = "TotalVenta";
            this.TotalVenta.ReadOnly = true;
            this.TotalVenta.Width = 60;
            // 
            // RUC
            // 
            this.RUC.HeaderText = "RUC";
            this.RUC.Name = "RUC";
            this.RUC.ReadOnly = true;
            this.RUC.Width = 90;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // btnCerrarBusqPedido
            // 
            this.btnCerrarBusqPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarBusqPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarBusqPedido.Location = new System.Drawing.Point(330, 70);
            this.btnCerrarBusqPedido.Name = "btnCerrarBusqPedido";
            this.btnCerrarBusqPedido.Size = new System.Drawing.Size(80, 20);
            this.btnCerrarBusqPedido.TabIndex = 3;
            this.btnCerrarBusqPedido.Text = "CERRAR";
            this.btnCerrarBusqPedido.UseVisualStyleBackColor = true;
            this.btnCerrarBusqPedido.Click += new System.EventHandler(this.btnCerrarBusqPedido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelecPed
            // 
            this.btnSelecPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecPed.Location = new System.Drawing.Point(135, 365);
            this.btnSelecPed.Name = "btnSelecPed";
            this.btnSelecPed.Size = new System.Drawing.Size(150, 23);
            this.btnSelecPed.TabIndex = 5;
            this.btnSelecPed.Text = "SELECCIONAR";
            this.btnSelecPed.UseVisualStyleBackColor = true;
            this.btnSelecPed.Click += new System.EventHandler(this.btnSelecPed_Click);
            // 
            // frmBusquedaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 400);
            this.Controls.Add(this.btnSelecPed);
            this.Controls.Add(this.btnCerrarBusqPedido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedaPedido";
            this.Text = "frmBusquedaPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCerrarBusqPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelecPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
    }
}