using System;
using System.Windows.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using Modelo;

namespace Vista {
    public partial class frmAdmProducto : Form {
        private estado _estado;
        private bool busqprod=false;
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
            BindingList<string> aux = new BindingList<string>();
            int id = AdminDB.executeFunction("obtener_idProducto", null, aux);
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

        public void instanciabusqueda()
        {
            
            //btnAgregarProducto.Text = "Registrar";
            //btnModificarProducto.Text = "Modificar";
            
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPeso.Enabled = true;
            txtPU.Enabled = true;
            txtStockIni.Enabled = true;
            //gbxProd1.Enabled = true;
            btnModificarProducto.Enabled = false;
            btnEliminarProducto.Enabled = false;
            btnLimpiarProducto.Enabled = true;
            //gbxProd3.Enabled = false;
            //btnBuscarProducto.Enabled = true;

        }
        public void definirEstado(estado e)
        {
            Estado = e;
            switch (e)
            {
                case (estado.Nuevo):
                    btnAgregarProducto.Text = "Nuevo";
                    btnModificarProducto.Text = "Modificar";
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
                    btnModificarProducto.Text = "Modificar";
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
                case (estado.Buscar):
                    btnAgregarProducto.Text = "Nuevo";
                    btnModificarProducto.Text = "Modificar";
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPeso.Enabled = false;
                    txtPU.Enabled = false;
                    txtStockIni.Enabled = false;
                    gbxProd1.Enabled = false;
                    btnModificarProducto.Enabled = true;
                    btnEliminarProducto.Enabled = true;
                    btnLimpiarProducto.Enabled = true;
                    gbxProd3.Enabled = false;
                    break;
                case (estado.Modificar):
                    btnAgregarProducto.Text = "Nuevo";
                    btnModificarProducto.Text = "Confirmar";
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPeso.Enabled = true;
                    txtPU.Enabled = true;
                    txtStockIni.Enabled = true;
                    gbxProd1.Enabled = false;
                    btnModificarProducto.Enabled = true;
                    btnEliminarProducto.Enabled = false;
                    btnLimpiarProducto.Enabled = true;
                    gbxProd3.Enabled = false;
                    break;
                //case (estado.busqProducto):

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
            if (busqprod == false)
            {
                btnBuscarProducto.Text = "Buscar";
                btnBuscarProducto.Enabled = true;
                instanciabusqueda();
                busqprod = true;

            }
            //definirEstado(estado.Buscar);
            else if (busqprod == true)
            {
                if (txtNombre.Text == "")
                {
                    frmBPROD = new frmBusquedaProducto();
                    if (frmBPROD.ShowDialog() == DialogResult.OK)
                    {

                        prodSeleccionado = frmBPROD.ProductoSelecc;
                        txtCodigo.Text = prodSeleccionado.Id.ToString();
                        txtNombre.Text = prodSeleccionado.Nombre;
                        txtDescripcion.Text = prodSeleccionado.Descripcion;
                        txtPU.Text = prodSeleccionado.Precio.ToString("N2");
                        txtPeso.Text = prodSeleccionado.Peso.ToString("N2");
                        txtStockIni.Text = Convert.ToString(prodSeleccionado.Stock);
                        definirEstado(estado.Buscar);
                    }

                    frmBPROD.Estado = estado.Nuevo;
                    frmBPROD.MdiParent = this.MdiParent;
                    frmBPROD.StartPosition = FormStartPosition.Manual;
                    frmBPROD.Left = 588;
                    frmBPROD.Top = 112;
                }
                else {
                    string nombreaux = txtNombre.Text;
                    frmBPROD = new frmBusquedaProducto(nombreaux);
                    if (frmBPROD.ShowDialog() == DialogResult.OK)
                    {

                        prodSeleccionado = frmBPROD.ProductoSelecc;
                        txtCodigo.Text = prodSeleccionado.Id.ToString();
                        txtNombre.Text = prodSeleccionado.Nombre;
                        txtDescripcion.Text = prodSeleccionado.Descripcion;
                        txtPU.Text = prodSeleccionado.Precio.ToString("N2");
                        txtPeso.Text = prodSeleccionado.Peso.ToString("N2");
                        txtStockIni.Text = Convert.ToString(prodSeleccionado.Stock);
                        definirEstado(estado.Buscar);
                    }

                    frmBPROD.Estado = estado.Nuevo;
                    frmBPROD.MdiParent = this.MdiParent;
                    frmBPROD.StartPosition = FormStartPosition.Manual;
                    frmBPROD.Left = 588;
                    frmBPROD.Top = 112;

                }                    
            }
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (Estado == estado.Nuevo)
            {
                definirEstado(estado.Registrar);
            }
            else
            {
                BindingList<string> aux = new BindingList<string>();
                int id = AdminDB.executeFunction("obtener_idProducto", null, aux);
                txtCodigo.Text = Convert.ToString(id);
                string nombre = txtNombre.Text;
                string descrip = txtDescripcion.Text;
                string peso = txtPeso.Text;
                string precUnit = txtPU.Text;
                string stock = txtStockIni.Text;
                if (nombre != "" && descrip != "" && peso != "" && Double.Parse(peso) > 0 && precUnit != "" && Double.Parse(precUnit) > 0 && stock != "" && Int32.Parse(stock) > 0)
                {
                    string cadena = "¿Está seguro de que desea registrar el siguiente producto?:";
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
                                                  "," + Double.Parse(peso) + ",1," + login.IdUsuario + "," + Int32.Parse(stock) + ")";
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
            BindingList<string> aux = new BindingList<string>();
            int nuevoID = AdminDB.executeFunction("obtener_idCliente", null, aux);
            txtCodigo.Text = Convert.ToString(nuevoID);
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPeso.Text = "";
            txtPU.Text = "";
            txtStockIni.Text = "";
            busqprod = false;
            btnBuscarProducto.Text = "Busca tu producto aqui!";
            definirEstado(estado.Nuevo);
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (Estado == estado.Buscar)
            {
                definirEstado(estado.Modificar);
            }
            else
            {
                int id = Int32.Parse(txtCodigo.Text);
                string nombre = txtNombre.Text;
                string descrip = txtDescripcion.Text;
                string peso = txtPeso.Text;
                string precUnit = txtPU.Text;
                string stock = txtStockIni.Text;
                if (nombre != "" && descrip != "" && peso != "" && Double.Parse(peso) > 0 && precUnit != "" && Double.Parse(precUnit) > 0 && stock != "" && Int32.Parse(stock) > 0)
                {
                    string cadena = "¿Está seguro de que desea modificar la información del siguiente producto?:";
                    cadena = cadena + Environment.NewLine + "Nombre: " + nombre;
                    cadena = cadena + Environment.NewLine + "Descripción: " + descrip;
                    cadena = cadena + Environment.NewLine + "Peso: " + peso + " kilogramos (Kg)";
                    cadena = cadena + Environment.NewLine + "Precio unitario: " + precUnit + " PEN";
                    cadena = cadena + Environment.NewLine + "Stock: " + stock + " unidades";
                    DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de modificación", MessageBoxButtons.YesNo);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            try
                            {
                                string sql = "UPDATE Producto SET nombre='" + txtNombre.Text + "',descripcion='" + txtDescripcion.Text +
                                              "',precioUnitario=" + Double.Parse(txtPU.Text) + ",peso=" + Double.Parse(txtPeso.Text) +
                                              ",stock=" + Int32.Parse(txtStockIni.Text) +
                                             " WHERE idProducto=" + Int32.Parse(txtCodigo.Text) + ";";
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
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtCodigo.Text);
            BindingList<string> param = new BindingList<string>();
            BindingList<int> values = new BindingList<int>();
            param.Add("busqID");
            values.Add(id);
            int countDepend = AdminDB.executeFunction("contarPedidosXProducto", param, values);
            if (countDepend == 0)
            {
                string cadena = "¿Está seguro de que desea eliminar el siguiente producto?:";
                cadena = cadena + Environment.NewLine + "Nombre: " + txtNombre.Text;
                cadena = cadena + Environment.NewLine + "Descripción: " + txtDescripcion.Text;
                cadena = cadena + Environment.NewLine + "Peso: " + txtPeso + " kilogramos (Kg)";
                cadena = cadena + Environment.NewLine + "Precio unitario: " + txtPU.Text + " PEN";
                cadena = cadena + Environment.NewLine + "Stock: " + txtStockIni.Text + " unidades";
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de eliminación", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        try
                        {
                            ConexionVista.conectar();
                            MySqlCommand cmdProd = new MySqlCommand();
                            string sql = "UPDATE Producto SET estadoRegistro=2 WHERE idProducto=" + id;
                            cmdProd.CommandText = sql;
                            ConexionVista.cast(cmdProd);
                            cmdProd.ExecuteNonQuery();
                            MessageBox.Show("Producto eliminado exitosamente", "Eliminación exitosa");
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
                string diferencial;
                if(countDepend == 1)
                {
                    diferencial = " pedido";
                }
                else
                {
                    diferencial = " pedidos";
                }
                MessageBox.Show("No puede eliminarse este producto, puesto que se ha detectado " + countDepend + diferencial + " que lo involucran", "Dependencia pedido-producto detectada");
            }
        }
    }
}