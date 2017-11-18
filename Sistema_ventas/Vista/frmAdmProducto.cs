using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Modelo;

namespace Vista {
    //public enum estado { Nuevo, Cerrado }
    public partial class frmAdmProducto : Form {
        private estado _estado;
        private frmBusquedaProducto frmBPROD;
        private Producto prodSeleccionado;
        private Usuario login;
        public estado Estado { get => _estado; set => _estado = value; }
        public Producto ProdSeleccionado { get => prodSeleccionado; set => prodSeleccionado = value; }

        public frmAdmProducto(Usuario user) {
            prodSeleccionado = new Producto();
            InitializeComponent();
            txtCodigo.Enabled = false;
            Estado = estado.Cerrado;
            tip1.SetToolTip(pBoxI1, "Coloque el peso en kilogramos");
        }
        public frmAdmProducto(Form padre) {
            InitializeComponent();
            prodSeleccionado = new Producto();
            MdiParent = padre;
            Visible = true;
            txtCodigo.Enabled = false;
            Estado = estado.Cerrado;

        }
        private void txtStockIni_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void txtPU_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar.Equals('.'))) {
                e.Handled = true;
            }
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //if (frmBPROD == null || frmBPROD.Estado == estado.Cerrado)
            //{             
                frmBPROD = new frmBusquedaProducto();
                if (frmBPROD.ShowDialog() == DialogResult.OK)
                {

                    prodSeleccionado = frmBPROD.Producto;                    
                    txtCodigo.Text = prodSeleccionado.Id.ToString();
                    txtNombre.Text = prodSeleccionado.Nombre;
                    txtDescripcion.Text = prodSeleccionado.Descripcion;
                    txtPU.Text = prodSeleccionado.Precio.ToString("N2");
                    txtPeso.Text = prodSeleccionado.Peso.ToString("N2");
                }
                frmBPROD.Estado = estado.Nuevo;
                frmBPROD.MdiParent = this.MdiParent;
                frmBPROD.StartPosition = FormStartPosition.Manual;
                frmBPROD.Left = 588;
                frmBPROD.Top = 112;
                //frmBPROD.Visible = true;
            //}
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descrip = txtDescripcion.Text;
            string marca = txtPeso.Text;
            string precUnit = txtPU.Text;
            string stock = txtStockIni.Text;
            if (nombre != "" && descrip != "" && marca != "" && precUnit != "" && Double.Parse(precUnit)>0 && stock != "" && Int32.Parse(stock)>0)
            {
                string cadena = "¿Está seguro de que desea registrar el siguiente producto:";
                cadena = cadena + Environment.NewLine + "Nombre: " + nombre;
                cadena = cadena + Environment.NewLine + "Descripción: " + descrip;
                cadena = cadena + Environment.NewLine + "Marca: " + marca;
                cadena = cadena + Environment.NewLine + "Precio unitario: " + precUnit;
                cadena = cadena + Environment.NewLine + "Stock: " + stock;
                // cadena = cadena + Environment.NewLine + Environment.NewLine + "Se almacenará con código : " + obtenerCodTemporal(i);
                //i++;
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de registro", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        
                        
                            string url = "server=200.16.7.96;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=ta1RQx6flDXdiTpr;";
                            MySqlConnection conn = new MySqlConnection(url);
                            conn.Open();
                            //MessageBox("Conexión exitosa","Conexiones");
                            //MySqlCommand com = new MySqlCommand();
                            MySqlCommand mysqlcom = new MySqlCommand();
                            Producto p = new Producto(txtNombre.Text, txtDescripcion.Text, float.Parse(txtPU.Text), double.Parse(txtPeso.Text));
                            int stockingreso = Int32.Parse(txtStockIni.Text);
                            string sqlquery = "INSERT INTO Producto " + 
                                              "(nombre,descripcion,precioUnitario,peso,estadoRegistro,idAdministradorSistema,stock)" + 
                                              "values('" + p.Nombre + "','" + p.Descripcion + "'," + p.Precio+
                                              "," + p.Peso+ ",1" + ",1,"+ stockingreso +")";
                            mysqlcom.Connection = conn;
                            mysqlcom.CommandText = sqlquery;
                            mysqlcom.ExecuteNonQuery();

                            /*MySqlCommand cmdCli = new MySqlCommand();
                            * cmdCli.CommandText = "INSERT INTO CLIENTE(idCliente,ruc,razonSocial,telefono,correo,direccion,distrito) 
                            * values (i,RUC,razSoc,telef,correoElec,direc,dist)";
                            */
                            MessageBox.Show("Producto registrado exitosamente", "Registro exitoso");
                            txtNombre.Text = "";
                            txtDescripcion.Text = "";
                            txtPeso.Text = "";
                            txtPU.Text = "";
                            txtStockIni.Text = "";
                            conn.Close();
                            
                        
                        //txtCodigoClientes.Text = obtenerCodTemporal(i);
                        break;
                    case DialogResult.No:
                        MessageBox.Show("La operación ha sido cancelada");
                        break;
                }
            }
            else
            {
                Verificador.imprimirMessageBoxProducto(nombre, descrip, marca, precUnit);
            }
        }
        private void btnCerrarProducto_Click(object sender, EventArgs e)
        {
            Dispose();
            Estado = estado.Cerrado;
            if (frmBPROD != null) { frmBPROD.Dispose(); }
        }
        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPeso.Text = "";
            txtPU.Text = "";
            txtStockIni.Text = "";
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descrip = txtDescripcion.Text;
            string marca = txtPeso.Text;
            string precUnit = txtPU.Text;
            string stock = txtStockIni.Text;
            if (nombre != "" && descrip != "" && marca != "" && precUnit != "" && Double.Parse(precUnit) > 0 && stock != "" && Int32.Parse(stock) > 0)
            {
                string cadena = "¿Está seguro de que desea modificar la información del siguiente producto:";
                cadena = cadena + Environment.NewLine + "Nombre: " + nombre;
                cadena = cadena + Environment.NewLine + "Descripción: " + descrip;
                cadena = cadena + Environment.NewLine + "Marca: " + marca;
                cadena = cadena + Environment.NewLine + "Precio unitario: " + precUnit;
                cadena = cadena + Environment.NewLine + "Stock: " + stock;
                // cadena = cadena + Environment.NewLine + Environment.NewLine + "Se almacenará con código : " + obtenerCodTemporal(i);
                //i++;
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de modificación", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        string url = "server=200.16.7.96;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=ta1RQx6flDXdiTpr;";
                        MySqlConnection conn = new MySqlConnection(url);
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        string sql = "UPDATE Producto SET nombre='"+txtNombre.Text+"',descripcion='"+txtDescripcion.Text +
                                      "',precioUnitario="+float.Parse(txtPU.Text)+",peso="+double.Parse(txtPeso.Text)+
                                      ",stock="+Int32.Parse(txtStockIni.Text)+
                                     " WHERE idProducto=" +txtCodigo.Text;
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        
                         
                        MessageBox.Show("Producto modificado exitosamente", "Modificación exitosa");
                        //txtCodigoClientes.Text = obtenerCodTemporal(i);
                        txtNombre.Text = "";
                        txtDescripcion.Text = "";
                        txtPeso.Text = "";
                        txtPU.Text = "";
                        txtStockIni.Text = "";
                        break;
                    case DialogResult.No:
                        MessageBox.Show("La operación ha sido cancelada");
                        break;
                }
            }
            else
            {
                Verificador.imprimirMessageBoxProducto(nombre, descrip, marca, precUnit);
            }
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descrip = txtDescripcion.Text;
            string marca = txtPeso.Text;
            string precUnit = txtPU.Text;
            //string stock = txtStockIni.Text;
            if (nombre != "" && descrip != "" && marca != "" && precUnit != "" && Double.Parse(precUnit) > 0)
            {
                string cadena = "¿Está seguro de que desea eliminar el siguiente producto:";
                cadena = cadena + Environment.NewLine + "Nombre: " + nombre;
                cadena = cadena + Environment.NewLine + "Descripción: " + descrip;
                cadena = cadena + Environment.NewLine + "Marca: " + marca;
                cadena = cadena + Environment.NewLine + "Precio unitario: " + precUnit;
                //cadena = cadena + Environment.NewLine + "Stock: " + stock;
                // cadena = cadena + Environment.NewLine + Environment.NewLine + "Se almacenará con código : " + obtenerCodTemporal(i);
                //i++;
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de eliminación", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        string url = "server=200.16.7.96;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=ta1RQx6flDXdiTpr;";
                        MySqlConnection conn = new MySqlConnection(url);
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand();                   
                        string sql = "DELETE FROM Producto WHERE idProducto=" + Int32.Parse(txtCodigo.Text);
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        

                        MessageBox.Show("Producto eliminado exitosamente", "Eliminación exitosa");
                        txtNombre.Text = "";
                        txtDescripcion.Text = "";
                        txtPeso.Text = "";
                        txtPU.Text = "";
                        txtStockIni.Text = "";
                        break;
                    case DialogResult.No:
                        MessageBox.Show("La operación ha sido cancelada");
                        break;
                }
            }
            else
            {
                Verificador.imprimirMessageBoxProducto(nombre, descrip, marca, precUnit);
            }
        }
    }
}