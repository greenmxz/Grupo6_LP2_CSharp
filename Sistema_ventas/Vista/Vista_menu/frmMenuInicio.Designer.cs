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
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(27, 89);
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
            this.lblPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.White;
            this.lblPedidos.Location = new System.Drawing.Point(27, 149);
            this.lblPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(112, 44);
            this.lblPedidos.TabIndex = 1;
            this.lblPedidos.Text = "Administrar Pedidos";
            this.lblPedidos.Click += new System.EventHandler(this.lblPedidos_Click);
            this.lblPedidos.MouseEnter += new System.EventHandler(this.lblPedidos_MouseEnter);
            this.lblPedidos.MouseLeave += new System.EventHandler(this.lblPedidos_MouseLeave);
            this.lblPedidos.MouseHover += new System.EventHandler(this.lblPedidos_MouseHover);
            // 
            // lblProductos
            // 
            this.lblProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.White;
            this.lblProductos.Location = new System.Drawing.Point(27, 227);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(112, 44);
            this.lblProductos.TabIndex = 2;
            this.lblProductos.Text = "Administrar Productos";
            this.lblProductos.Click += new System.EventHandler(this.lblProductos_Click_1);
            this.lblProductos.MouseEnter += new System.EventHandler(this.lblProductos_MouseEnter);
            this.lblProductos.MouseLeave += new System.EventHandler(this.lblProductos_MouseLeave);
            this.lblProductos.MouseHover += new System.EventHandler(this.lblProductos_MouseHover);
            // 
            // lblProveedores
            // 
            this.lblProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(66)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnProveedores);
            this.panel1.Controls.Add(this.lblClientes);
            this.panel1.Controls.Add(this.lblProveedores);
            this.panel1.Controls.Add(this.lblPedidos);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 531);
            this.panel1.TabIndex = 4;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedidos.BackgroundImage")));
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Location = new System.Drawing.Point(12, 368);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(165, 39);
            this.btnPedidos.TabIndex = 7;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            this.btnPedidos.MouseEnter += new System.EventHandler(this.btnPedidos_MouseEnter);
            this.btnPedidos.MouseLeave += new System.EventHandler(this.btnPedidos_MouseLeave);
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.BackgroundImage")));
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Location = new System.Drawing.Point(12, 413);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(165, 39);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(12, 35);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(165, 39);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.MouseEnter += new System.EventHandler(this.btnClientes_MouseEnter);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btnClientes_MouseLeave);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.BackgroundImage")));
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Location = new System.Drawing.Point(12, 458);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(165, 39);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // frmMenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(189, 531);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuInicio";
            this.Text = "|";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
    }
}