using System;
using System.Windows.Forms;

namespace Vista {
    public partial class frmGestionarPagoPedido : Form {
        private frmBusquedaPedido frmBusquedaPedido;
        private estado frmState;
        public frmGestionarPagoPedido() {
            InitializeComponent();
            AdmComboBox.manipCombo("EstadoPedido", "nombre", cboEstadoPedido);
        }

        public estado Estado { get => frmState; set => frmState = value; }

        private void btnCerrarPago_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }
        private void btnBuscarPago_Click(object sender, EventArgs e)
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
        private void btnCancelarPago_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }
    }
}
