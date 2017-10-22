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
    public partial class frmAdmPedido : Form
    {
        private estado frmState;
        private frmBusquedaPedido frmBusquedaPedido;
        public frmAdmPedido()
        {
            InitializeComponent();
        }

        public estado Estado { get => frmState; set => frmState = value; }

        private void btnBuscarPedido_Click(object sender, EventArgs e) {
            if (frmBusquedaPedido == null || frmBusquedaPedido.Estado == estado.Cerrado) {


                frmBusquedaPedido = new frmBusquedaPedido();
                frmBusquedaPedido.Estado = estado.Nuevo;
                frmBusquedaPedido.MdiParent = this.MdiParent;

                frmBusquedaPedido.StartPosition = FormStartPosition.Manual;
                frmBusquedaPedido.Left = 588;

                frmBusquedaPedido.Top = 112;

                frmBusquedaPedido.Visible = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Dispose();
            this.Estado = estado.Cerrado;
            if (frmBusquedaPedido != null) { frmBusquedaPedido.Dispose(); }
        }
    }
}
