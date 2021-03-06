﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using Modelo;
using Controlador;

namespace Vista {
    public enum estado { Nuevo, Registrar, Buscar, Modificar, Cerrado }
    public partial class frmAdmCliente : Form {
        private estado frmState;
        private frmBusquedaCliente frmCli;
        private Usuario login;
        public frmAdmCliente(Usuario user) {
            InitializeComponent();
            definirEstado(estado.Nuevo);
            AdminDB.manipCombo("Distrito", "nombre", cboDistritoClientes);
            BindingList<string> aux = new BindingList<string>();
            int id = AdminDB.executeFunction("obtener_idCliente", null, aux);
            txtCodigoClientes.Text = Convert.ToString(id);
            tip1.SetToolTip(pBoxI1, "Un Registro Único de Contribuyente es" + Environment.NewLine + "válido si tiene 11 dígitos y empieza en '20'");
            tip1.SetToolTip(pBoxI2, "Un correo es válido si pertenece" + Environment.NewLine + "a los siguientes dominios:" + Environment.NewLine + 
                "'com', 'es', 'pe', 'org'");
            login = user;
        }
        public estado Estado { get => frmState; set => frmState = value; }
        public void definirEstado(estado e)
        {
            frmState = e;
            switch (e)
            {
                case (estado.Nuevo):
                    btnAgregarCliente.Text = "Nuevo";
                    btnModificarCliente.Text = "Modificar";
                    txtRUCClientes.Enabled = false;
                    txtRazSocClientes.Enabled = false;
                    txtTlfClientes.Enabled = false;
                    txtDirElecClientes.Enabled = false;
                    txtDirClientes.Enabled = false;
                    cboDistritoClientes.Enabled = false;
                    gbxCli1.Enabled = true;
                    btnModificarCliente.Enabled = false;
                    btnEliminarCliente.Enabled = false;
                    btnLimpiarCliente.Enabled = false;
                    gbxCli3.Enabled = true;
                    break;
                case (estado.Registrar):
                    btnAgregarCliente.Text = "Registrar";
                    btnModificarCliente.Text = "Modificar";
                    txtRUCClientes.Enabled = true;
                    txtRazSocClientes.Enabled = true;
                    txtTlfClientes.Enabled = true;
                    txtDirElecClientes.Enabled = true;
                    txtDirClientes.Enabled = true;
                    cboDistritoClientes.Enabled = true;
                    gbxCli1.Enabled = true;
                    btnModificarCliente.Enabled = false;
                    btnEliminarCliente.Enabled = false;
                    btnLimpiarCliente.Enabled = true;
                    gbxCli3.Enabled = false;
                    break;
                case (estado.Buscar):
                    btnAgregarCliente.Text = "Nuevo";
                    btnModificarCliente.Text = "Modificar";
                    txtRUCClientes.Enabled = false;
                    txtRazSocClientes.Enabled = false;
                    txtTlfClientes.Enabled = false;
                    txtDirElecClientes.Enabled = false;
                    txtDirClientes.Enabled = false;
                    cboDistritoClientes.Enabled = false;
                    gbxCli1.Enabled = false;
                    btnModificarCliente.Enabled = true;
                    btnEliminarCliente.Enabled = true;
                    btnLimpiarCliente.Enabled = true;
                    gbxCli3.Enabled = false;
                    break;
                case (estado.Modificar):
                    btnAgregarCliente.Text = "Nuevo";
                    btnModificarCliente.Text = "Confirmar";
                    txtRUCClientes.Enabled = true;
                    txtRazSocClientes.Enabled = true;
                    txtTlfClientes.Enabled = true;
                    txtDirElecClientes.Enabled = true;
                    txtDirClientes.Enabled = true;
                    cboDistritoClientes.Enabled = true;
                    gbxCli1.Enabled = false;
                    btnModificarCliente.Enabled = true;
                    btnEliminarCliente.Enabled = false;
                    btnLimpiarCliente.Enabled = true;
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
                definirEstado(estado.Buscar);
            }
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (frmState == estado.Buscar)
            {
                definirEstado(estado.Modificar);
            }
            else
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
                    string cadena = "¿Está seguro de que desea modificar la información del siguiente cliente?:";
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

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            Dispose();
            frmState = estado.Cerrado;
            if (frmCli != null) { frmCli.Dispose(); }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtCodigoClientes.Text);
            BindingList<string> param = new BindingList<string>();
            BindingList<int> values = new BindingList<int>();
            param.Add("busqID");
            values.Add(id);
            int countDepend = AdminDB.executeFunction("contarPedidosXCliente", param, values);
            if (countDepend == 0)
            {
                string cadena = "¿Está seguro de que desea eliminar el siguiente cliente?:";
                cadena = cadena + Environment.NewLine + "Código : " + txtCodigoClientes.Text;
                cadena = cadena + Environment.NewLine + "RUC : " + txtRUCClientes.Text;
                cadena = cadena + Environment.NewLine + "Razón social : " + txtRazSocClientes.Text;
                cadena = cadena + Environment.NewLine + "Teléfono : " + txtTlfClientes.Text;
                cadena = cadena + Environment.NewLine + "Dirección electrónica : " + txtDirElecClientes.Text;
                cadena = cadena + Environment.NewLine + "Dirección física : " + txtDirClientes.Text;
                cadena = cadena + Environment.NewLine + "Distrito : " + cboDistritoClientes.Text;
                cadena = cadena + Environment.NewLine + Environment.NewLine + "La eliminación del proveedor con código " + Convert.ToString(id) + " NO será reversible";
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
                string diferencial;
                if (countDepend == 1)
                {
                    diferencial = " pedido";
                }
                else
                {
                    diferencial = " pedidos";
                }
                MessageBox.Show("No puede eliminarse este cliente, puesto que se ha detectado " + countDepend + diferencial + " que lo involucran", "Dependencia pedido-cliente detectada");
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            BindingList<string> aux = new BindingList<string>();
            int nuevoID = AdminDB.executeFunction("obtener_idCliente", null, aux);
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
                BindingList<string> aux = new BindingList<string>();
                int id = AdminDB.executeFunction("obtener_idCliente", null, aux);
                txtCodigoClientes.Text = Convert.ToString(id);
                string RUC = txtRUCClientes.Text;
                string razSoc = txtRazSocClientes.Text;
                string telef = txtTlfClientes.Text;
                string correoElec = txtDirElecClientes.Text;
                string direc = txtDirClientes.Text;
                string dist = cboDistritoClientes.Text;
                if (Verificador.rucValido(RUC) && razSoc != "" && telef != "" && Verificador.correoValido(correoElec) && direc != "" && dist != "")
                {
                    string cadena = "¿Está seguro de que desea registrar el siguiente cliente?:";
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
                                    "','" + correoElec + "','" + direc + "',1," + login.IdUsuario +"," + AdminDB.executeFunction("obtener_idDistrito", param, values) + ")";
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

        private void txtRUCClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}