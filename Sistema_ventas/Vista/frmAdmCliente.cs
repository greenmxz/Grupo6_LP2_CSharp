using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista {
    public enum estado { Nuevo, Cerrado }
    public partial class frmAdmCliente : Form {
        private estado frmState;
        private frmBusquedaCliente frmBusquedaCliente;
        private static int i = 1;
        string obtenerCodTemporal(int i)
        {
            string codTemporal = "CLI";
            if (i < 10) { codTemporal = codTemporal + "0"; }
            if (i < 100) { codTemporal = codTemporal + "0"; }
            codTemporal = codTemporal + Convert.ToString(i);
            return codTemporal;
        }
        public frmAdmCliente() {
            InitializeComponent();
            this.frmState = estado.Nuevo;
            AdmComboBox.manipCombo("distritos.txt", cboDistritoClientes);
            txtCodigoClientes.Text = obtenerCodTemporal(i);
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
            txtCodigoClientes.Text = obtenerCodTemporal(i);
        }
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
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
                cadena = cadena + Environment.NewLine + Environment.NewLine + "Se almacenará con código : " + obtenerCodTemporal(i);
                i++;
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de registro", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        /* MySqlCommand cmdCli = new MySqlCommand();
                         * cmdCli.CommandText = "INSERT INTO CLIENTE(idCliente,ruc,razonSocial,telefono,correo,direccion,distrito) 
                         * values (i,RUC,razSoc,telef,correoElec,direc,dist)";
                         */
                        MessageBox.Show("Cliente registrado exitosamente", "Registro exitoso");
                        txtCodigoClientes.Text = obtenerCodTemporal(i);
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
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            string id = obtenerCodTemporal(i);
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
                cadena = cadena + Environment.NewLine + Environment.NewLine + "Los cambios en el cliente con código " + obtenerCodTemporal(i) + " NO serán reversibles";
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
            string id = obtenerCodTemporal(i);
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
                cadena = cadena + Environment.NewLine + Environment.NewLine + "La eliminación del proveedor con código " + obtenerCodTemporal(i) + " NO serán reversibles";
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