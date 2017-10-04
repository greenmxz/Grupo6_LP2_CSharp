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
        
        public frmMenuInicio(Form padre) {
            
            InitializeComponent();
            MdiParent = padre;
            Visible = true;
            //Size = new Size(150,500);

        }

        private void lblClientes_MouseEnter(object sender, EventArgs e) {
            lblClientes.Font = new Font(lblClientes.Font.Name, 12);
            lblClientes.Cursor = Cursors.Hand;
        }

        private void lblClientes_MouseLeave(object sender, EventArgs e) {
            lblClientes.Font = new System.Drawing.Font(lblClientes.Font.Name,10);
            lblClientes.Cursor = Cursors.Default;
        }

        private void lblClientes_MouseHover(object sender, EventArgs e) {
            
        }

        private void lblPedidos_MouseHover(object sender, EventArgs e) {
            lblPedidos.Font = new Font(lblPedidos.Font.Name, 12);
            lblPedidos.Cursor = Cursors.Hand;
        }

        private void lblPedidos_MouseLeave(object sender, EventArgs e) {
            lblPedidos.Font = new System.Drawing.Font(lblPedidos.Font.Name, 10);
            lblPedidos.Cursor = Cursors.Default;
        }

        private void lblProductos_MouseHover(object sender, EventArgs e) {
            lblProductos.Font = new Font(lblProductos.Font.Name, 12);
            lblProductos.Cursor = Cursors.Hand;
        }

        private void lblProductos_MouseLeave(object sender, EventArgs e) {
            lblProductos.Font = new System.Drawing.Font(lblProductos.Font.Name, 10);
            lblProductos.Cursor = Cursors.Default;
        }

        private void lblProveedores_MouseHover(object sender, EventArgs e) {
            lblProveedores.Font = new Font(lblProveedores.Font.Name, 12);
            lblProveedores.Cursor = Cursors.Hand;
        }

        private void lblProveedores_MouseLeave(object sender, EventArgs e) {
            lblProveedores.Font = new System.Drawing.Font(lblProveedores.Font.Name, 10);
            lblProveedores.Cursor = Cursors.Default;
        }

        private void lblClientes_Click(object sender, EventArgs e) {
            frmAdmCliente fClienteModificar = new frmAdmCliente(this.ParentForm);
            fClienteModificar.StartPosition = FormStartPosition.Manual;
            fClienteModificar.Left = 136;
            fClienteModificar.Top = -1;

        }

        private void lblPedidos_MouseEnter(object sender, EventArgs e) {
            lblPedidos.Font = new Font(lblPedidos.Font.Name, 12);
            lblPedidos.Cursor = Cursors.Hand;
        }

        private void lblProductos_MouseEnter(object sender, EventArgs e) {
            lblProductos.Font = new Font(lblProductos.Font.Name, 12);
            lblProductos.Cursor = Cursors.Hand;
        }

        private void lblProveedores_MouseEnter(object sender, EventArgs e) {
            lblProveedores.Font = new Font(lblProveedores.Font.Name, 12);
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
