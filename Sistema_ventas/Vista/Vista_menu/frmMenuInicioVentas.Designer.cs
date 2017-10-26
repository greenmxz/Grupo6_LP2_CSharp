namespace Vista.Vista_menu {
    partial class frmMenuInicioVentas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuInicioVentas));
            this.btnDocumentoPago = new System.Windows.Forms.Button();
            this.btnAnulacionPedido = new System.Windows.Forms.Button();
            this.btnPagoPedido = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDocumentoPago
            // 
            this.btnDocumentoPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocumentoPago.BackgroundImage")));
            this.btnDocumentoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDocumentoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentoPago.Location = new System.Drawing.Point(12, 97);
            this.btnDocumentoPago.Name = "btnDocumentoPago";
            this.btnDocumentoPago.Size = new System.Drawing.Size(165, 40);
            this.btnDocumentoPago.TabIndex = 0;
            this.btnDocumentoPago.UseVisualStyleBackColor = true;
            this.btnDocumentoPago.Click += new System.EventHandler(this.btnDocumentoPago_Click);
            this.btnDocumentoPago.MouseEnter += new System.EventHandler(this.btnDocumentoPago_MouseEnter);
            this.btnDocumentoPago.MouseLeave += new System.EventHandler(this.btnDocumentoPago_MouseLeave);
            // 
            // btnAnulacionPedido
            // 
            this.btnAnulacionPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnulacionPedido.BackgroundImage")));
            this.btnAnulacionPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnulacionPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnulacionPedido.Location = new System.Drawing.Point(12, 147);
            this.btnAnulacionPedido.Name = "btnAnulacionPedido";
            this.btnAnulacionPedido.Size = new System.Drawing.Size(165, 40);
            this.btnAnulacionPedido.TabIndex = 1;
            this.btnAnulacionPedido.UseVisualStyleBackColor = true;
            this.btnAnulacionPedido.Click += new System.EventHandler(this.btnAnulacionPedido_Click);
            this.btnAnulacionPedido.MouseEnter += new System.EventHandler(this.btnAnulacionPedido_MouseEnter);
            this.btnAnulacionPedido.MouseLeave += new System.EventHandler(this.btnAnulacionPedido_MouseLeave);
            // 
            // btnPagoPedido
            // 
            this.btnPagoPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPagoPedido.BackgroundImage")));
            this.btnPagoPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPagoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoPedido.Location = new System.Drawing.Point(12, 197);
            this.btnPagoPedido.Name = "btnPagoPedido";
            this.btnPagoPedido.Size = new System.Drawing.Size(165, 40);
            this.btnPagoPedido.TabIndex = 2;
            this.btnPagoPedido.UseVisualStyleBackColor = true;
            this.btnPagoPedido.Click += new System.EventHandler(this.btnPagoPedido_Click);
            this.btnPagoPedido.MouseEnter += new System.EventHandler(this.btnPagoPedido_MouseEnter);
            this.btnPagoPedido.MouseLeave += new System.EventHandler(this.bbtnPagoPedido_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnDocumentoPago);
            this.panel1.Controls.Add(this.btnPagoPedido);
            this.panel1.Controls.Add(this.btnAnulacionPedido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 412);
            this.panel1.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 247);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(165, 40);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            this.btnCerrarSesion.MouseEnter += new System.EventHandler(this.btnCerrarSesion_MouseEnter);
            this.btnCerrarSesion.MouseLeave += new System.EventHandler(this.btnCerrarSesion_MouseLeave);
            // 
            // frmMenuInicioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(189, 412);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuInicioVentas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDocumentoPago;
        private System.Windows.Forms.Button btnAnulacionPedido;
        private System.Windows.Forms.Button btnPagoPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}