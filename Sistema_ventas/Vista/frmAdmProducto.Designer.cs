namespace Vista {
    partial class frmAdmProducto {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmProducto));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtStockIni = new System.Windows.Forms.TextBox();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxProd3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.gbxProd2 = new System.Windows.Forms.GroupBox();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnLimpiarProducto = new System.Windows.Forms.Button();
            this.gbxProd1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnCerrarProducto = new System.Windows.Forms.Button();
            this.pBoxI1 = new System.Windows.Forms.PictureBox();
            this.tip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxProd3.SuspendLayout();
            this.gbxProd2.SuspendLayout();
            this.gbxProd1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxI1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(103, 140);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(76, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // txtStockIni
            // 
            this.txtStockIni.Location = new System.Drawing.Point(103, 190);
            this.txtStockIni.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockIni.Name = "txtStockIni";
            this.txtStockIni.Size = new System.Drawing.Size(54, 20);
            this.txtStockIni.TabIndex = 2;
            this.txtStockIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockIni_KeyPress);
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(103, 165);
            this.txtPU.Margin = new System.Windows.Forms.Padding(2);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(76, 20);
            this.txtPU.TabIndex = 3;
            this.txtPU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPU_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(103, 75);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(311, 60);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio Unitario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 25);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pBoxI1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtPU);
            this.groupBox1.Controls.Add(this.txtStockIni);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(10, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(432, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "PEN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gbxProd3
            // 
            this.gbxProd3.Controls.Add(this.btnBuscarProducto);
            this.gbxProd3.Location = new System.Drawing.Point(461, 299);
            this.gbxProd3.Name = "gbxProd3";
            this.gbxProd3.Size = new System.Drawing.Size(115, 70);
            this.gbxProd3.TabIndex = 13;
            this.gbxProd3.TabStop = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Location = new System.Drawing.Point(12, 18);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(91, 39);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Busca a un producto aquí";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // gbxProd2
            // 
            this.gbxProd2.Controls.Add(this.btnModificarProducto);
            this.gbxProd2.Controls.Add(this.btnEliminarProducto);
            this.gbxProd2.Controls.Add(this.btnLimpiarProducto);
            this.gbxProd2.Location = new System.Drawing.Point(461, 180);
            this.gbxProd2.Name = "gbxProd2";
            this.gbxProd2.Size = new System.Drawing.Size(115, 109);
            this.gbxProd2.TabIndex = 12;
            this.gbxProd2.TabStop = false;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.Location = new System.Drawing.Point(12, 16);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(91, 23);
            this.btnModificarProducto.TabIndex = 1;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Location = new System.Drawing.Point(12, 45);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(91, 23);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProducto.Location = new System.Drawing.Point(12, 74);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiarProducto.TabIndex = 6;
            this.btnLimpiarProducto.Text = "Limpiar";
            this.btnLimpiarProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarProducto.Click += new System.EventHandler(this.btnLimpiarProducto_Click);
            // 
            // gbxProd1
            // 
            this.gbxProd1.Controls.Add(this.btnAgregarProducto);
            this.gbxProd1.Location = new System.Drawing.Point(461, 118);
            this.gbxProd1.Name = "gbxProd1";
            this.gbxProd1.Size = new System.Drawing.Size(115, 51);
            this.gbxProd1.TabIndex = 11;
            this.gbxProd1.TabStop = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 16);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(91, 23);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Registrar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnCerrarProducto
            // 
            this.btnCerrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarProducto.Location = new System.Drawing.Point(495, 70);
            this.btnCerrarProducto.Name = "btnCerrarProducto";
            this.btnCerrarProducto.Size = new System.Drawing.Size(80, 20);
            this.btnCerrarProducto.TabIndex = 14;
            this.btnCerrarProducto.Text = "CERRAR";
            this.btnCerrarProducto.UseVisualStyleBackColor = false;
            this.btnCerrarProducto.Click += new System.EventHandler(this.btnCerrarProducto_Click);
            // 
            // pBoxI1
            // 
            this.pBoxI1.Image = ((System.Drawing.Image)(resources.GetObject("pBoxI1.Image")));
            this.pBoxI1.Location = new System.Drawing.Point(181, 140);
            this.pBoxI1.Name = "pBoxI1";
            this.pBoxI1.Size = new System.Drawing.Size(20, 20);
            this.pBoxI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxI1.TabIndex = 15;
            this.pBoxI1.TabStop = false;
            // 
            // frmAdmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 400);
            this.Controls.Add(this.btnCerrarProducto);
            this.Controls.Add(this.gbxProd3);
            this.Controls.Add(this.gbxProd2);
            this.Controls.Add(this.gbxProd1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmProducto";
            this.Text = "Administrar Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxProd3.ResumeLayout(false);
            this.gbxProd2.ResumeLayout(false);
            this.gbxProd1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxI1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtStockIni;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxProd3;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.GroupBox gbxProd2;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnLimpiarProducto;
        private System.Windows.Forms.GroupBox gbxProd1;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnCerrarProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pBoxI1;
        private System.Windows.Forms.ToolTip tip1;
    }
}