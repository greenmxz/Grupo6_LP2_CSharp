using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Vista_menu {
    public partial class frmCabecera : Form {
        private bool abierto=false;
        private frmMenuInicio menuInicio;

        public bool Abierto { get => abierto; set => abierto = value; }
        public frmMenuInicio MenuInicio { get => menuInicio; set => menuInicio = value; }

        public frmCabecera( string nombreUsuario) {
            InitializeComponent();
            lblNombreUsuario.Text = nombreUsuario;
            btnMenu.FlatAppearance.BorderColor = Color.FromArgb(31, 29, 28);
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e) {
            btnMenu.Cursor = Cursors.Hand;
        }


        private void btnMenu_MouseClick(object sender, MouseEventArgs e) {
            if (Abierto == false) {
                MenuInicio = new frmMenuInicio((frmCabecera)this);
                MenuInicio.MdiParent = this.ParentForm;
                MenuInicio.Show();
                Abierto = true;
            }
            else {
                MenuInicio.Dispose();
                Abierto = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            this.MdiParent.Close();

        }

        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
        }

        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
        }


    }
}
