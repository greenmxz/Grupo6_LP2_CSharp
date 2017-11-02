using System;
using System.Windows.Forms;

namespace Vista {
    //public enum estado { Nuevo, Cerrado }
    public partial class frmAdmProducto : Form {
        private estado _estado;
        private frmBusquedaProducto frmBPROD;
        public estado Estado { get => _estado; set => _estado = value; }
        public frmAdmProducto() {
            InitializeComponent();
            txtCodigo.Enabled = false;
            this.Estado = estado.Cerrado;
        }
        public frmAdmProducto(Form padre) {
            InitializeComponent();
            MdiParent = padre;
            Visible = true;
            txtCodigo.Enabled = false;
            this.Estado = estado.Cerrado;

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
            if (frmBPROD == null || frmBPROD.Estado == estado.Cerrado)
            {
                frmBPROD = new frmBusquedaProducto();
                frmBPROD.Estado = estado.Nuevo;
                frmBPROD.MdiParent = this.MdiParent;
                frmBPROD.StartPosition = FormStartPosition.Manual;
                frmBPROD.Left = 588;
                frmBPROD.Top = 112;
                frmBPROD.Visible = true;
            }
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descrip = txtDescripcion.Text;
            string marca = txtMarca.Text;
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
                        /* MySqlCommand cmdCli = new MySqlCommand();
                         * cmdCli.CommandText = "INSERT INTO CLIENTE(idCliente,ruc,razonSocial,telefono,correo,direccion,distrito) 
                         * values (i,RUC,razSoc,telef,correoElec,direc,dist)";
                         */
                        MessageBox.Show("Producto registrado exitosamente", "Registro exitoso");
                        //txtCodigoClientes.Text = obtenerCodTemporal(i);
                        txtNombre.Text = "";
                        txtDescripcion.Text = "";
                        txtMarca.Text = "";
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
                Verificador.imprimirMessageBoxProducto(nombre, descrip, marca, precUnit, stock);
            }
        }
        private void btnCerrarProducto_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
            if (frmBPROD != null) { frmBPROD.Dispose(); }
        }
        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtPU.Text = "";
            txtStockIni.Text = "";
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descrip = txtDescripcion.Text;
            string marca = txtMarca.Text;
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
                        /* MySqlCommand cmdCli = new MySqlCommand();
                         * cmdCli.CommandText = "UPDATE CLIENTE
                         * SET ruc = RUC, razonSocial = razSoc, telefono=telef, correo=correoElec, direccion=direc, distrito=dist 
                         * WHERE ID=i";
                         */
                        MessageBox.Show("Producto modificado exitosamente", "Modificación exitosa");
                        //txtCodigoClientes.Text = obtenerCodTemporal(i);
                        txtNombre.Text = "";
                        txtDescripcion.Text = "";
                        txtMarca.Text = "";
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
                Verificador.imprimirMessageBoxProducto(nombre, descrip, marca, precUnit, stock);
            }
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descrip = txtDescripcion.Text;
            string marca = txtMarca.Text;
            string precUnit = txtPU.Text;
            string stock = txtStockIni.Text;
            if (nombre != "" && descrip != "" && marca != "" && precUnit != "" && Double.Parse(precUnit) > 0 && stock != "" && Int32.Parse(stock) > 0)
            {
                string cadena = "¿Está seguro de que desea eliminar el siguiente producto:";
                cadena = cadena + Environment.NewLine + "Nombre: " + nombre;
                cadena = cadena + Environment.NewLine + "Descripción: " + descrip;
                cadena = cadena + Environment.NewLine + "Marca: " + marca;
                cadena = cadena + Environment.NewLine + "Precio unitario: " + precUnit;
                cadena = cadena + Environment.NewLine + "Stock: " + stock;
                // cadena = cadena + Environment.NewLine + Environment.NewLine + "Se almacenará con código : " + obtenerCodTemporal(i);
                //i++;
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de eliminación", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        /* MySqlCommand cmdCli = new MySqlCommand();
                         * cmdCli.CommandText = "DELETE FROM CLIENTE
                         * WHERE ID=i";
                         */
                        MessageBox.Show("Producto eliminado exitosamente", "Eliminación exitosa");
                        txtNombre.Text = "";
                        txtDescripcion.Text = "";
                        txtMarca.Text = "";
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
                Verificador.imprimirMessageBoxProducto(nombre, descrip, marca, precUnit, stock);
            }
        }
    }
}