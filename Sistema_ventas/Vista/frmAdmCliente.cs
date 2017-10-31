using System;
using System.IO;
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
            /* Manipulación de ComboBox */
            /* INICIO */
            FileStream fs = new FileStream("documents//distritos.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
            while (true)
            {
                string distrito = sr.ReadLine();
                if (distrito == null) { break; }
                cboDistritoClientes.Items.Add(distrito);
            }
            /* FIN */
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
        bool rucValido(string RUC)
        {
            if (RUC == "") { return false; }
            if (RUC.Length != 11) { return false; }
            if (RUC[1] != '0') { return false; }
            if (RUC[0] != '1' && RUC[0] != '2') { return false; }
            return true;
        }
        bool correoValido(string correo)
        {
            if(correo != "") { return false; }
            string[] div1 = correo.Split('@');
            if(div1[1].Length == 0) { return false; }
            string[] div2 = div1[1].Split('.');
            int num = 0;
            foreach (string val in div2)
            {
                num++;
            }
            string[] validadores = { "com", "es", "pe", "org" };
            foreach(string val in validadores)
            {
                if(val==div2[num-1]) { return true; }
            }
            return false;
        }
        void imprimirMessageBox(string RUC, string razSoc, string telef, string correo, string direc, string distrito)
        {
            string cadError = " errorres en el proceso";
            int contError = 0;
            if (!rucValido(RUC))
            {
                contError++;
                if (RUC == "") { cadError = cadError + Environment.NewLine + "- No ha proporcionado el Registro Único del Contribuyente (RUC)"; }
                else { cadError = cadError + Environment.NewLine + "- El RUC proporcionado no es válido"; }
            }
            if (telef == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado un teléfono";
            }
            if (razSoc == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado una razón social";
            }
            if (!correoValido(RUC))
            {
                contError++;
                if (correo == "") { cadError = cadError + Environment.NewLine + "- No ha proporcionado un correo electrónico"; }
                else { cadError = cadError + Environment.NewLine + "- El correo proporcionado no es válido"; }
            }
            if (direc == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado una dirección";
            }
            if (distrito == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado un distrito";
            }
            MessageBox.Show("Se han encontrado " + contError + cadError, "Error en el proceso");
        }
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            string RUC = txtRUCClientes.Text;
            string razSoc = txtRazSocClientes.Text;
            string telef = txtTlfClientes.Text;
            string correo = txtDirElecClientes.Text;
            string direc = txtDirClientes.Text;
            string distrito = cboDistritoClientes.Text;
            if (rucValido(RUC) && razSoc != "" && telef != "" && correoValido(correo) && direc != "" && distrito != "")
            {
                string cadena = "¿Está seguro de que desea registrar el siguiente cliente:";
                cadena = cadena + Environment.NewLine + "RUC : " + RUC;
                cadena = cadena + Environment.NewLine + "Razón social : " + razSoc;
                cadena = cadena + Environment.NewLine + "Teléfono : " + telef;
                cadena = cadena + Environment.NewLine + "Dirección electrónica : " + correo;
                cadena = cadena + Environment.NewLine + "Dirección física : " + direc;
                cadena = cadena + Environment.NewLine + "Distrito : " + distrito;
                cadena = cadena + Environment.NewLine + Environment.NewLine + "Se almacenará con código : " + obtenerCodTemporal(i);
                i++;
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de registro", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        /* MySqlCommand cmdCli = new MySqlCommand();
                         * cmdCli.CommandText = "INSERT INTO CLIENTE(ID,RUC,RazonSocial,Telefono,CorreoElect,Direccion,Distrito) 
                         * values (obtenerCodTemporal(i),RUC,razSoc,telef,correo,direc,distrito)";
                         */
                        MessageBox.Show("Cliente registrado exitosamente");
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
                imprimirMessageBox(RUC, razSoc, telef, correo, direc, distrito);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            string id = obtenerCodTemporal(i);
            string RUC = txtRUCClientes.Text;
            string razSoc = txtRazSocClientes.Text;
            string telef = txtTlfClientes.Text;
            string correo = txtDirElecClientes.Text;
            string direc = txtDirClientes.Text;
            string distrito = cboDistritoClientes.Text;
            if (rucValido(RUC) && razSoc != "" && telef != "" && correoValido(correo) && direc != "" && distrito != "")
            {
                string cadena = "¿Está seguro de que desea modificar la información del siguiente cliente:";
                cadena = cadena + Environment.NewLine + "Código : " + id;
                cadena = cadena + Environment.NewLine + "RUC : " + RUC;
                cadena = cadena + Environment.NewLine + "Razón social : " + razSoc;
                cadena = cadena + Environment.NewLine + "Teléfono : " + telef;
                cadena = cadena + Environment.NewLine + "Dirección electrónica : " + correo;
                cadena = cadena + Environment.NewLine + "Dirección física : " + direc;
                cadena = cadena + Environment.NewLine + "Distrito : " + distrito;
                cadena = cadena + Environment.NewLine + Environment.NewLine + "Los cambios en el cliente con código " + obtenerCodTemporal(i) + " NO serán reversibles";
                DialogResult result = MessageBox.Show(cadena, "Mensaje de modificación de registro", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        /* MySqlCommand cmdCli = new MySqlCommand();
                         * cmdCli.CommandText = "UPDATE CLIENTE
                         * SET RUC = RUC, RazonSocial = razSoc, Telefono=telef, CorreoElect=correo, Direccion=direc, Distrito=distrito 
                         * WHERE ID=i";
                         */
                        MessageBox.Show("Cliente modificado exitosamente");
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
                imprimirMessageBox(RUC, razSoc, telef, correo, direc, distrito);
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
            string correo = txtDirElecClientes.Text;
            string direc = txtDirClientes.Text;
            string distrito = cboDistritoClientes.Text;
            if (rucValido(RUC) && razSoc != "" && telef != "" && correoValido(correo) && direc != "" && distrito != "")
            {
                string cadena = "¿Está seguro de que desea eliminar el siguiente cliente:";
                cadena = cadena + Environment.NewLine + "Código : " + id;
                cadena = cadena + Environment.NewLine + "RUC : " + RUC;
                cadena = cadena + Environment.NewLine + "Razón social : " + razSoc;
                cadena = cadena + Environment.NewLine + "Teléfono : " + telef;
                cadena = cadena + Environment.NewLine + "Dirección electrónica : " + correo;
                cadena = cadena + Environment.NewLine + "Dirección física : " + direc;
                cadena = cadena + Environment.NewLine + "Distrito : " + distrito;
                cadena = cadena + Environment.NewLine + Environment.NewLine + "La eliminación del proveedor con código " + obtenerCodTemporal(i) + " NO serán reversibles";
                DialogResult result = MessageBox.Show(cadena, "Mensaje de eliminación de registro", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        /* MySqlCommand cmdCli = new MySqlCommand();
                         * cmdCli.CommandText = "DELETE FROM CLIENTE
                         * WHERE ID=i";
                         */
                        MessageBox.Show("Cliente eliminado exitosamente");
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
                imprimirMessageBox(RUC, razSoc, telef, correo, direc, distrito);
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
