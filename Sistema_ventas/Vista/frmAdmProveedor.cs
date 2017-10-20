using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class frmAdmProveedor : Form
    {
        private estado estBusquedaProv;
        private frmBusquedaProveedor frmBusqProv;
        //private BindingList
        private static int i=1;
        string obtenerCodTemporal(int i)
        {
            string codTemporal = "PROV";
            if(i<10) { codTemporal = codTemporal + "0"; }
            if(i<100) { codTemporal = codTemporal + "0"; }
            codTemporal = codTemporal + Convert.ToString(i);
            return codTemporal;
        }
        public frmAdmProveedor()
        {
            InitializeComponent();
            cboDistritoProveedor.Items.Insert(0, "Cercado de Lima");
            cboDistritoProveedor.Items.Insert(1, "Cercado de Callao");
            cboDistritoProveedor.Items.Insert(2, "Ancón");
            cboDistritoProveedor.Items.Insert(3, "Ate");
            cboDistritoProveedor.Items.Insert(4, "Barranco");
            cboDistritoProveedor.Items.Insert(5, "Bellavista");
            cboDistritoProveedor.Items.Insert(6, "Breña");
            cboDistritoProveedor.Items.Insert(7, "Carabayllo");
            cboDistritoProveedor.Items.Insert(8, "Carmen de la Legua Reynoso");
            cboDistritoProveedor.Items.Insert(9, "Cieneguilla");
            cboDistritoProveedor.Items.Insert(10, "Comas");
            cboDistritoProveedor.Items.Insert(11, "Chorrillos");
            cboDistritoProveedor.Items.Insert(12, "El Agustino");
            cboDistritoProveedor.Items.Insert(13, "Independencia");
            cboDistritoProveedor.Items.Insert(14, "Jesús María");
            cboDistritoProveedor.Items.Insert(15, "La Molina");
            cboDistritoProveedor.Items.Insert(16, "La Perla");
            cboDistritoProveedor.Items.Insert(17, "La Punta");
            cboDistritoProveedor.Items.Insert(18, "La Victoria");
            cboDistritoProveedor.Items.Insert(19, "Lince");
            cboDistritoProveedor.Items.Insert(20, "Los Olivos");
            cboDistritoProveedor.Items.Insert(21, "Lurigancho");
            cboDistritoProveedor.Items.Insert(22, "Lurín");
            cboDistritoProveedor.Items.Insert(23, "Magdalena del Mar");
            cboDistritoProveedor.Items.Insert(24, "Mi Perú");
            cboDistritoProveedor.Items.Insert(25, "Miraflores");
            cboDistritoProveedor.Items.Insert(26, "Pachacamac");
            cboDistritoProveedor.Items.Insert(27, "Pucusana");
            cboDistritoProveedor.Items.Insert(28, "Pueblo Libre");
            cboDistritoProveedor.Items.Insert(29, "Puente Piedra");
            cboDistritoProveedor.Items.Insert(30, "Punta Hermosa");
            cboDistritoProveedor.Items.Insert(31, "Punta Negra");
            cboDistritoProveedor.Items.Insert(32, "Rímac");
            cboDistritoProveedor.Items.Insert(33, "San Bartolo");
            cboDistritoProveedor.Items.Insert(34, "San Borja");
            cboDistritoProveedor.Items.Insert(35, "San Isidro");
            cboDistritoProveedor.Items.Insert(36, "San Juan de Lurigancho");
            cboDistritoProveedor.Items.Insert(37, "San Juan de Miraflores");
            cboDistritoProveedor.Items.Insert(38, "San Luis");
            cboDistritoProveedor.Items.Insert(39, "San Martín de Porres");
            cboDistritoProveedor.Items.Insert(40, "San Miguel");
            cboDistritoProveedor.Items.Insert(41, "Santa Anita");
            cboDistritoProveedor.Items.Insert(42, "Santa María del Mar");
            cboDistritoProveedor.Items.Insert(43, "Santa Rosa");
            cboDistritoProveedor.Items.Insert(44, "Santiago de Surco");
            cboDistritoProveedor.Items.Insert(45, "Surquillo");
            cboDistritoProveedor.Items.Insert(46, "Ventanilla");
            cboDistritoProveedor.Items.Insert(47, "Villa el Salvador");
            cboDistritoProveedor.Items.Insert(48, "Villa María del Triunfo");
            estBusquedaProv = estado.Nuevo;
            txtCodigoProveedor.Text = obtenerCodTemporal(i);
        }

        public estado Estado { get => estBusquedaProv; set => estBusquedaProv = value; }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            txtRUCProveedores.Text = "";
            txtRazSocProveedores.Text = "";
            txtTlfProveedores.Text = "";
            txtDirElecProveedores.Text = "";
            txtDirProveedores.Text = "";
            cboDistritoProveedor.Text = "";
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (frmBusqProv == null || frmBusqProv.Estado == estado.Cerrado)
            {
                frmBusqProv = new frmBusquedaProveedor();
                frmBusqProv.Estado = estado.Nuevo;
                frmBusqProv.MdiParent = this.MdiParent;
                
                frmBusqProv.StartPosition = FormStartPosition.Manual;
                frmBusqProv.Left = 588;
                frmBusqProv.Top = 112;
                frmBusqProv.Visible = true;
            }
            txtCodigoProveedor.Text = obtenerCodTemporal(i);
        }

        private void frmAdmProveedor_Load(object sender, EventArgs e)
        {
        }

        private void btnCerrarProveedor_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.estBusquedaProv = estado.Cerrado;
            if (frmBusqProv != null) { frmBusqProv.Dispose(); }
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

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            string RUC = txtRUCProveedores.Text;
            string razSoc = txtRazSocProveedores.Text;
            string telef = txtTlfProveedores.Text;
            string correo = txtDirElecProveedores.Text;
            string direc = txtDirProveedores.Text;
            string distrito = cboDistritoProveedor.Text;
            if (rucValido(RUC) && razSoc != "" && telef != "" && correo != "" && direc != "" && distrito != "")
            {
                i++;
                string cadena = "¿Está seguro de que desea registrar el siguiente proveedor:";
                cadena = cadena + Environment.NewLine + "RUC : " + RUC;
                cadena = cadena + Environment.NewLine + "Razón social : " + razSoc;
                cadena = cadena + Environment.NewLine + "Teléfono : " + telef;
                cadena = cadena + Environment.NewLine + "Dirección electrónica : " + correo;
                cadena = cadena + Environment.NewLine + "Dirección física : " + direc;
                cadena = cadena + Environment.NewLine + "Distrito : " + distrito;
                cadena = cadena + Environment.NewLine + Environment.NewLine + "Se almacenará con código : " + obtenerCodTemporal(i) ;
                DialogResult result = MessageBox.Show(cadena, "Mensaje de confirmación de registro", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Proveedor registrado exitosamente");
                        txtCodigoProveedor.Text = "PROV000" + Convert.ToString(i);
                        txtRUCProveedores.Text = "";
                        txtRazSocProveedores.Text = "";
                        txtTlfProveedores.Text = "";
                        txtDirElecProveedores.Text = "";
                        txtDirProveedores.Text = "";
                        cboDistritoProveedor.Text = "";
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

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            string id = obtenerCodTemporal(i);
            string RUC = txtRUCProveedores.Text;
            string razSoc = txtRazSocProveedores.Text;
            string telef = txtTlfProveedores.Text;
            string correo = txtDirElecProveedores.Text;
            string direc = txtDirProveedores.Text;
            string distrito = cboDistritoProveedor.Text;
            if (rucValido(RUC) && razSoc != "" && telef != "" && correo != "" && direc != "" && distrito != "")
            {
                string cadena = "¿Está seguro de que desea modificar la información del siguiente proveedor:";
                cadena = cadena + Environment.NewLine + "Código : " + id;
                cadena = cadena + Environment.NewLine + "RUC : " + RUC;
                cadena = cadena + Environment.NewLine + "Razón social : " + razSoc;
                cadena = cadena + Environment.NewLine + "Teléfono : " + telef;
                cadena = cadena + Environment.NewLine + "Dirección electrónica : " + correo;
                cadena = cadena + Environment.NewLine + "Dirección física : " + direc;
                cadena = cadena + Environment.NewLine + "Distrito : " + distrito;
                cadena = cadena + Environment.NewLine + Environment.NewLine + "Los cambios en el proveedor con código : " + obtenerCodTemporal(i) + "NO serán reversibles";
                DialogResult result = MessageBox.Show(cadena, "Mensaje de modificación de registro", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Proveedor modificado exitosamente");
                        txtCodigoProveedor.Text = "";
                        txtRUCProveedores.Text = "";
                        txtRazSocProveedores.Text = "";
                        txtTlfProveedores.Text = "";
                        txtDirElecProveedores.Text = "";
                        txtDirProveedores.Text = "";
                        cboDistritoProveedor.Text = "";
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

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            string id = obtenerCodTemporal(i);
            string RUC = txtRUCProveedores.Text;
            string razSoc = txtRazSocProveedores.Text;
            string telef = txtTlfProveedores.Text;
            string correo = txtDirElecProveedores.Text;
            string direc = txtDirProveedores.Text;
            string distrito = cboDistritoProveedor.Text;
            if (rucValido(RUC) && razSoc != "" && telef != "" && correo != "" && direc != "" && distrito != "")
            {
                string cadena = "¿Está seguro de que desea eliminar el siguiente proveedor:";
                cadena = cadena + Environment.NewLine + "Código : " + id;
                cadena = cadena + Environment.NewLine + "RUC : " + RUC;
                cadena = cadena + Environment.NewLine + "Razón social : " + razSoc;
                cadena = cadena + Environment.NewLine + "Teléfono : " + telef;
                cadena = cadena + Environment.NewLine + "Dirección electrónica : " + correo;
                cadena = cadena + Environment.NewLine + "Dirección física : " + direc;
                cadena = cadena + Environment.NewLine + "Distrito : " + distrito;
                cadena = cadena + Environment.NewLine + Environment.NewLine + "La eliminación del proveedor con código : " + obtenerCodTemporal(i) + "NO serán reversibles";
                DialogResult result = MessageBox.Show(cadena, "Mensaje de eliminación de registro", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Proveedor eliminado exitosamente");
                        txtCodigoProveedor.Text = "";
                        txtRUCProveedores.Text = "";
                        txtRazSocProveedores.Text = "";
                        txtTlfProveedores.Text = "";
                        txtDirElecProveedores.Text = "";
                        txtDirProveedores.Text = "";
                        cboDistritoProveedor.Text = "";
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

        private void btnAgregarProveedor_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnAgregarProveedor_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnModificarProveedor_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnModificarProveedor_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnEliminarProveedor_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnEliminarProveedor_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnLimpiarProveedor_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnLimpiarProveedor_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnBuscarProveedor_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnBuscarProveedor_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
