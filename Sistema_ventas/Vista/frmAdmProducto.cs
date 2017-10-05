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
    //public enum estado { Nuevo, Cerrado }
    public partial class frmAdmProducto : Form
    {
        private estado _estado;
        private frmBusquedaProducto frmBPROD;

        public estado Estado { get => _estado; set => _estado = value; }

        public frmAdmProducto()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            this.Estado = estado.Cerrado;
        }

        public frmAdmProducto(Form padre)
        {
            InitializeComponent();
            MdiParent = padre;
            Visible = true;
            txtCodigo.Enabled = false;
            this.Estado = estado.Cerrado;

        }

        private void txtStockIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar.Equals('.')))
            {
                e.Handled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
            if (frmBPROD != null) { frmBPROD.Dispose(); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (frmBPROD == null || frmBPROD.Estado == estado.Cerrado)
            {
                frmBPROD = new frmBusquedaProducto();
                frmBPROD.Estado = estado.Nuevo;
                frmBPROD.MdiParent = this.MdiParent;
                frmBPROD.StartPosition = FormStartPosition.Manual;
                frmBPROD.Left = 588;
                frmBPROD.Top = 0;
                frmBPROD.Visible = true;
                
            }
        }
    }
}
