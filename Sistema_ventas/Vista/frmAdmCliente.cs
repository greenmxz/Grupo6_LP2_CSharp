using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using Modelo;

namespace Vista {
    public enum estado { Nuevo, Registrar, Cerrado }
    public partial class frmAdmCliente : Form {
        private estado frmState;
        private frmBusquedaCliente frmCli;
        public frmAdmCliente() {
            InitializeComponent();
            definirEstado(estado.Nuevo);
            AdminDB.manipCombo("Distrito", "nombre", cboDistritoClientes);
            int id = AdminDB.executeFunction("obtener_idCliente", null, null);
            txtCodigoClientes.Text = Convert.ToString(id);
        }
        public estado Estado { get => frmState; set => frmState = value; }
        public void definirEstado(estado e)
        {
            frmState = e;
            switch (e)
            {
                case (estado.Nuevo):
                    btnAgregarCliente.Text = "Nuevo";
                    txtRUCClientes.Enabled = false;
                    txtRazSocClientes.Enabled = false;
                    txtTlfClientes.Enabled = false;
                    txtDirElecClientes.Enabled = false;
                    txtDirClientes.Enabled = false;
                    cboDistritoClientes.Enabled = false;
                    gbxCli1.Enabled = true;
                    gbxCli2.Enabled = false;
                    gbxCli3.Enabled = true;
                    break;
                case (estado.Registrar):
                    btnAgregarCliente.Text = "Registrar";
                    txtRUCClientes.Enabled = true;
                    txtRazSocClientes.Enabled = true;
                    txtTlfClientes.Enabled = true;
                    txtDirElecClientes.Enabled = true;
                    txtDirClientes.Enabled = true;
                    cboDistritoClientes.Enabled = true;
                    gbxCli1.Enabled = false;
                    gbxCli2.Enabled = true;
                    gbxCli3.Enabled = false;
                    break;
                case (estado.Cerrado):
                    break;
            }
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e) {
            if (frmCli == null || frmCli.Estado == estado.Cerrado) {
                frmCli = new frmBusquedaCliente();
                frmCli.Estado = estado.Nuevo;
                //frmCli.MdiParent = this.MdiParent;
                frmCli.StartPosition = FormStartPosition.Manual;
                frmCli.Left = 588;
                frmCli.Top = 112;
                frmCli.ShowDialog();
                //frmCli.Visible = true;
            }
            if (frmCli.DialogResult == DialogResult.OK)
            {
                Cliente c = frmCli.ClienteSelecc;
                txtCodigoClientes.Text = Convert.ToString(c.Id);
                txtRUCClientes.Text = c.Ruc;
                txtRazSocClientes.Text = c.RazonSocial;
                txtDirElecClientes.Text = c.Correo;
                txtDirClientes.Text = c.Direccion;
                txtTlfClientes.Text = c.Telefono;
                cboDistritoClientes.SelectedIndex = c.Distrito-1;
                definirEstado(estado.Registrar);
            }
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtCodigoClientes.Text);
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
                            BindingList<string> param = new BindingList<string>();
                            BindingList<string> values = new BindingList<string>();
                            param.Add("dist");
                            values.Add(dist);
                            string sentencia = "UPDATE Cliente SET ruc='" + RUC + "',razonSocial='" + razSoc +
                                "',telefono='" + telef + "',correo='" + correoElec + "',direccion='" + direc +
                                "',idDistrito=" + AdminDB.executeFunction("obtener_idDistrito", param, values) +
                                " WHERE idCliente=" + id + ";";
                            ConexionVista.conectar();
                            MySqlCommand cmdCli = new MySqlCommand();
                            cmdCli.CommandText = sentencia;
                            ConexionVista.cast(cmdCli);
                            cmdCli.ExecuteNonQuery();
                            MessageBox.Show("Cliente modificado exitosamente", "Modificación exitosa");
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
                btnLimpiarCliente_Click(sender, e);
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

            int id = Int32.Parse(txtCodigoClientes.Text);
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
                            ConexionVista.conectar();
                            MySqlCommand cmdCli = new MySqlCommand();
                            cmdCli.CommandText = "UPDATE Cliente SET estadoRegistro=2 WHERE idCliente=" + id + ";";
                            ConexionVista.cast(cmdCli);
                            cmdCli.ExecuteNonQuery();
                            MessageBox.Show("Cliente eliminado exitosamente", "Eliminación exitosa");
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
                btnLimpiarCliente_Click(sender, e);
            }
            else
            {
                Verificador.imprimirMessageBoxCliente(RUC, razSoc, telef, correoElec, direc, dist);
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            int nuevoID = AdminDB.executeFunction("obtener_idCliente", null, null);
            txtCodigoClientes.Text = Convert.ToString(nuevoID);
            txtRUCClientes.Text = "";
            txtRazSocClientes.Text = "";
            txtTlfClientes.Text = "";
            txtDirElecClientes.Text = "";
            txtDirClientes.Text = "";
            cboDistritoClientes.SelectedIndex = -1;
            definirEstado(estado.Nuevo);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (frmState == estado.Nuevo)
            {
                definirEstado(estado.Registrar);
            }
            else
            {
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
                                BindingList<string> param = new BindingList<string>();
                                BindingList<string> values = new BindingList<string>();
                                param.Add("dist");
                                values.Add(dist);
                                string sentencia = "INSERT INTO Cliente" +
                                    " VALUES (" + id + ",'" + RUC + "','" + razSoc + "','" + telef +
                                    "','" + correoElec + "','" + direc + "',1,1," + AdminDB.executeFunction("obtener_idDistrito", param, values) + ")";
                                ConexionVista.conectar();
                                MySqlCommand cmdCli = new MySqlCommand();
                                cmdCli.CommandText = sentencia;
                                ConexionVista.cast(cmdCli);
                                cmdCli.ExecuteNonQuery();
                                MessageBox.Show("Cliente registrado exitosamente", "Registro exitoso");
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
                    btnLimpiarCliente_Click(sender, e);
                }
                else
                {
                    Verificador.imprimirMessageBoxCliente(RUC, razSoc, telef, correoElec, direc, dist);
                }
            }
        }
    }
}