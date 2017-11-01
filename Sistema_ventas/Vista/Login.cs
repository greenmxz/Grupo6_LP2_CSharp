using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Modelo;

namespace Vista {
    public partial class Login : Form {
        Usuario usuario;
        public Login() {
            InitializeComponent();
            usuario = new Usuario();
            
        }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        //public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        //public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        private void btnIngresar_Click(object sender, EventArgs e) {
            usuario.Nombre = txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;
            //Principal principal = new Principal(txtUsuario.Text);
            //while (true)
            //{
                if (string.ReferenceEquals(usuario.Nombre, "") || string.ReferenceEquals(usuario.Contraseña, ""))
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBoxTemporal.Show("Ingreso correcto", "Validación de ingreso", 3, true);
                    //MessageBox.Show("Ingreso Correcto");
                    this.DialogResult = DialogResult.OK;
                }
            //}
        }
        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                usuario.Nombre = txtUsuario.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
