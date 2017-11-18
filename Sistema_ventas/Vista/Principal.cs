using System;
using System.Windows.Forms;
using Vista.Vista_menu;
using Modelo;

namespace Vista
{
    public partial class Principal : Form
    {
        private frmCabecera fCabecera;
        public Principal(Usuario user)
        {
            InitializeComponent();
            IsMdiContainer = true;
            fCabecera = new frmCabecera (user);
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
