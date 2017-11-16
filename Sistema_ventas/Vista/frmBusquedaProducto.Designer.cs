namespace Vista
{
    partial class frmBusquedaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaProducto));
            this.dgvBuscProducto = new System.Windows.Forms.DataGridView();
            this.btnCerrarBusqProducto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelecProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscProducto
            // 
            this.dgvBuscProducto.AllowUserToAddRows = false;
            this.dgvBuscProducto.AllowUserToDeleteRows = false;
            this.dgvBuscProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscProducto.Location = new System.Drawing.Point(13, 118);
            this.dgvBuscProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBuscProducto.Name = "dgvBuscProducto";
            this.dgvBuscProducto.ReadOnly = true;
            this.dgvBuscProducto.RowTemplate.Height = 24;
            this.dgvBuscProducto.Size = new System.Drawing.Size(396, 230);
            this.dgvBuscProducto.TabIndex = 0;
            // 
            // btnCerrarBusqProducto
            // 
            this.btnCerrarBusqProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarBusqProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarBusqProducto.Location = new System.Drawing.Point(330, 70);
            this.btnCerrarBusqProducto.Name = "btnCerrarBusqProducto";
            this.btnCerrarBusqProducto.Size = new System.Drawing.Size(80, 20);
            this.btnCerrarBusqProducto.TabIndex = 5;
            this.btnCerrarBusqProducto.Text = "CERRAR";
            this.btnCerrarBusqProducto.UseVisualStyleBackColor = true;
            this.btnCerrarBusqProducto.Click += new System.EventHandler(this.btnCerrarBusqProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelecProd
            // 
            this.btnSelecProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecProd.Location = new System.Drawing.Point(135, 366);
            this.btnSelecProd.Name = "btnSelecProd";
            this.btnSelecProd.Size = new System.Drawing.Size(150, 23);
            this.btnSelecProd.TabIndex = 4;
            this.btnSelecProd.Text = "SELECCIONAR";
            this.btnSelecProd.UseVisualStyleBackColor = true;
            this.btnSelecProd.Click += new System.EventHandler(this.btnSelecProd_Click);
            // 
            // frmBusquedaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 400);
            this.Controls.Add(this.btnCerrarBusqProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelecProd);
            this.Controls.Add(this.dgvBuscProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBusquedaProducto";
            this.Text = "frmBusquedaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBuscProducto;
        private System.Windows.Forms.Button btnCerrarBusqProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelecProd;
    }
}