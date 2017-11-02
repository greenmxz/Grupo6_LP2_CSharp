using System;
using System.Windows.Forms;

namespace Vista {
    public partial class frmGestionarDocumentoPago : Form {
        private estado frmState;
        private frmBusquedaPedido frmBusquedaPedido;
        public frmGestionarDocumentoPago() {
            InitializeComponent();
        }

        public estado Estado { get => frmState; set => frmState = value; }

        private void btnCerrarDocum_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }

        private void btnCancelarDocum_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }
        private void btnBuscarDocum_Click(object sender, EventArgs e)
        {
            frmBusquedaPedido = new frmBusquedaPedido();
            frmBusquedaPedido.MdiParent = this.ParentForm;
            frmBusquedaPedido.Show();
            frmBusquedaPedido.StartPosition = FormStartPosition.Manual;
            frmBusquedaPedido.Left = 588;

            frmBusquedaPedido.Top = 112;
        }
        private void btnEnviarDocum_Click(object sender, EventArgs e)
        {
            frmEnvioCorreo envio = new frmEnvioCorreo();
            envio.MdiParent = this.ParentForm;
            envio.Show();
            envio.StartPosition = FormStartPosition.Manual;
            envio.Left = 588;
            envio.Top = 112;
        }
    }
}
