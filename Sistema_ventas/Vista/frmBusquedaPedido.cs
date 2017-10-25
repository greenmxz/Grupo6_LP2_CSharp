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
    public partial class frmBusquedaPedido : Form
    {
        private estado _estado;
        public frmBusquedaPedido()
        {
            InitializeComponent();
            Estado = estado.Nuevo;
        }
        public estado Estado { get => _estado; set => _estado = value; }
        private void btnCerrarBusqPedido_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
        private void btnSelecPed_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
    }
}
