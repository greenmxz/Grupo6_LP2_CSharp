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
    public partial class frmBusquedaProveedor : Form
    {
        private estado _estado;
        public estado Estado { get => _estado; set => _estado = value; }
        public frmBusquedaProveedor()
        {
            InitializeComponent();
            Estado = estado.Nuevo;
        }

        private void btnSelecProv_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }

        private void btnCerrarBusqProveedor_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
    }
}
