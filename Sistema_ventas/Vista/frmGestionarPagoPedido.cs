using System;
using System.Windows.Forms;
using Modelo;

namespace Vista {
    public partial class frmGestionarPagoPedido : Form {
        private frmBusquedaPedido frmBusquedaPedido;
        private estado frmState;
        private Usuario login;
        public frmGestionarPagoPedido(Usuario user) {
            InitializeComponent();
            AdminDB.manipCombo("EstadoPedido", "nombre", cboEstadoPedido);
            login = user;
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

            if (frmBusquedaPedido.DialogResult == DialogResult.OK)
            {
               
                //dgvAnuPedido.Rows.Clear();
                Pedido p = frmBusquedaPedido.PedidoSelecc;
                txtPagoPedidoId.Text = p.IdPedido.ToString();
                

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
