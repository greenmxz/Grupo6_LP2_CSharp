using System;
using System.Windows.Forms;
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
        //public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        //public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        private void btnIngresar_Click(object sender, EventArgs e) {
            usuario.Nombre = txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;
            ConexionVista.conectar();
            MySqlCommand cmdCons = new MySqlCommand();
            ConexionVista.cast(cmdCons);
            cmdCons.CommandText = "validarUsuario";
            cmdCons.CommandType = System.Data.CommandType.StoredProcedure;

            //cmdCons.Parameters.AddWithValue("user", usuario.Nombre);
            //cmdCons.Parameters.AddWithValue("passwd", usuario.Contraseña);
            //cmdCons.Parameters.Add(new MySqlParameter(user));
            cmdCons.Parameters["eval"].Direction = System.Data.ParameterDirection.Output;
            cmdCons.ExecuteNonQuery();
            int id = Convert.ToInt32(cmdCons.Parameters["id"].Value.ToString());
            ConexionVista.cerrar();
            if (string.ReferenceEquals(usuario.Nombre, "") || string.ReferenceEquals(usuario.Contraseña, "") || id == 0)
            {
                MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                usuario.Nombre = txtUsuario.Text;
                this.DialogResult = DialogResult.OK;
                usuario.Nombre = txtUsuario.Text;
                usuario.Contraseña = txtContraseña.Text;
                if (string.ReferenceEquals(usuario.Nombre, "") || string.ReferenceEquals(usuario.Contraseña, ""))
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBoxTemporal.Show("Ingreso correcto", "Validación de ingreso", 3, true);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
