using System;
using System.Windows.Forms;
using Modelo;

namespace Vista.Vista_menu {
    public partial class frmMenuInicioVentas : Form {
        private frmGestionarDocumentoPago frmGestionarDocumentoPago;
        private frmGestionarPagoPedido frmGestionarPagoPedido;
        private frmGestionarAnulacionPedido frmAnulacionPedido;
        private frmCabecera cabecera;
        private Usuario login;
        public frmMenuInicioVentas(frmCabecera cabecera, Usuario user) {
            InitializeComponent();
            this.cabecera = cabecera;
            StartPosition = FormStartPosition.Manual;
            Left = 0;
            Top = 111;
            login = user;
        }
        //boton documento de pago
        private void btnDocumentoPago_Click(object sender, EventArgs e) {
            if (frmGestionarDocumentoPago == null || frmGestionarDocumentoPago.Estado == Vista.estado.Cerrado) {
                frmGestionarDocumentoPago = new frmGestionarDocumentoPago();
                frmGestionarDocumentoPago.MdiParent = this.ParentForm;
                frmGestionarDocumentoPago.Show();

                frmGestionarDocumentoPago.StartPosition = FormStartPosition.Manual;
                frmGestionarDocumentoPago.Left = 0;
                frmGestionarDocumentoPago.Top = 112;
                this.Dispose();
                cabecera.Abierto = false;
            }
        }

        private void btnDocumentoPago_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
            btnDocumentoPago.FlatStyle = FlatStyle.Popup;
        }

        private void btnDocumentoPago_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
            btnDocumentoPago.FlatStyle = FlatStyle.Flat;
        }

        //boton anulacion pedido
        private void btnAnulacionPedido_Click(object sender, EventArgs e) {
            if (frmAnulacionPedido == null || frmAnulacionPedido.Estado == Vista.estado.Cerrado) {
                frmAnulacionPedido = new frmGestionarAnulacionPedido();
                frmAnulacionPedido.MdiParent = this.ParentForm;
                frmAnulacionPedido.Show();

                frmAnulacionPedido.StartPosition = FormStartPosition.Manual;
                frmAnulacionPedido.Left = 0;
                frmAnulacionPedido.Top = 112;
                this.Dispose();
                cabecera.Abierto = false;
            }
        }
        private void btnAnulacionPedido_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
            btnAnulacionPedido.FlatStyle = FlatStyle.Popup;
        }

        private void btnAnulacionPedido_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
            btnAnulacionPedido.FlatStyle = FlatStyle.Flat;
        }
        //boton pago pedido

        private void btnPagoPedido_Click(object sender, EventArgs e) {
            if (frmGestionarPagoPedido == null || frmGestionarPagoPedido.Estado == Vista.estado.Cerrado) {
                frmGestionarPagoPedido = new frmGestionarPagoPedido();
                frmGestionarPagoPedido.MdiParent = this.ParentForm;
                frmGestionarPagoPedido.Show();

                frmGestionarPagoPedido.StartPosition = FormStartPosition.Manual;
                frmGestionarPagoPedido.Left = 0;
                frmGestionarPagoPedido.Top = 112;
                this.Dispose();
                cabecera.Abierto = false;
            }
        }
        private void btnPagoPedido_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
            btnPagoPedido.FlatStyle = FlatStyle.Popup;
        }

        private void bbtnPagoPedido_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
            btnPagoPedido.FlatStyle = FlatStyle.Flat;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.MdiParent.Close();
        }

        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
        }

        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
        }
    }
}
