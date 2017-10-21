using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Vista_menu
{
    public enum estado { Nuevo,Cerrado}
    public partial class frmMenuInicio : Form {
        private frmAdmCliente frmAdmCliente;
        private frmAdmProducto frmAdmProducto;
        private frmAdmProveedor frmAdmProv;
        private frmCabecera cabecera;
        public frmMenuInicio(frmCabecera cabecera) {
            
            InitializeComponent();
            this.cabecera = cabecera;
            //lblNombreUsuario.Text = nombreUsuario;
            //Color cMenu = Color.FromArgb(34, 45, 49);
            //BackColor = cMenu;
            //Visible = true;
            //Size = new Size(150,500);
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 0;
            this.Top = 111;

        }





        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();   
        }



        //boton clientes
        private void btnClientes_Click(object sender, EventArgs e) {
            if (frmAdmCliente == null || frmAdmCliente.Estado == Vista.estado.Cerrado) {
                frmAdmCliente = new frmAdmCliente();
                frmAdmCliente.MdiParent = this.MdiParent;
                frmAdmCliente.StartPosition = FormStartPosition.Manual;
                //frmAdmCliente.Left = 244;
                frmAdmCliente.Left = 0;
                frmAdmCliente.Top = 112;
                frmAdmCliente.Show();
                this.Dispose();
                cabecera.Abierto = false;


            }
        }

        private void btnClientes_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
        }
        //boton pedidos
        private void btnPedidos_Click(object sender, EventArgs e) {
            frmAdmPedidoRegistrar form = new frmAdmPedidoRegistrar();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnPedidos_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
        }

        private void btnPedidos_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
        }
        //bton productos
        private void btnProductos_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
        }

        private void btnProductos_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
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
        //boton proveedores
        private void btnProveedores_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
        }

        private void btnProveedores_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
        }

        private void btnProveedores_Click(object sender, EventArgs e) {
            if (frmAdmCliente == null || frmAdmCliente.Estado == Vista.estado.Cerrado) {
                frmAdmProv = new frmAdmProveedor();
                frmAdmProv.MdiParent = this.MdiParent;

                frmAdmProv.StartPosition = FormStartPosition.Manual;
                //frmAdmProv.Left = 244;
                frmAdmProv.Left = 0;
                frmAdmProv.Top = 112;
                frmAdmProv.Show();
                this.Dispose();
                cabecera.Abierto = false;
            }
        }
    }
}
