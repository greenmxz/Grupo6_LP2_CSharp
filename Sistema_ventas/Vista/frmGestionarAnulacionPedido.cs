using System;
using System.Windows.Forms;
using Modelo;

namespace Vista {
    public partial class frmGestionarAnulacionPedido : Form {
        private frmBusquedaPedido frmBusquedaPedido;
        private estado frmState;
        private Usuario login;
        public frmGestionarAnulacionPedido(Usuario user) {
            InitializeComponent();
            AdminDB.manipCombo("EstadoPedido", "nombre", cboEstadoPedido);
            login = user;
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

                //frmBusquedaPedido.MdiParent = this.ParentForm;
                frmBusquedaPedido.Show();
                frmBusquedaPedido.StartPosition = FormStartPosition.Manual;
                frmBusquedaPedido.Left = 588;

                frmBusquedaPedido.Top = 112;
                //frmBusquedaPedido.ShowDialog();
            }
            //MessageBox.Show("gg");

            if (frmBusquedaPedido.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("gg");
                //dgvAnuPedido.Rows.Clear();
                Pedido p = frmBusquedaPedido.PedidoSelecc;
                txtAnuPedidoId.Text = p.IdPedido.ToString();
                txtAnuPedidoRuc.Text = p.DatoCliente.Ruc;

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
