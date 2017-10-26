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
    public partial class frmEnvioCorreo : Form
    {
        public frmEnvioCorreo()
        {
            InitializeComponent();
        }

        private void btnCerrarEnvioCorreo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSelecProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El documento solicitado ha sido enviado a la(s) dirección(es) indicada(s)", "Éxito de operación");
            this.Dispose();
        }
    }
}
