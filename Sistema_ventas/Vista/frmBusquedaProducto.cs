using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmBusquedaProducto : Form
    {
        private estado _estado;
        public frmBusquedaProducto()
        {
            InitializeComponent();
        }

        public estado Estado { get => _estado; set => _estado = value; }

        private void btnCerrarBusqProducto_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
        private void btnSelecProd_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
    }
}
