using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class frmAdmPedido : Form
    {
        private estado frmState;
        private Cliente cliseleccionado;
        private Producto prodSeleccionado;
        private Pedido pedido;
        private frmBusquedaPedido frmBusquedaPedido;
        private frmBusquedaCliente frmBusqCli;
        private frmBusquedaProducto frmBusqProd;
        
        private double total = 0;
        public frmAdmPedido()
        {
            InitializeComponent();
            cliseleccionado = new Cliente();
            prodSeleccionado = new Producto();
            pedido = new Pedido();
            txtTotal.Text = string.Format("{0:0.00}", total);
        }
        public estado Estado { get => frmState; set => frmState = value; }
        public Cliente Cliseleccionado { get => cliseleccionado; set => cliseleccionado = value; }
        public Producto ProdSeleccionado { get => prodSeleccionado; set => prodSeleccionado = value; }
        public Pedido Pedido { get => pedido; set => pedido = value; }

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
            if (frmBusqCli == null || frmBusqCli.Estado == estado.Cerrado)
            {
                frmBusqCli = new frmBusquedaCliente();
                frmBusqCli.Estado = estado.Nuevo;
                //frmCli.MdiParent = this.MdiParent;
                frmBusqCli.StartPosition = FormStartPosition.Manual;
                frmBusqCli.Left = 588;
                frmBusqCli.Top = 112;
                frmBusqCli.ShowDialog();
                //frmCli.Visible = true;
            }
            if (frmBusqCli.DialogResult == DialogResult.OK)
            {
                cliseleccionado = frmBusqCli.ClienteSelecc;
                txtRUCCliente.Text = cliseleccionado.Ruc;
                txtRazSocCliente.Text = cliseleccionado.RazonSocial;
            }
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
            if (cliseleccionado == null)
            {
                MessageBox.Show("Falta ingresar datos de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                pedido.DatoCliente = cliseleccionado;
                if (prodSeleccionado == null || txtCantProd.Text=="")
                {
                    MessageBox.Show("Falta ingresar datos de producto", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    double subtotal = Int32.Parse(txtCantProd.Text) * (prodSeleccionado.Precio);
                    dgvPedido.Rows.Add(prodSeleccionado.Nombre, txtCantProd.Text, prodSeleccionado.Precio, subtotal.ToString("N2"));
                    pedido.Total += subtotal;
                }
            }
        }
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            string url = "server=200.16.7.96;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=ta1RQx6flDXdiTpr;";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            //MessageBox("Conexión exitosa","Conexiones");
            //MySqlCommand com = new MySqlCommand();
            MySqlCommand mysqlcom = new MySqlCommand();
            string sqlquery = "INSERT INTO Pedido " +
                              " (importeTotal,fechaPedido,idCliente,idEstadoPedido,estadoRegistro,idAdministradorSistema,idAlmacenero,idResponsableLogistica)" +
                              " values (" +
                              pedido.Total+",'"+pedido.DateReg+"',"+pedido.DatoCliente.Id+",1,1,3,12,4)";
            mysqlcom.Connection = conn;
            mysqlcom.CommandText = sqlquery;
            mysqlcom.ExecuteNonQuery();
            txtTotal.Text = pedido.Total.ToString("N2");

            txtCantProd.Text = "";
            txtCodigoProd.Text = "";
            txtNombProd.Text = "";
            txtRazSocCliente.Text = "";
            txtRUCCliente.Text = "";
        }
    }
}