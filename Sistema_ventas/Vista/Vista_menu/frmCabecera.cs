using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Vista_menu {
    public partial class frmCabecera : Form {
        private bool abierto=false;
        private frmMenuInicioAdm menuInicioAdm;
        private frmMenuInicioVentas menuInicioVentas;

        public bool Abierto { get => abierto; set => abierto = value; }
        public frmMenuInicioVentas MenuInicioVentas { get => menuInicioVentas; set => menuInicioVentas = value; }
        public frmMenuInicioAdm MenuInicioAdm { get => menuInicioAdm; set => menuInicioAdm = value; }
        public frmCabecera( string nombreUsuario) {
            InitializeComponent();
            lblNombreUsuario.Text = nombreUsuario;
            btnMenu.FlatAppearance.BorderColor = Color.FromArgb(31, 29, 28);
            btnMenu.TabStop = false;
            btnMenu.ForeColor = Color.FromArgb(31, 29, 28);
        }
        private void btnMenu_MouseEnter(object sender, EventArgs e) {
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatStyle = FlatStyle.Popup;
        }
        private void btnMenu_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
            btnMenu.FlatStyle = FlatStyle.Flat;
        }
        private void btnMenu_MouseClick(object sender, MouseEventArgs e) {
            if (Abierto == false) {
                if (lblNombreUsuario.Text != "cyn") {
                    MenuInicioAdm = new frmMenuInicioAdm((frmCabecera)this);
                    MenuInicioAdm.MdiParent = this.ParentForm;
                    MenuInicioAdm.Show();
                    Abierto = true;
                }
                else {
                    MenuInicioVentas= new frmMenuInicioVentas((frmCabecera)this);
                    MenuInicioVentas.MdiParent = this.ParentForm;
                    MenuInicioVentas.Show();
                    Abierto = true;
                }
            }
            else {
                if (lblNombreUsuario.Text != "cyn") {
                    MenuInicioAdm.Dispose();
                    
                }
                else {
                    MenuInicioVentas.Dispose();
                }
                Abierto = false; 
            }
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            this.MdiParent.Close();

        }
        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e) {
            this.Cursor = Cursors.Hand;
        }
        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e) {
            this.Cursor = Cursors.Default;
        }
    }
}
