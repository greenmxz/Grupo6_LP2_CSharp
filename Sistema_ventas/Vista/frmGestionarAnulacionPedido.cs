using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista {
    public partial class frmGestionarAnulacionPedido : Form {
        private frmBusquedaPedido frmBusquedaPedido;
        private estado frmState;
        public frmGestionarAnulacionPedido() {
            InitializeComponent();
            AdmComboBox.manipCombo("EstadoPedido", "nombre", cboEstadoPedido);
        }

        public estado Estado { get => frmState; set => frmState = value; }
        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }

        private void btnBuscarAnulacion_Click(object sender, EventArgs e)
        {
            if (frmBusquedaPedido == null || frmBusquedaPedido.Estado == estado.Cerrado)
            {
                frmBusquedaPedido = new frmBusquedaPedido();
                frmBusquedaPedido.MdiParent = this.ParentForm;
                frmBusquedaPedido.Show();
                frmBusquedaPedido.StartPosition = FormStartPosition.Manual;
                frmBusquedaPedido.Left = 588;

                frmBusquedaPedido.Top = 112;
            }
        }

        private void btnCancelarAnulacion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }

        private void btnCerrarProveedor_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }
    }
}
