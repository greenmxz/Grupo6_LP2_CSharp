using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public enum estado { Nuevo, Cerrado }
    public partial class frmAdmCliente : Form
    {
        private estado frmState;
        private frmBusquedaCliente frmBusquedaCliente;
        private static int i = 1;
        string obtenerCodTemporal(int i)
        {
            string codTemporal = "PROV";
            if (i < 10) { codTemporal = codTemporal + "0"; }
            if (i < 100) { codTemporal = codTemporal + "0"; }
            codTemporal = codTemporal + Convert.ToString(i);
            return codTemporal;
        }
        public frmAdmCliente()
        {
            InitializeComponent();
            this.frmState = estado.Nuevo;
            
        }

        public estado Estado { get => frmState; set => frmState = value; }

        private void btnBuscarCliente_Click(object sender, EventArgs e) {
            if (frmBusquedaCliente == null || frmBusquedaCliente.Estado == estado.Cerrado)
            {


                frmBusquedaCliente = new frmBusquedaCliente();
                frmBusquedaCliente.Estado = estado.Nuevo;
                frmBusquedaCliente.MdiParent = this.MdiParent;
                
                frmBusquedaCliente.StartPosition = FormStartPosition.Manual;
                frmBusquedaCliente.Left = 588;
                
                frmBusquedaCliente.Top = 112;

                frmBusquedaCliente.Visible = true;
            }
        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.frmState = estado.Cerrado;
            if (frmBusquedaCliente != null) { frmBusquedaCliente.Dispose(); }
        }
        bool rucValido(string RUC)
        {
            if (RUC == "") { return false; }
            if (RUC.Length != 11) { return false; }
            if (RUC[1] != '0') { return false; }
            if (RUC[0] != '1' && RUC[0] != '2') { return false; }
            return true;
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
            if (correo == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado una correo electrónico";
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
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string RUC = txtRUCCliente.Text;
            string razSoc = txtRazSocCliente.Text;
            string telef = txtTlfCliente.Text;
            string correo = txtDirElecCliente.Text;
            string direc = txtDirCliente.Text;
            string distrito = cboDistritoCliente.Text;
            if (rucValido(RUC) && razSoc != "" && telef != "" && correo != "" && direc != "" && distrito != "")
            {
                string cadena = "¿Está seguro de que desea registrar el siguiente proveedor:";
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
                        MessageBox.Show("Proveedor registrado exitosamente");
                        txtCodigoCliente.Text = "PROV000" + Convert.ToString(i);
                        txtRUCCliente.Text = "";
                        txtRazSocCliente.Text = "";
                        txtTlfCliente.Text = "";
                        txtDirElecCliente.Text = "";
                        txtDirCliente.Text = "";
                        cboDistritoCliente.Text = "";
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

        }
    }
}
