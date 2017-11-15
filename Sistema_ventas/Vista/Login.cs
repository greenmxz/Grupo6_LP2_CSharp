using System;
using System.Windows.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using Modelo;

namespace Vista {
    public partial class Login : Form {
        Usuario usuario;
        public Login() {
            InitializeComponent();
            usuario = new Usuario();
            
        }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        private void btnIngresar_Click(object sender, EventArgs e) {
            usuario.Nombre = txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;

            BindingList<string> param = new BindingList<string>();
            param.Add("user");
            param.Add("passwd");
            BindingList<string> values = new BindingList<string>();
            values.Add(usuario.Nombre);
            values.Add(usuario.Contraseña);

            int id = AdminDB.executeFunction("validarUsuario", param, values);

            if (string.ReferenceEquals(usuario.Nombre, "") || string.ReferenceEquals(usuario.Contraseña, "") || id == 0)
            {
                MessageBox.Show("El usuario y/o la contraseña ingresadas no son válidas", "Error en el inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBoxTemporal.Show("Ingreso correcto", "Validación de ingreso", 3, true);
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
