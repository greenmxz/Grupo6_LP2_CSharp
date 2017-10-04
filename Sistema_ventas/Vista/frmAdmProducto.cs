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
    public partial class frmAdmProducto : Form
    {
        public frmAdmProducto()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
        }

        public frmAdmProducto(Form padre)
        {
            InitializeComponent();
            MdiParent = padre;
            Visible = true;
            txtCodigo.Enabled = false;
           

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
    }
}
