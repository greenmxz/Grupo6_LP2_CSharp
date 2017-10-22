﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista {
    public partial class frmGestionarDocumentoPago : Form {
        private estado frmState;
        private frmBusquedaPedido frmBusquedaPedido;
        public frmGestionarDocumentoPago() {
            InitializeComponent();
        }

        public estado Estado { get => frmState; set => frmState = value; }

        private void btnBuscarPedido_Click(object sender, EventArgs e) {
            frmBusquedaPedido = new frmBusquedaPedido();
            frmBusquedaPedido.MdiParent = this.ParentForm;
            frmBusquedaPedido.Show();
            frmBusquedaPedido.StartPosition = FormStartPosition.Manual;
            frmBusquedaPedido.Left = 588;

            frmBusquedaPedido.Top = 112;
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }
    }
}