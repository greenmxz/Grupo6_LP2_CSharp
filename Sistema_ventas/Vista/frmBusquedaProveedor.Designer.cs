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
            this.btnSelecProv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelecProv
            // 
            this.btnSelecProv.Location = new System.Drawing.Point(225, 12);
            this.btnSelecProv.Name = "btnSelecProv";
            this.btnSelecProv.Size = new System.Drawing.Size(144, 23);
            this.btnSelecProv.TabIndex = 0;
            this.btnSelecProv.Text = "Seleccionar proveedor";
            this.btnSelecProv.UseVisualStyleBackColor = true;
            this.btnSelecProv.Click += new System.EventHandler(this.btnSelecProv_Click);
            // 
            // frmBusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 261);
            this.Controls.Add(this.btnSelecProv);
            this.Name = "frmBusquedaProveedor";
            this.Text = "Búsqueda de proveedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecProv;
    }
}