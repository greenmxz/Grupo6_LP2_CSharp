using System;
using System.Windows.Forms;
using Vista.Vista_menu;

namespace Vista
{
    public partial class Principal : Form
    {
        private frmCabecera fCabecera;
        public Principal(string nombreUsuario)
        {
            InitializeComponent();
            IsMdiContainer = true;
            //this.Size = new Size(700,350);
            //FormBorderStyle = FormBorderStyle.None;
            //frmMenuInicio fMenuInicio = new frmMenuInicio(this,nombreUsuario);
            fCabecera = new frmCabecera (nombreUsuario);
            fCabecera.MdiParent = this;
            fCabecera.Show();
        }
        public frmCabecera FCabecera { get => fCabecera; set => fCabecera = value; }
        private void Principal_MouseClick(object sender, MouseEventArgs e) {
            if (fCabecera.Abierto == true) {
                fCabecera.Dispose();
                fCabecera.Abierto = false;
            }
        }
        private void Principal_Click(object sender, EventArgs e) {
            if (fCabecera.Abierto == true) {
            fCabecera.Close();
            fCabecera.Abierto = false;
            }
        }
    }
}
