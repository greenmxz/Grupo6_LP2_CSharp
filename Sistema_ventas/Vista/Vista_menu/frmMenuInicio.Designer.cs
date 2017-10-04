namespace Vista.Vista_menu {
    partial class frmMenuInicio {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuInicio));
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pbImagenUsuario = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(27, 71);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblClientes.Size = new System.Drawing.Size(112, 44);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Administrar Clientes";
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            this.lblClientes.MouseEnter += new System.EventHandler(this.lblClientes_MouseEnter);
            this.lblClientes.MouseLeave += new System.EventHandler(this.lblClientes_MouseLeave);
            this.lblClientes.MouseHover += new System.EventHandler(this.lblClientes_MouseHover);
            // 
            // lblPedidos
            // 
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.White;
            this.lblPedidos.Location = new System.Drawing.Point(27, 149);
            this.lblPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(112, 44);
            this.lblPedidos.TabIndex = 1;
            this.lblPedidos.Text = "Administrar Pedidos";
            this.lblPedidos.MouseEnter += new System.EventHandler(this.lblPedidos_MouseEnter);
            this.lblPedidos.MouseLeave += new System.EventHandler(this.lblPedidos_MouseLeave);
            this.lblPedidos.MouseHover += new System.EventHandler(this.lblPedidos_MouseHover);
            // 
            // lblProductos
            // 
            this.lblProductos.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.White;
            this.lblProductos.Location = new System.Drawing.Point(27, 227);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(112, 44);
            this.lblProductos.TabIndex = 2;
            this.lblProductos.Text = "Administrar Productos";
            this.lblProductos.MouseEnter += new System.EventHandler(this.lblProductos_MouseEnter);
            this.lblProductos.MouseLeave += new System.EventHandler(this.lblProductos_MouseLeave);
            this.lblProductos.MouseHover += new System.EventHandler(this.lblProductos_MouseHover);
            // 
            // lblProveedores
            // 
            this.lblProveedores.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.ForeColor = System.Drawing.Color.White;
            this.lblProveedores.Location = new System.Drawing.Point(27, 305);
            this.lblProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(112, 44);
            this.lblProveedores.TabIndex = 3;
            this.lblProveedores.Text = "Administrar Proveedores";
            this.lblProveedores.Click += new System.EventHandler(this.lblProveedores_Click);
            this.lblProveedores.MouseEnter += new System.EventHandler(this.lblProveedores_MouseEnter);
            this.lblProveedores.MouseLeave += new System.EventHandler(this.lblProveedores_MouseLeave);
            this.lblProveedores.MouseHover += new System.EventHandler(this.lblProveedores_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEntrada);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.lblClientes);
            this.panel1.Controls.Add(this.lblProveedores);
            this.panel1.Controls.Add(this.lblPedidos);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 505);
            this.panel1.TabIndex = 4;
            // 
            // lblEntrada
            // 
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft JhengHei", 15F);
            this.lblEntrada.ForeColor = System.Drawing.Color.White;
            this.lblEntrada.Location = new System.Drawing.Point(3, 14);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(104, 24);
            this.lblEntrada.TabIndex = 5;
            this.lblEntrada.Text = "Menu";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(49, 400);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(113, 28);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBienvenida);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNombreUsuario);
            this.panel2.Controls.Add(this.pbImagenUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 176);
            this.panel2.TabIndex = 5;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft JhengHei", 15F);
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(8, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(116, 25);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perfil de usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(94, 49);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(134, 30);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // pbImagenUsuario
            // 
            this.pbImagenUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbImagenUsuario.Image")));
            this.pbImagenUsuario.Location = new System.Drawing.Point(13, 49);
            this.pbImagenUsuario.Name = "pbImagenUsuario";
            this.pbImagenUsuario.Size = new System.Drawing.Size(74, 72);
            this.pbImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenUsuario.TabIndex = 0;
            this.pbImagenUsuario.TabStop = false;
            // 
            // frmMenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(240, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuInicio";
            this.Text = "frmMenuInicio";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox pbImagenUsuario;
        private System.Windows.Forms.Label lblBienvenida;
    }
}