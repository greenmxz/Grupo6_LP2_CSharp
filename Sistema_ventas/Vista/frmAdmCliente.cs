using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Modelo;

namespace Vista {
    public enum estado { Nuevo, Cerrado }
    public partial class frmAdmCliente : Form {
        private estado frmState;
        private frmBusquedaCliente frmCli;
        public frmAdmCliente() {
            InitializeComponent();
            this.frmState = estado.Nuevo;
            AdminDB.manipCombo("Distrito", "nombre", cboDistritoClientes);
            int id = AdminDB.executeFunction("obtener_idCliente", null, null);
            txtCodigoClientes.Text = Convert.ToString(id);
        }
        public estado Estado { get => frmState; set => frmState = value; }
        private void btnBuscarCliente_Click(object sender, EventArgs e) {
            if (frmCli == null || frmCli.Estado == estado.Cerrado) {
                frmCli = new frmBusquedaCliente();
                frmCli.Estado = estado.Nuevo;
                frmCli.MdiParent = this.MdiParent;

                frmCli.StartPosition = FormStartPosition.Manual;
                frmCli.Left = 588;
                frmCli.Top = 112;
                frmCli.Visible = true;
            }
            if (frmCli.ShowDialog() == DialogResult.OK)
            {
               // Cliente selec = frmCli.
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
                        try
                        {
                            ConexionVista.conectar();
                            MySqlCommand cmdCli = new MySqlCommand();
                            cmdCli.CommandText = "UPDATE Cliente SET ruc='" + RUC + "',razonSocial='" + razSoc +
                                "',telefono='" + telef + "',correo='" + correoElec + "',direccion='" + direc +
                                "',distrito='" + dist + "' WHERE idCliente=" + Convert.ToString(id) + ";";
                            ConexionVista.cast(cmdCli);
                            cmdCli.ExecuteNonQuery();
                            MessageBox.Show("Cliente modificado exitosamente", "Modificación exitosa");
                            txtCodigoClientes.Text = "";
                            txtRUCClientes.Text = "";
                            txtRazSocClientes.Text = "";
                            txtTlfClientes.Text = "";
                            txtDirElecClientes.Text = "";
                            txtDirClientes.Text = "";
                            cboDistritoClientes.Text = "";
                            ConexionVista.cerrar();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
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

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmCli != null) { frmCli.Dispose(); }
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
                        try
                        {
                            MySqlCommand cmdCli = new MySqlCommand();
                            cmdCli.CommandText = "DELETE FROM Cliente WHERE idCliente=" + Convert.ToString(id) + ";";
                            MessageBox.Show("Cliente eliminado exitosamente", "Eliminación exitosa");
                            txtCodigoClientes.Text = "";
                            txtRUCClientes.Text = "";
                            txtRazSocClientes.Text = "";
                            txtTlfClientes.Text = "";
                            txtDirElecClientes.Text = "";
                            txtDirClientes.Text = "";
                            cboDistritoClientes.Text = "";
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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            //ConexionVista.conectar();

            //MySqlCommand cmdCons = new MySqlCommand();
            //ConexionVista.cast(cmdCons);
            //cmdCons.CommandText = "obtener_idCliente";
            //cmdCons.CommandType = System.Data.CommandType.StoredProcedure;

            //MySqlParameter resp = new MySqlParameter();
            //resp.Direction = System.Data.ParameterDirection.ReturnValue;
            //cmdCons.Parameters.Add(resp);

            //cmdCons.ExecuteNonQuery();
            //int id = Convert.ToInt32(resp.Value.ToString());

            //ConexionVista.cerrar();
            int id = AdminDB.executeFunction("obtener_idCliente", null, null);
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
                            ConexionVista.conectar();
                            MySqlCommand cmdCli = new MySqlCommand();
                            //string distNomb = cboDistritoClientes.Items.;
                            cmdCli.CommandText = "INSERT INTO Cliente(idCliente,ruc,razonSocial,telefono,correo,direccion,distrito,estadoRegistro,idAdministradorSistema)" +
                                " VALUES (" + Convert.ToString(id) + ",'" + RUC + "','" + razSoc + "','" + telef +
                                "','" + correoElec + "','" + direc + "','" + dist + "',1,1)";
                            ConexionVista.cast(cmdCli);
                            cmdCli.ExecuteNonQuery();
                            MessageBox.Show("Cliente registrado exitosamente", "Registro exitoso");
                            //txtCodigoClientes.Text = Convert.ToString(obtenerLastCodigo());
                            txtRUCClientes.Text = "";
                            txtRazSocClientes.Text = "";
                            txtTlfClientes.Text = "";
                            txtDirElecClientes.Text = "";
                            txtDirClientes.Text = "";
                            cboDistritoClientes.Text = "";
                            ConexionVista.cerrar();
                        }
                        catch (Exception ex)
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
    }
}