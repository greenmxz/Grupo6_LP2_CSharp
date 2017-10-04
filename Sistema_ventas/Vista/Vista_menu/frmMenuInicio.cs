using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Vista_menu
{
    public enum estado { Nuevo,Cerrado}
    public partial class frmMenuInicio : Form {
        private frmAdmCliente frmAdmCliente;
        public frmMenuInicio(Form principal,string nombreUsuario) {
            
            InitializeComponent();
            MdiParent = principal;
            lblNombreUsuario.Text = nombreUsuario;
            Color cMenu = Color.FromArgb(34, 45, 49);
            BackColor = cMenu;
            Visible = true;
            //Size = new Size(150,500);

        }

        private void lblClientes_MouseEnter(object sender, EventArgs e) {
            lblClientes.Font = new Font(this.Font,FontStyle.Bold | FontStyle.Italic);
            lblClientes.Cursor = Cursors.Hand;
        }

        private void lblClientes_MouseLeave(object sender, EventArgs e) {
            lblClientes.Font = new Font(this.Font,FontStyle.Regular);
            lblClientes.Cursor = Cursors.Default;
        }

        private void lblClientes_MouseHover(object sender, EventArgs e) {
            lblClientes.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            lblClientes.Cursor = Cursors.Hand;
        }

        private void lblPedidos_MouseHover(object sender, EventArgs e) {
            lblPedidos.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            lblPedidos.Cursor = Cursors.Hand;
        }

        private void lblPedidos_MouseLeave(object sender, EventArgs e) {
            lblPedidos.Font = new Font(this.Font, FontStyle.Regular);
            lblPedidos.Cursor = Cursors.Default;
        }

        private void lblProductos_MouseHover(object sender, EventArgs e) {
            lblProductos.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            lblProductos.Cursor = Cursors.Hand;
        }

        private void lblProductos_MouseLeave(object sender, EventArgs e) {
            lblProductos.Font = new Font(this.Font, FontStyle.Regular);
            lblProductos.Cursor = Cursors.Default;
        }

        private void lblProveedores_MouseHover(object sender, EventArgs e) {
            lblProveedores.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            lblProveedores.Cursor = Cursors.Hand;
        }

        private void lblProveedores_MouseLeave(object sender, EventArgs e) {
            lblProveedores.Font = new Font(this.Font, FontStyle.Regular);
            lblProveedores.Cursor = Cursors.Default;
        }

        private void lblPedidos_MouseEnter(object sender, EventArgs e) {
            lblPedidos.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            lblPedidos.Cursor = Cursors.Hand;
        }

        private void lblProductos_MouseEnter(object sender, EventArgs e) {
            lblProductos.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            lblProductos.Cursor = Cursors.Hand;
        }

        private void lblProveedores_MouseEnter(object sender, EventArgs e) {
            lblProveedores.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            lblProveedores.Cursor = Cursors.Hand;
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            if (frmAdmCliente == null || frmAdmCliente.Estado == Vista.estado.Cerrado)
            {
                frmAdmCliente = new frmAdmCliente();
                frmAdmCliente.MdiParent = this.MdiParent;
                frmAdmCliente.Show();

                frmAdmCliente.StartPosition = FormStartPosition.Manual;
                frmAdmCliente.Left = 244;
                frmAdmCliente.Top = 0;
            }

        }

        private void lblProductos_Click(object sender, EventArgs e)
        {
            frmAdmProducto frmProd = new frmAdmProducto(this.ParentForm);
            frmProd.StartPosition = FormStartPosition.Manual;
            frmProd.Left = 136;
            frmProd.Top = -1;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.MdiParent.Close();
        }
    }
}
