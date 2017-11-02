using System;
using System.Windows.Forms;

namespace Vista.Vista_menu
{
    public enum estado { Nuevo,Cerrado}
    public partial class frmMenuInicioAdm : Form {
        private frmAdmCliente frmAdmCliente;
        private frmAdmProducto frmAdmProducto;
        private frmAdmPedido frmAdmPedido;
        private frmCabecera cabecera;
        /* INICIO */
        public frmMenuInicioAdm(frmCabecera cabecera) {
            
            InitializeComponent();
            this.cabecera = cabecera;
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 0;
            this.Top = 111;

        }
        /* CLIENTES */
        private void btnClientes_Click(object sender, EventArgs e) {
            if (frmAdmCliente == null || frmAdmCliente.Estado == Vista.estado.Cerrado) {
                frmAdmCliente = new frmAdmCliente();
                frmAdmCliente.MdiParent = this.MdiParent;
                frmAdmCliente.StartPosition = FormStartPosition.Manual;
                frmAdmCliente.Left = 0;
                frmAdmCliente.Top = 112;
                frmAdmCliente.Show();
                this.Dispose();
                cabecera.Abierto = false;


            }
        }

        private void btnClientes_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
            btnClientes.FlatStyle = FlatStyle.Popup;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
            btnClientes.FlatStyle = FlatStyle.Flat;
        }
        /* PEDIDOS */
        private void btnPedidos_Click(object sender, EventArgs e) {
            if (frmAdmPedido == null || frmAdmCliente.Estado == Vista.estado.Cerrado) {
                frmAdmPedido = new frmAdmPedido();
                frmAdmPedido.MdiParent = this.MdiParent;
                frmAdmPedido.StartPosition = FormStartPosition.Manual;
                frmAdmPedido.Left = 0;
                frmAdmPedido.Top = 112;
                frmAdmPedido.Show();
                this.Dispose();
                cabecera.Abierto = false;


            }
        }

        private void btnPedidos_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
            btnPedidos.FlatStyle = FlatStyle.Popup;
        }

        private void btnPedidos_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
            btnPedidos.FlatStyle = FlatStyle.Flat;
        }
        /* PRODUCTOS */
        private void btnProductos_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
            btnProductos.FlatStyle = FlatStyle.Popup;
        }

        private void btnProductos_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
            btnProductos.FlatStyle = FlatStyle.Flat;
        }
        private void btnProductos_Click(object sender, EventArgs e) {
            if (frmAdmProducto == null || frmAdmProducto.Estado == Vista.estado.Cerrado) {
                frmAdmProducto = new frmAdmProducto();
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
