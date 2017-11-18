using System;
using System.Windows.Forms;
using Modelo;

namespace Vista.Vista_menu
{
    public enum estado { Nuevo,Cerrado}
    public partial class frmMenuInicioAdm : Form {
        private frmAdmCliente frmAdmCliente;
        private frmAdmProducto frmAdmProducto;
        private frmAdmPedido frmAdmPedido;
        private frmCabecera cabecera;
        private Usuario login;
        /* INICIO */
        public frmMenuInicioAdm(frmCabecera cabecera, Usuario user) {
            InitializeComponent();
            this.cabecera = cabecera;
            StartPosition = FormStartPosition.Manual;
            Left = 0;
            Top = 111;
            login = user;
        }
        /* CLIENTES */
        private void btnClientes_Click(object sender, EventArgs e) {
            if (frmAdmCliente == null || frmAdmCliente.Estado == Vista.estado.Cerrado) {
                frmAdmCliente = new frmAdmCliente(login);
                frmAdmCliente.MdiParent = MdiParent;
                frmAdmCliente.StartPosition = FormStartPosition.Manual;
                frmAdmCliente.Left = 0;
                frmAdmCliente.Top = 112;
                frmAdmCliente.Show();
                Dispose();
                cabecera.Abierto = false;
            }
        }

        private void btnClientes_MouseEnter(object sender, EventArgs e) {
            Cursor = Cursors.Hand;
            btnClientes.FlatStyle = FlatStyle.Popup;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
            btnClientes.FlatStyle = FlatStyle.Flat;
        }
        /* PEDIDOS */
        private void btnPedidos_Click(object sender, EventArgs e) {
            if (frmAdmPedido == null || frmAdmCliente.Estado == Vista.estado.Cerrado) {
                frmAdmPedido = new frmAdmPedido(login);
                frmAdmPedido.MdiParent = this.MdiParent;
                frmAdmPedido.StartPosition = FormStartPosition.Manual;
                frmAdmPedido.Left = 0;
                frmAdmPedido.Top = 112;
                frmAdmPedido.Show();
                Dispose();
                cabecera.Abierto = false;
            }
        }

        private void btnPedidos_MouseEnter(object sender, EventArgs e) {
            Cursor = Cursors.Hand;
            btnPedidos.FlatStyle = FlatStyle.Popup;
        }

        private void btnPedidos_MouseLeave(object sender, EventArgs e) {
            Cursor = Cursors.Default;
            btnPedidos.FlatStyle = FlatStyle.Flat;
        }
        /* PRODUCTOS */
        private void btnProductos_MouseEnter(object sender, EventArgs e) {
            Cursor = Cursors.Hand;
            btnProductos.FlatStyle = FlatStyle.Popup;
        }

        private void btnProductos_MouseLeave(object sender, EventArgs e) {
            Cursor = Cursors.Default;
            btnProductos.FlatStyle = FlatStyle.Flat;
        }
        private void btnProductos_Click(object sender, EventArgs e) {
            if (frmAdmProducto == null || frmAdmProducto.Estado == Vista.estado.Cerrado) {
                frmAdmProducto = new frmAdmProducto(login);
                frmAdmProducto.MdiParent = this.MdiParent;
                frmAdmProducto.StartPosition = FormStartPosition.Manual;
                //frmAdmProducto.Left = 244;
                frmAdmProducto.Left = 0;
                frmAdmProducto.Top = 112;
                frmAdmProducto.Show();
                this.Dispose();
                cabecera.Abierto = false;

            }
        }
        /* CERRAR SESIÓN */
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MdiParent.Close();
        }
        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
        }
        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
        }

    }
}
