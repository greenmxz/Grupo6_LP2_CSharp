namespace Vista
{
    partial class frmBusquedaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaProveedor));
            this.btnSelecProv = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarBusqProveedor = new System.Windows.Forms.Button();
            this.lblTituloBusqProv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvProvCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProvRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProvRazSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecProv
            // 
            this.btnSelecProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecProv.Location = new System.Drawing.Point(258, 172);
            this.btnSelecProv.Name = "btnSelecProv";
            this.btnSelecProv.Size = new System.Drawing.Size(144, 23);
            this.btnSelecProv.TabIndex = 0;
            this.btnSelecProv.Text = "Seleccionar proveedor";
            this.btnSelecProv.UseVisualStyleBackColor = true;
            this.btnSelecProv.Click += new System.EventHandler(this.btnSelecProv_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.btnCerrarBusqProveedor);
            this.panel1.Controls.Add(this.lblTituloBusqProv);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 137);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrarBusqProveedor
            // 
            this.btnCerrarBusqProveedor.Location = new System.Drawing.Point(371, 12);
            this.btnCerrarBusqProveedor.Name = "btnCerrarBusqProveedor";
            this.btnCerrarBusqProveedor.Size = new System.Drawing.Size(31, 23);
            this.btnCerrarBusqProveedor.TabIndex = 2;
            this.btnCerrarBusqProveedor.Text = "X";
            this.btnCerrarBusqProveedor.UseVisualStyleBackColor = true;
            this.btnCerrarBusqProveedor.Click += new System.EventHandler(this.btnCerrarBusqProveedor_Click);
            // 
            // lblTituloBusqProv
            // 
            this.lblTituloBusqProv.AutoSize = true;
            this.lblTituloBusqProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBusqProv.Location = new System.Drawing.Point(185, 45);
            this.lblTituloBusqProv.Name = "lblTituloBusqProv";
            this.lblTituloBusqProv.Size = new System.Drawing.Size(60, 24);
            this.lblTituloBusqProv.TabIndex = 1;
            this.lblTituloBusqProv.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProvCod,
            this.dgvProvRUC,
            this.dgvProvRazSoc});
            this.dataGridView1.Location = new System.Drawing.Point(13, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 247);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgvProvCod
            // 
            this.dgvProvCod.HeaderText = "Código";
            this.dgvProvCod.Name = "dgvProvCod";
            this.dgvProvCod.Width = 60;
            // 
            // dgvProvRUC
            // 
            this.dgvProvRUC.HeaderText = "RUC";
            this.dgvProvRUC.Name = "dgvProvRUC";
            // 
            // dgvProvRazSoc
            // 
            this.dgvProvRazSoc.HeaderText = "Razón Social";
            this.dgvProvRazSoc.Name = "dgvProvRazSoc";
            this.dgvProvRazSoc.Width = 185;
            // 
            // frmBusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 544);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelecProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedaProveedor";
            this.Text = "Búsqueda de proveedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecProv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTituloBusqProv;
        private System.Windows.Forms.Button btnCerrarBusqProveedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProvCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProvRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProvRazSoc;
    }
}