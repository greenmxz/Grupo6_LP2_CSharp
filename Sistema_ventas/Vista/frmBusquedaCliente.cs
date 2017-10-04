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
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente(Form padre)
        {
            InitializeComponent();
            MdiParent= padre;
            Visible = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
