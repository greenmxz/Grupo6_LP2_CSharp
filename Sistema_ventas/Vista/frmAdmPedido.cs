using System;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class frmAdmPedido : Form
    {
        private estado frmState;
        private Cliente cliseleccionado;
        private Producto prodSeleccionado;
        private frmBusquedaPedido frmBusquedaPedido;
        private frmBusquedaCliente frmBusqCli;
        private frmBusquedaProducto frmBusqProd;

        private double total = 0;
        public frmAdmPedido()
        {
            InitializeComponent();
            cliseleccionado = new Cliente();
            prodSeleccionado = new Producto();
            txtTotal.Text = string.Format("{0:0.00}", total);
        }
        public estado Estado { get => frmState; set => frmState = value; }
        private void btnBuscarPedido_Click(object sender, EventArgs e) {
            if (frmBusquedaPedido == null || frmBusquedaPedido.Estado == estado.Cerrado) {


                frmBusquedaPedido = new frmBusquedaPedido();
                frmBusquedaPedido.Estado = estado.Nuevo;
                frmBusquedaPedido.MdiParent = this.MdiParent;

                frmBusquedaPedido.StartPosition = FormStartPosition.Manual;
                frmBusquedaPedido.Left = 588;

                frmBusquedaPedido.Top = 112;

                frmBusquedaPedido.Visible = true;
            }
        }
        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }
        private void btnBuscarClienteXPedido_Click(object sender, EventArgs e)
        {
            //if (frmBusqCli == null || frmBusqCli.Estado == estado.Cerrado)
            //{
                frmBusqCli = new frmBusquedaCliente();
                frmBusqCli.Estado = estado.Nuevo;
                frmBusqCli.MdiParent = this.MdiParent;

                frmBusqCli.StartPosition = FormStartPosition.Manual;
                frmBusqCli.Left = 588;
                frmBusqCli.Top = 112;
                frmBusqCli.Visible = true;
            //}
        }
        private void btnBuscarProdXPedido_Click(object sender, EventArgs e)
        {
            //if (frmBusqProd == null || frmBusqProd.Estado == estado.Cerrado)
            //{
            frmBusqProd = new frmBusquedaProducto();
            if (frmBusqProd.ShowDialog() == DialogResult.OK)
            {
                prodSeleccionado = frmBusqProd.Producto;
                txtCodigoProd.Text = prodSeleccionado.Id.ToString();
                txtNombProd.Text = prodSeleccionado.Nombre;                
                
            }
            
                frmBusqProd.Estado = estado.Nuevo;
                frmBusqProd.MdiParent = this.MdiParent;

                frmBusqProd.StartPosition = FormStartPosition.Manual;
                frmBusqProd.Left = 588;
                frmBusqProd.Top = 112;
                //frmBusqProd.Visible = true;
            //}
        }
        private void btnAgregarClienteXPedido_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {

        }
    }
}