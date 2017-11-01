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
            AdmComboBox.manipCombo("TipoDocumento", "nombreTipo", cboTipo);
        }

        private void btnCerrarEnvioCorreo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSelecProd_Click(object sender, EventArgs e)
        {

            EnvioCorreo c = new EnvioCorreo();
            c.enviarCorreo("nrcteam.xd@gmail.com", txtCC.Text, txtCCO.Text, "xd1234562014", txtDetalle.Text, txtAsunto.Text, txtPara.Text, "distritos.txt");
            this.Dispose();
        }
    }
}
