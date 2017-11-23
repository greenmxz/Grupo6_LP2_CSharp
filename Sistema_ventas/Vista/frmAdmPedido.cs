using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.ComponentModel;
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
        private BindingList<Producto> listaProd;
        private BindingList<int> listaCantidad;
        public frmAdmPedido(Usuario user)
        {
            InitializeComponent();
            cliseleccionado = new Cliente();
            prodSeleccionado = new Producto();
            pedido = new Pedido();
            listaProd = new BindingList<Producto>();
            listaCantidad = new BindingList<int>();
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
                    btnBuscarClienteXPedido.Enabled = false;
                    gBoxProd.Enabled = true;
                    dgvPedido.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscarPedido.Enabled = false;
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
                dgvPedido.Rows.Clear();
                Pedido p = frmBusquedaPedido.PedidoSelecc;
                dateTimePedido.Text = Convert.ToString(p.DateReg);
                total = p.Total;
                txtTotal.Text = string.Format("{0:0.00}", p.Total);
                txtRUCCliente.Text = p.DatoCliente.Ruc;
                txtRazSocCliente.Text = p.DatoCliente.RazonSocial;
                /* EXTRACCIÓN DE PRODUCTOS */
                MySqlConnection conProd1 = new MySqlConnection();
                listaProd = new BindingList<Producto>();
                listaCantidad = new BindingList<int>();
                try
                {
                    string cadena = "server=200.16.7.96;user=inf282g6;database=inf282g6;" +
                         "port=3306;password=ta1RQx6flDXdiTpr;";
                    conProd1 = new MySqlConnection(cadena);
                    conProd1.Open();
                    MySqlCommand cmdProd1 = new MySqlCommand();
                    cmdProd1.CommandText = "SELECT * FROM DetallePedido WHERE idPedido=" + p.IdPedido;
                    cmdProd1.Connection = conProd1;
                    MySqlDataReader readerProd1 = cmdProd1.ExecuteReader();
                    while (readerProd1.Read())
                    {
                        int idProd = readerProd1.GetInt32("idProducto");
                        int valid = 0;
                        foreach (Producto pr in listaProd)
                        {
                            if (pr.Id == idProd)
                            {
                                valid = 1;
                                break;
                            }
                        }
                        if (valid == 0)
                        {
                            int cantidad = readerProd1.GetInt32("cantidad");
                            listaCantidad.Add(cantidad);
                            MySqlConnection conProd2 = new MySqlConnection();
                            try
                            {
                                string cadenaA = "server=200.16.7.96;user=inf282g6;database=inf282g6;" +
                                     "port=3306;password=ta1RQx6flDXdiTpr;";
                                conProd2 = new MySqlConnection(cadenaA);
                                conProd2.Open();
                                MySqlCommand cmdProd2 = new MySqlCommand();
                                cmdProd2.CommandText = "SELECT * FROM Producto WHERE idProducto=" + idProd;
                                cmdProd2.Connection = conProd2;
                                MySqlDataReader readerProd2 = cmdProd2.ExecuteReader();
                                readerProd2.Read();
                                Producto prodPed = new Producto();
                                prodPed.Id = idProd;
                                prodPed.Nombre = readerProd2.GetString("nombre");
                                prodPed.Precio = readerProd2.GetDouble("precioUnitario");
                                listaProd.Add(prodPed);
                            }
                            catch (Exception gg3)
                            {

                            }
                        }
                    }
                }
                catch (Exception gg2)
                {

                }
                int i = 0;
                foreach(Producto pr in listaProd)
                {
                    double subtotal = listaCantidad[i] * pr.Precio;
                    dgvPedido.Rows.Add(pr.Nombre, listaCantidad[i], string.Format("{0:0.00}", pr.Precio), string.Format("{0:0.00}", subtotal));
                    i++;
                }
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
                if (txtCodigoProd.Text != "" && txtNombProd.Text != "" && txtCantProd.Text != "")
                {
                    pedido.DatoCliente = cliseleccionado;
                    if (prodSeleccionado == null || txtCantProd.Text == "")
                    {
                        MessageBox.Show("Falta ingresar datos de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int valid = 1, ii = 0;
                        foreach (Producto pr in listaProd)
                        {
                            if (pr.Id == Int32.Parse(txtCodigoProd.Text))
                            {
                                valid = 0;
                                break;
                            }
                            ii++;
                        }
                        if (valid == 1)
                        {
                            double subtotal = Int32.Parse(txtCantProd.Text) * (prodSeleccionado.Precio);
                            dgvPedido.Rows.Add(prodSeleccionado.Nombre, txtCantProd.Text, string.Format("{0:0.00}", prodSeleccionado.Precio), subtotal.ToString("N2"));
                            listaProd.Add(prodSeleccionado);
                            listaCantidad.Add(Int32.Parse(txtCantProd.Text));
                            total += subtotal;
                        }
                        else
                        {
                            total -= listaCantidad[ii] * listaProd[ii].Precio;
                            listaCantidad[ii] += Int32.Parse(txtCantProd.Text);
                            total += listaCantidad[ii] * listaProd[ii].Precio;
                            dgvPedido.Rows.Clear();
                            int i = 0;
                            foreach (Producto pr in listaProd)
                            {
                                double subtotal = listaCantidad[i] * pr.Precio;
                                dgvPedido.Rows.Add(pr.Nombre, listaCantidad[i], string.Format("{0:0.00}", pr.Precio), string.Format("{0:0.00}", subtotal));
                                i++;
                            }
                        }
                        txtTotal.Text = string.Format("{0:0.00}", total);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un producto válido", "Producto inválido detectado");
                }
            }
        }
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            if (frmState == estado.Nuevo)
            {
                definirEstado(estado.Registrar);
            }
            else if (frmState == estado.Registrar)
            {
                // REGISTRO DE PEDIDO
                int id = 0;
                try
                {
                    BindingList<string> aux = new BindingList<string>();
                    id = AdminDB.executeFunction("obtener_idPedido", null, aux);
                    string formato = dateTimePedido.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string sentencia = "INSERT INTO Pedido" +
                        " VALUES (" + id + "," + total + ",'" + formato + "'," + cliseleccionado.Id + "," +
                        "1,1," + login.IdUsuario + ",3,12)";
                    ConexionVista.conectar();
                    MySqlCommand cmdCli = new MySqlCommand();
                    cmdCli.CommandText = sentencia;
                    ConexionVista.cast(cmdCli);
                    cmdCli.ExecuteNonQuery();
                    ConexionVista.cerrar();
                }
                catch (Exception ggg1)
                {
                }
                // REGISTRO DE DETALLES
                int count = 0;
                foreach (Producto p in listaProd)
                {
                    try
                    {
                        BindingList<string> aux = new BindingList<string>();
                        double subtotal = listaProd[count].Precio * listaCantidad[count];
                        ConexionVista.conectar();
                        MySqlCommand cmdCli = new MySqlCommand();
                        cmdCli.CommandText = "INSERT INTO DetallePedido" +
                            " VALUES (" + id + "," + listaCantidad[count] + "," + subtotal + "," + listaProd[count].Id + ")";
                        ConexionVista.cast(cmdCli);
                        cmdCli.ExecuteNonQuery();
                        ConexionVista.cerrar();
                    }
                    catch (Exception ggg2)
                    {
                    }
                    count++;
                }
                btnCancelar_Click(sender, e);
            }
            else if (frmState == estado.Buscar)
            {
                definirEstado(estado.Modificar);
            }
            else
            {
                // ACTUALIZACIÓN DE PEDIDO
                try
                {
                    string formato = dateTimePedido.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string sentencia = "UPDATE Pedido SET importeTotal=" + total + " WHERE idPedido=" + pedido.IdPedido;
                    ConexionVista.conectar();
                    MySqlCommand cmdCli = new MySqlCommand();
                    cmdCli.CommandText = sentencia;
                    ConexionVista.cast(cmdCli);
                    cmdCli.ExecuteNonQuery();
                    ConexionVista.cerrar();
                }
                catch (Exception ggg1)
                {
                }
                // ACTUALIZACIÓN DE DETALLES
                int count = 0;
                foreach (Producto p in listaProd)
                {
                    try
                    {
                        BindingList<string> aux = new BindingList<string>();
                        double subtotal = listaProd[count].Precio * listaCantidad[count];
                        ConexionVista.conectar();
                        MySqlCommand cmdCli = new MySqlCommand();
                        cmdCli.CommandText = "UPDATE DetallePedido SET cantidad=" + listaCantidad[count] + ",subtotal=" + subtotal +
                            " WHERE idPedido=" + pedido.IdPedido + " AND idProducto=" + listaProd[count].Id + ")";
                        ConexionVista.cast(cmdCli);
                        cmdCli.ExecuteNonQuery();
                        ConexionVista.cerrar();
                    }
                    catch (Exception ggg2)
                    {
                    }
                    count++;
                }
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

        private void dgvPedido_Click(object sender, EventArgs e)
        {
            int id = (int)dgvPedido.CurrentRow.Index;
            txtCodigoProd.Text = Convert.ToString(listaProd[id].Id);
            txtNombProd.Text = listaProd[id].Nombre;
            txtCantProd.Text = Convert.ToString(listaCantidad[id]);
        }

        private void btnQuitarClienteXPedido_Click(object sender, EventArgs e)
        {
            int id = (int)dgvPedido.CurrentRow.Index;
            total -= listaProd[id].Precio * listaCantidad[id];
            txtTotal.Text = string.Format("{0:0.00}", total);
            listaProd.RemoveAt(id);
            listaCantidad.RemoveAt(id);
            dgvPedido.Rows.RemoveAt(id);
            txtCodigoProd.Text = "";
            txtNombProd.Text = "";
            txtCantProd.Text = "";
        }

        private void btnModificarClienteXPedido_Click(object sender, EventArgs e)
        {
            if (txtCodigoProd.Text != "" && txtNombProd.Text != "" && txtCantProd.Text != "")
            {
                int id = (int)dgvPedido.CurrentRow.Index;
                total -= listaProd[id].Precio * listaCantidad[id];
                listaCantidad[id] = Int32.Parse(txtCantProd.Text);
                total += listaProd[id].Precio * listaCantidad[id];
                txtTotal.Text = string.Format("{0:0.00}", total);
                dgvPedido.Rows.Clear();
                int i = 0;
                foreach (Producto pr in listaProd)
                {
                    double subtotal = listaCantidad[i] * pr.Precio;
                    dgvPedido.Rows.Add(pr.Nombre, listaCantidad[i], string.Format("{0:0.00}", pr.Precio), string.Format("{0:0.00}", subtotal));
                    i++;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto de la tabla", "Anomalía en modificación detectada");
            }
        }

        private void txtCantProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}