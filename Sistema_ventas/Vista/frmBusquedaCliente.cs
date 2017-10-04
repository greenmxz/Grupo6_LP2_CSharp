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
        private estado _estado;

        public estado Estado { get => _estado; set => _estado = value; }

        public frmBusquedaCliente()
        {
            InitializeComponent();
            Estado = estado.Nuevo;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e) {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
    }
}
