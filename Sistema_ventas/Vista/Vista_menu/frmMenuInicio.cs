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
    public partial class frmMenuInicio : Form {
        
        public frmMenuInicio(Form padre,string nombreUsuario) {
            
            InitializeComponent();
            MdiParent = padre;
            lblNombreUsuario.Text = nombreUsuario;
            Color cMenu = Color.FromArgb(34, 45, 49);
            BackColor = cMenu;
            Visible = true;
            //Size = new Size(150,500);

        }

        private void lblClientes_MouseEnter(object sender, EventArgs e) {
            lblClientes.Font = new Font(this.Font,FontStyle.Bold);
            lblClientes.Cursor = Cursors.Hand;
        }

        private void lblClientes_MouseLeave(object sender, EventArgs e) {
            lblClientes.Font = new Font(this.Font,FontStyle.Regular);
            lblClientes.Cursor = Cursors.Default;
        }

        private void lblClientes_MouseHover(object sender, EventArgs e) {
            lblClientes.Font = new Font(this.Font, FontStyle.Bold);
            lblClientes.Cursor = Cursors.Hand;
        }

        private void lblPedidos_MouseHover(object sender, EventArgs e) {
            lblPedidos.Font = new Font(this.Font, FontStyle.Bold);
            lblPedidos.Cursor = Cursors.Hand;
        }

        private void lblPedidos_MouseLeave(object sender, EventArgs e) {
            lblPedidos.Font = new Font(this.Font, FontStyle.Regular);
            lblPedidos.Cursor = Cursors.Default;
        }

        private void lblProductos_MouseHover(object sender, EventArgs e) {
            lblProductos.Font = new Font(this.Font, FontStyle.Bold);
            lblProductos.Cursor = Cursors.Hand;
        }

        private void lblProductos_MouseLeave(object sender, EventArgs e) {
            lblProductos.Font = new Font(this.Font, FontStyle.Regular);
            lblProductos.Cursor = Cursors.Default;
        }

        private void lblProveedores_MouseHover(object sender, EventArgs e) {
            lblProveedores.Font = new Font(this.Font, FontStyle.Bold);
            lblProveedores.Cursor = Cursors.Hand;
        }

        private void lblProveedores_MouseLeave(object sender, EventArgs e) {
            lblProveedores.Font = new Font(this.Font, FontStyle.Regular);
            lblProveedores.Cursor = Cursors.Default;
        }

        private void lblClientes_Click(object sender, EventArgs e) {
            frmAdmCliente fClienteModificar = new frmAdmCliente(this.ParentForm);
            fClienteModificar.StartPosition = FormStartPosition.Manual;
            fClienteModificar.Left = 244;
            fClienteModificar.Top = 0;

        }

        private void lblPedidos_MouseEnter(object sender, EventArgs e) {
            lblPedidos.Font = new Font(this.Font, FontStyle.Bold);
            lblPedidos.Cursor = Cursors.Hand;
        }

        private void lblProductos_MouseEnter(object sender, EventArgs e) {
            lblProductos.Font = new Font(this.Font, FontStyle.Bold);
            lblProductos.Cursor = Cursors.Hand;
        }

        private void lblProveedores_MouseEnter(object sender, EventArgs e) {
            lblProveedores.Font = new Font(this.Font, FontStyle.Bold);
            lblProveedores.Cursor = Cursors.Hand;
        }

        private void lblProductos_Click(object sender, EventArgs e)
        {
            frmAdmProducto frmProd = new frmAdmProducto(this.ParentForm);
            frmProd.StartPosition = FormStartPosition.Manual;
            frmProd.Left = 136;
            frmProd.Top = -1;
        }
    }
}
