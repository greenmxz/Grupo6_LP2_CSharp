using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Modelo;

namespace Vista {
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
            definirEstado(estado.Nuevo);
            int id = AdminDB.executeFunction("obtener_idProducto", null, null);
            txtCodigo.Text = Convert.ToString(id);
            tip1.SetToolTip(pBoxI1, "Coloque el peso en kilogramos");
            tip1.SetToolTip(pBoxI2, "El precio debe estar en PEN (denominación" + Environment.NewLine + "internacional del Sol peruano)");
            login = user;
        }
        public frmAdmProducto(Form padre) {
            InitializeComponent();
            prodSeleccionado = new Producto();
            MdiParent = padre;
            Visible = true;
            txtCodigo.Enabled = false;
            definirEstado(estado.Nuevo);
        }
        public void definirEstado(estado e)
        {
            Estado = e;
            switch (e)
            {
                case (estado.Nuevo):
                    btnAgregarProducto.Text = "Nuevo";
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPeso.Enabled = false;
                    txtPU.Enabled = false;
                    txtStockIni.Enabled = false;
                    gbxProd1.Enabled = true;
                    btnModificarProducto.Enabled = false;
                    btnEliminarProducto.Enabled = false;
                    btnLimpiarProducto.Enabled = false;
                    gbxProd3.Enabled = true;
                    break;
                case (estado.Registrar):
                    btnAgregarProducto.Text = "Registrar";
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPeso.Enabled = true;
                    txtPU.Enabled = true;
                    txtStockIni.Enabled = true;
                    gbxProd1.Enabled = true;
                    btnModificarProducto.Enabled = false;
                    btnEliminarProducto.Enabled = false;
                    btnLimpiarProducto.Enabled = true;
                    gbxProd3.Enabled = false;
                    break;
                case (estado.Buscado):
                    btnAgregarProducto.Text = "Nuevo";
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPeso.Enabled = true;
                    txtPU.Enabled = true;
                    txtStockIni.Enabled = true;
                    gbxProd1.Enabled = false;
                    btnModificarProducto.Enabled = true;
                    btnEliminarProducto.Enabled = true;
                    btnLimpiarProducto.Enabled = true;
                    gbxProd3.Enabled = false;
                    break;
                case (estado.Cerrado):
                    break;
            }
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
            if (Estado == estado.Nuevo)
            {
                definirEstado(estado.Registrar);
            }
            else
            {
                int id = AdminDB.executeFunction("obtener_idProducto", null, null);
                txtCodigo.Text = Convert.ToString(id);
                string nombre = txtNombre.Text;
                string descrip = txtDescripcion.Text;
                string peso = txtPeso.Text;
                string precUnit = txtPU.Text;
                string stock = txtStockIni.Text;
                if (nombre != "" && descrip != "" && Int32.Parse(peso) > 0 && precUnit != "" && Double.Parse(precUnit) > 0 && stock != "" && Int32.Parse(stock) > 0)
                {
                    string cadena = "¿Está seguro de que desea registrar el siguiente producto:";
                    cadena = cadena + Environment.NewLine + "Nombre: " + nombre;
                    cadena = cadena + Environment.NewLine + "Descripción: " + descrip;
                    cadena = cadena + Environment.NewLine + "Peso: " + peso + " kilogramos (Kg)";
                    cadena = cadena + Environment.NewLine + "Precio unitario: " + precUnit + " PEN";
                    cadena = cadena + Environment.NewLine + "Stock: " + stock + " unidades";
                    DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de registro", MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes:

                            try
                            {
                                string sqlquery = "INSERT INTO Producto " +
                                                  "VALUES (" + id + ",'" + nombre + "','" + descrip + "'," + Double.Parse(precUnit) +
                                                  "," + Int32.Parse(peso) + ",1," + login.IdUsuario + "," + Int32.Parse(stock) + ")";
                                ConexionVista.conectar();
                                MySqlCommand cmdProd = new MySqlCommand();
                                cmdProd.CommandText = sqlquery;
                                ConexionVista.cast(cmdProd);
                                cmdProd.ExecuteNonQuery();
                                MessageBox.Show("Producto registrado exitosamente", "Registro exitoso");
                                ConexionVista.cerrar();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error");
                            }
                            break;
                        case DialogResult.No:
                            MessageBox.Show("La operación ha sido cancelada", "Operación cancelada");
                            break;
                    }
                    btnLimpiarProducto_Click(sender, e);
                }
                else
                {
                    //Verificador.imprimirMessageBoxProducto(nombre, descrip, marca, precUnit);
                }
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
            int nuevoID = AdminDB.executeFunction("obtener_idCliente", null, null);
            txtCodigo.Text = Convert.ToString(nuevoID);
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPeso.Text = "";
            txtPU.Text = "";
            txtStockIni.Text = "";
            definirEstado(estado.Nuevo);
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string descrip = txtDescripcion.Text;
            string peso = txtPeso.Text;
            string precUnit = txtPU.Text;
            string stock = txtStockIni.Text;
            if (nombre != "" && descrip != "" && Int32.Parse(peso) > 0 && precUnit != "" && Double.Parse(precUnit) > 0 && stock != "" && Int32.Parse(stock) > 0)
            {
                string cadena = "¿Está seguro de que desea modificar la información del siguiente producto:";
                cadena = cadena + Environment.NewLine + "Nombre: " + nombre;
                cadena = cadena + Environment.NewLine + "Descripción: " + descrip;
                cadena = cadena + Environment.NewLine + "Peso: " + peso + " kilogramos (Kg)";
                cadena = cadena + Environment.NewLine + "Precio unitario: " + precUnit + " PEN";
                cadena = cadena + Environment.NewLine + "Stock: " + stock +" unidades";
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de modificación", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        try
                        {
                            string sql = "UPDATE Producto SET nombre='" + txtNombre.Text + "',descripcion='" + txtDescripcion.Text +
                                          "',precioUnitario=" + float.Parse(txtPU.Text) + ",peso=" + double.Parse(txtPeso.Text) +
                                          ",stock=" + Int32.Parse(txtStockIni.Text) +
                                         " WHERE idProducto=" + txtCodigo.Text;
                            ConexionVista.conectar();
                            MySqlCommand cmdProd = new MySqlCommand();
                            cmdProd.CommandText = sql;
                            ConexionVista.cast(cmdProd);
                            cmdProd.ExecuteNonQuery();
                            MessageBox.Show("Producto modificado exitosamente", "Modificación exitosa");
                            ConexionVista.cerrar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                        break;
                    case DialogResult.No:
                        MessageBox.Show("La operación ha sido cancelada");
                        break;
                }
                btnLimpiarProducto_Click(sender, e);
            }
            else
            {
                //Verificador.imprimirMessageBoxProducto(nombre, descrip, marca, precUnit);
            }
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descrip = txtDescripcion.Text;
            string marca = txtPeso.Text;
            string precUnit = txtPU.Text;
            if (nombre != "" && descrip != "" && marca != "" && precUnit != "" && Double.Parse(precUnit) > 0)
            {
                string cadena = "¿Está seguro de que desea eliminar el siguiente producto:";
                cadena = cadena + Environment.NewLine + "Nombre: " + nombre;
                cadena = cadena + Environment.NewLine + "Descripción: " + descrip;
                cadena = cadena + Environment.NewLine + "Marca: " + marca;
                cadena = cadena + Environment.NewLine + "Precio unitario: " + precUnit;
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