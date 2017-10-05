using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista {
    public partial class Login : Form {
        private string _nombreUsuario;
        public Login() {
            InitializeComponent();
            
        }

        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }

        //public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }

        private void btnIngresar_Click(object sender, EventArgs e) {
            NombreUsuario = txtUsuario.Text;
            this.DialogResult = DialogResult.OK;
            //Principal principal = new Principal(txtUsuario.Text);
 
            //principal.Show();
            
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                NombreUsuario = txtUsuario.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
