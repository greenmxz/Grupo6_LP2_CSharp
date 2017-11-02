using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmBusquedaCliente : Form
    {
        private estado _estado;

        public estado Estado { get => _estado; set => _estado = value; }

        public frmBusquedaCliente()
        {
            InitializeComponent();
            Estado = estado.Nuevo;
        }
        private void btnCerrarBusqCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
        private void btnSelecCli_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
    }
}
