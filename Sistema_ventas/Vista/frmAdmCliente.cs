using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vista {
    public enum estado { Nuevo, Cerrado }
    public partial class frmAdmCliente : Form {
        private estado frmState;
        private frmBusquedaCliente frmBusquedaCliente;
        //int obtenerLastCodigo()
        //{
        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand();
        //        cmd.CommandText = "SELECT MAX(idCliente) AS MaxDist FROM Cliente";
        //        Conexion.cast(cmd);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        reader.Read();
        //        int mayor = reader.GetInt32("MaxDist");
        //        reader.Close();
        //        return mayor;
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}
        public frmAdmCliente() {
            InitializeComponent();
            this.frmState = estado.Nuevo;
            AdmComboBox.manipCombo("Distrito", "nombreDistrito", cboDistritoClientes);
            //txtCodigoClientes.Text = Convert.ToString(obtenerLastCodigo()+1);
            txtCodigoClientes.Text = Convert.ToString(1);
        }
        public estado Estado { get => frmState; set => frmState = value; }
        private void btnBuscarCliente_Click(object sender, EventArgs e) {
            if (frmBusquedaCliente == null || frmBusquedaCliente.Estado == estado.Cerrado) {
                frmBusquedaCliente = new frmBusquedaCliente();
                frmBusquedaCliente.Estado = estado.Nuevo;
                frmBusquedaCliente.MdiParent = this.MdiParent;

                frmBusquedaCliente.StartPosition = FormStartPosition.Manual;
                frmBusquedaCliente.Left = 588;
                frmBusquedaCliente.Top = 112;
                frmBusquedaCliente.Visible = true;
            }
            //txtCodigoClientes.Text = obtenerLastCodigo();
        }
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            //int id = obtenerLastCodigo()+1;
            int id = 1;
            txtCodigoClientes.Text = Convert.ToString(id);
            string RUC = txtRUCClientes.Text;
            string razSoc = txtRazSocClientes.Text;
            string telef = txtTlfClientes.Text;
            string correoElec = txtDirElecClientes.Text;
            string direc = txtDirClientes.Text;
            string dist = cboDistritoClientes.Text;
            if (Verificador.rucValido(RUC) && razSoc != "" && telef != "" && Verificador.correoValido(correoElec) && direc != "" && dist != "")
            {
                string cadena = "¿Está seguro de que desea registrar el siguiente cliente:";
                cadena = cadena + Environment.NewLine + "RUC : " + RUC;
                cadena = cadena + Environment.NewLine + "Razón social : " + razSoc;
                cadena = cadena + Environment.NewLine + "Teléfono : " + telef;
                cadena = cadena + Environment.NewLine + "Dirección electrónica : " + correoElec;
                cadena = cadena + Environment.NewLine + "Dirección física : " + direc;
                cadena = cadena + Environment.NewLine + "Distrito : " + dist;
                cadena = cadena + Environment.NewLine + Environment.NewLine + "Se almacenará con código : " + Convert.ToString(id);
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de registro", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        try
                        {
                            MySqlCommand cmdCli = new MySqlCommand();
                            cmdCli.CommandText = "INSERT INTO Cliente(idCliente,ruc,razonSocial,telefono,correo,direccion,distrito,estadoRegistro,idAdministradorSistema)" +
                                " VALUES (" + Convert.ToString(id) + ",'" + RUC + "','" + razSoc + "','" + telef +
                                "','" + correoElec + "','" + direc + "','" + dist + "',1,1)";
                            Conexion.cast(cmdCli);
                            cmdCli.ExecuteNonQuery();
                            MessageBox.Show("Cliente registrado exitosamente", "Registro exitoso");
                            //txtCodigoClientes.Text = Convert.ToString(obtenerLastCodigo());
                            txtRUCClientes.Text = "";
                            txtRazSocClientes.Text = "";
                            txtTlfClientes.Text = "";
                            txtDirElecClientes.Text = "";
                            txtDirClientes.Text = "";
                            cboDistritoClientes.Text = "";
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                            //MessageBox.Show("Ha ocurrido un error en el registro", "Error en el proceso");
                        }
                        break;
                    case DialogResult.No:
                        MessageBox.Show("La operación ha sido cancelada", "Operación cancelada");
                        break;
                }
            }
            else
            {
                Verificador.imprimirMessageBoxCliente(RUC, razSoc, telef, correoElec, direc, dist);
            }
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            //int id = obtenerLastCodigo();
            int id = 1;
            string RUC = txtRUCClientes.Text;
            string razSoc = txtRazSocClientes.Text;
            string telef = txtTlfClientes.Text;
            string correoElec = txtDirElecClientes.Text;
            string direc = txtDirClientes.Text;
            string dist = cboDistritoClientes.Text;
            if (Verificador.rucValido(RUC) && razSoc != "" && telef != "" && Verificador.correoValido(correoElec) && direc != "" && dist != "")
            {
                string cadena = "¿Está seguro de que desea modificar la información del siguiente cliente:";
                cadena = cadena + Environment.NewLine + "Código : " + id;
                cadena = cadena + Environment.NewLine + "RUC : " + RUC;
                cadena = cadena + Environment.NewLine + "Razón social : " + razSoc;
                cadena = cadena + Environment.NewLine + "Teléfono : " + telef;
                cadena = cadena + Environment.NewLine + "Dirección electrónica : " + correoElec;
                cadena = cadena + Environment.NewLine + "Dirección física : " + direc;
                cadena = cadena + Environment.NewLine + "Distrito : " + dist;
                cadena = cadena + Environment.NewLine + Environment.NewLine + "Los cambios en el cliente con código " + Convert.ToString(id) + " NO serán reversibles";
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de modificación", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        /* MySqlCommand cmdCli = new MySqlCommand();
                         * cmdCli.CommandText = "UPDATE CLIENTE
                         * SET ruc = RUC, razonSocial = razSoc, telefono=telef, correo=correoElec, direccion=direc, distrito=dist 
                         * WHERE ID=i";
                         */
                        MessageBox.Show("Cliente modificado exitosamente", "Modificación exitosa");
                        txtCodigoClientes.Text = "";
                        txtRUCClientes.Text = "";
                        txtRazSocClientes.Text = "";
                        txtTlfClientes.Text = "";
                        txtDirElecClientes.Text = "";
                        txtDirClientes.Text = "";
                        cboDistritoClientes.Text = "";
                        break;
                    case DialogResult.No:
                        MessageBox.Show("La operación ha sido cancelada");
                        break;
                }
            }
            else
            {
                Verificador.imprimirMessageBoxCliente(RUC, razSoc, telef, correoElec, direc, dist);
            }
        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaCliente != null) { frmBusquedaCliente.Dispose(); }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            //int id = obtenerLastCodigo();
            int id = 1;
            string RUC = txtRUCClientes.Text;
            string razSoc = txtRazSocClientes.Text;
            string telef = txtTlfClientes.Text;
            string correoElec = txtDirElecClientes.Text;
            string direc = txtDirClientes.Text;
            string dist = cboDistritoClientes.Text;
            if (Verificador.rucValido(RUC) && razSoc != "" && telef != "" && Verificador.correoValido(correoElec) && direc != "" && dist != "")
            {
                string cadena = "¿Está seguro de que desea eliminar el siguiente cliente:";
                cadena = cadena + Environment.NewLine + "Código : " + id;
                cadena = cadena + Environment.NewLine + "RUC : " + RUC;
                cadena = cadena + Environment.NewLine + "Razón social : " + razSoc;
                cadena = cadena + Environment.NewLine + "Teléfono : " + telef;
                cadena = cadena + Environment.NewLine + "Dirección electrónica : " + correoElec;
                cadena = cadena + Environment.NewLine + "Dirección física : " + direc;
                cadena = cadena + Environment.NewLine + "Distrito : " + dist;
                cadena = cadena + Environment.NewLine + Environment.NewLine + "La eliminación del proveedor con código " + Convert.ToString(id) + " NO serán reversibles";
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de eliminación", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        /* MySqlCommand cmdCli = new MySqlCommand();
                         * cmdCli.CommandText = "DELETE FROM CLIENTE
                         * WHERE ID=i";
                         */
                        MessageBox.Show("Cliente eliminado exitosamente", "Eliminación exitosa");
                        txtCodigoClientes.Text = "";
                        txtRUCClientes.Text = "";
                        txtRazSocClientes.Text = "";
                        txtTlfClientes.Text = "";
                        txtDirElecClientes.Text = "";
                        txtDirClientes.Text = "";
                        cboDistritoClientes.Text = "";
                        break;
                    case DialogResult.No:
                        MessageBox.Show("La operación ha sido cancelada");
                        break;
                }
            }
            else
            {
                Verificador.imprimirMessageBoxCliente(RUC, razSoc, telef, correoElec, direc, dist);
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtRUCClientes.Text = "";
            txtRazSocClientes.Text = "";
            txtTlfClientes.Text = "";
            txtDirElecClientes.Text = "";
            txtDirClientes.Text = "";
            cboDistritoClientes.Text = "";
        }
    }
}