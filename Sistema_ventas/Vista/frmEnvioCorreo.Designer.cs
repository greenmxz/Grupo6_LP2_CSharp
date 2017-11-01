namespace Vista
{
    partial class frmEnvioCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvioCorreo));
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrarEnvioCorreo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCorreo = new System.Windows.Forms.GroupBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCCO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxCorreo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(121, 113);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(137, 21);
            this.cboTipo.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tipo de documento:";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(67, 20);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(290, 20);
            this.txtPara.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Para:";
            // 
            // btnCerrarEnvioCorreo
            // 
            this.btnCerrarEnvioCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarEnvioCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarEnvioCorreo.Location = new System.Drawing.Point(311, 74);
            this.btnCerrarEnvioCorreo.Name = "btnCerrarEnvioCorreo";
            this.btnCerrarEnvioCorreo.Size = new System.Drawing.Size(80, 20);
            this.btnCerrarEnvioCorreo.TabIndex = 50;
            this.btnCerrarEnvioCorreo.Text = "CERRAR";
            this.btnCerrarEnvioCorreo.UseVisualStyleBackColor = false;
            this.btnCerrarEnvioCorreo.Click += new System.EventHandler(this.btnCerrarEnvioCorreo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(67, 95);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(290, 20);
            this.txtAsunto.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Asunto:";
            // 
            // gbxCorreo
            // 
            this.gbxCorreo.Controls.Add(this.txtDetalle);
            this.gbxCorreo.Controls.Add(this.label4);
            this.gbxCorreo.Controls.Add(this.txtCCO);
            this.gbxCorreo.Controls.Add(this.label3);
            this.gbxCorreo.Controls.Add(this.txtCC);
            this.gbxCorreo.Controls.Add(this.label2);
            this.gbxCorreo.Controls.Add(this.txtPara);
            this.gbxCorreo.Controls.Add(this.txtAsunto);
            this.gbxCorreo.Controls.Add(this.label6);
            this.gbxCorreo.Controls.Add(this.label1);
            this.gbxCorreo.Location = new System.Drawing.Point(15, 143);
            this.gbxCorreo.Name = "gbxCorreo";
            this.gbxCorreo.Size = new System.Drawing.Size(373, 233);
            this.gbxCorreo.TabIndex = 53;
            this.gbxCorreo.TabStop = false;
            this.gbxCorreo.Text = "Detalles";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(24, 138);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(333, 82);
            this.txtDetalle.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Mensaje:";
            // 
            // txtCCO
            // 
            this.txtCCO.Location = new System.Drawing.Point(67, 70);
            this.txtCCO.Name = "txtCCO";
            this.txtCCO.Size = new System.Drawing.Size(290, 20);
            this.txtCCO.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "CCO:";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(67, 45);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(290, 20);
            this.txtCC.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "CC:";
            // 
            // btnSelecProd
            // 
            this.btnSelecProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecProd.Location = new System.Drawing.Point(125, 390);
            this.btnSelecProd.Name = "btnSelecProd";
            this.btnSelecProd.Size = new System.Drawing.Size(150, 23);
            this.btnSelecProd.TabIndex = 54;
            this.btnSelecProd.Text = "ENVIAR";
            this.btnSelecProd.UseVisualStyleBackColor = true;
            this.btnSelecProd.Click += new System.EventHandler(this.btnSelecProd_Click);
            // 
            // frmEnvioCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 430);
            this.Controls.Add(this.btnSelecProd);
            this.Controls.Add(this.gbxCorreo);
            this.Controls.Add(this.btnCerrarEnvioCorreo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnvioCorreo";
            this.Text = "frmEnvioCorreo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxCorreo.ResumeLayout(false);
            this.gbxCorreo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrarEnvioCorreo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCorreo;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCCO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelecProd;
    }
}