using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Modelo;

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
        private Usuario login;
        private double total = 0;
        public frmAdmPedido(Usuario user)
        {
            InitializeComponent();
            cliseleccionado = new Cliente();
            prodSeleccionado = new Producto();
            pedido = new Pedido();
            txtTotal.Text = string.Format("{0:0.00}", total);
            definirEstado(estado.Nuevo);
            login = user;
        }
        public estado Estado { get => frmState; set => frmState = value; }
        public Cliente Cliseleccionado { get => cliseleccionado; set => cliseleccionado = value; }
        public Producto ProdSeleccionado { get => prodSeleccionado; set => prodSeleccionado = value; }
        public Pedido Pedido { get => pedido; set => pedido = value; }
        public void definirEstado(estado e)
        {
            frmState = e;
            switch (e)
            {
                case (estado.Nuevo):
                    btnAgregarPedido.Text = "Nuevo";
                    dateTimePedido.Enabled = false;
                    btnBuscarClienteXPedido.Enabled = false;
                    gBoxProd.Enabled = false;
                    dgvPedido.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscarPedido.Enabled = true;
                    break;
                case (estado.Registrar):
                    btnAgregarPedido.Text = "Registrar";
                    dateTimePedido.Enabled = true;
                    btnBuscarClienteXPedido.Enabled = true;
                    gBoxProd.Enabled = true;
                    dgvPedido.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscarPedido.Enabled = false;
                    break;
                case (estado.Buscar):
                    btnAgregarPedido.Text = "Modificar";
                    dateTimePedido.Enabled = false;
                    btnBuscarClienteXPedido.Enabled = false;
                    gBoxProd.Enabled = false;
                    dgvPedido.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscarPedido.Enabled = true;
                    break;
                case (estado.Modificar):
                    btnAgregarPedido.Text = "Confirmar";
                    dateTimePedido.Enabled = true;
                    btnBuscarClienteXPedido.Enabled = true;
                    gBoxProd.Enabled = true;
                    dgvPedido.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscarPedido.Enabled = true;
                    break;
                case (estado.Cerrado):
                    break;
            }
        }
        private void btnBuscarPedido_Click(object sender, EventArgs e) {
            if (frmBusquedaPedido == null || frmBusquedaPedido.Estado == estado.Cerrado) {
                frmBusquedaPedido = new frmBusquedaPedido();
                frmBusquedaPedido.Estado = estado.Nuevo;
                //frmBusquedaPedido.MdiParent = this.MdiParent;
                frmBusquedaPedido.StartPosition = FormStartPosition.Manual;
                frmBusquedaPedido.Left = 588;
                frmBusquedaPedido.Top = 112;
                frmBusquedaPedido.ShowDialog();
                //frmBusquedaPedido.Visible = true;
            }
            if (frmBusquedaPedido.DialogResult == DialogResult.OK)
            {
                Pedido p = frmBusquedaPedido.PedidoSelecc;
                dateTimePedido.Text = Convert.ToString(p.DateReg);
                txtTotal.Text = Convert.ToString(p.Total);
                txtRUCCliente.Text = p.DatoCliente.Ruc;
                txtRazSocCliente.Text = p.DatoCliente.RazonSocial;
                //foreach(Producto pr in )
                definirEstado(estado.Buscar);
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
                prodSeleccionado = frmBusqProd.ProductoSelecc;
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
            if (frmState == estado.Nuevo)
            {
                definirEstado(estado.Registrar);
            }
            else
            {
                //string url = "server=200.16.7.96;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=ta1RQx6flDXdiTpr;";
                //MySqlConnection conn = new MySqlConnection(url);
                //conn.Open();
                ////MessageBox("Conexión exitosa","Conexiones");
                ////MySqlCommand com = new MySqlCommand();
                //MySqlCommand mysqlcom = new MySqlCommand();
                //string sqlquery = "INSERT INTO Pedido " +
                //                  " (importeTotal,fechaPedido,idCliente,idEstadoPedido,estadoRegistro,idAdministradorSistema,idAlmacenero,idResponsableLogistica)" +
                //                  " values (" +
                //                  pedido.Total + ",'" + pedido.DateReg + "'," + pedido.DatoCliente.Id + ",1,1,3,12,4)";
                //mysqlcom.Connection = conn;
                //mysqlcom.CommandText = sqlquery;
                //mysqlcom.ExecuteNonQuery();
                //txtTotal.Text = pedido.Total.ToString("N2");
                btnCancelar_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            definirEstado(estado.Nuevo);
            txtRUCCliente.Text = "";
            txtRazSocCliente.Text = "";
            total = 0;
            txtTotal.Text = string.Format("{0:0.00}", total);
            txtCodigoProd.Text = "";
            txtNombProd.Text = "";
            txtCantProd.Text = "";
            dgvPedido.Rows.Clear();
        }
    }
}