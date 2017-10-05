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
    public partial class frmAdmProducto : Form
    {
        private estado frmState;
        private frmBusquedaProducto frmBPROD;

        public estado Estado { get => frmState; set => frmState = value; }

        public frmAdmProducto()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            this.frmState = estado.Cerrado;
        }

        public frmAdmProducto(Form padre)
        {
            InitializeComponent();
            MdiParent = padre;
            Visible = true;
            txtCodigo.Enabled = false;
            this.frmState = estado.Cerrado;

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
            this.frmState = estado.Cerrado;
            if (frmBPROD != null) { frmBPROD.Dispose(); }
        }
    }
}
