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

            //ConexionVista.conectar();
            //MySqlCommand cmdCons = new MySqlCommand();
            //ConexionVista.cast(cmdCons);
            //cmdCons.CommandText = "validarUsuario";
            //cmdCons.CommandType = System.Data.CommandType.StoredProcedure;

            //MySqlParameter user = new MySqlParameter();
            //user.Value = usuario.Nombre;
            //user.Direction = System.Data.ParameterDirection.Input;
            //user.ParameterName = "user";
            //cmdCons.Parameters.Add(user);
            //MySqlParameter passwd = new MySqlParameter();
            //passwd.Value = usuario.Contraseña;
            //passwd.Direction = System.Data.ParameterDirection.Input;
            //passwd.ParameterName = "passwd";
            //cmdCons.Parameters.Add(passwd);

            //MySqlParameter resp = new MySqlParameter();
            //resp.Direction = System.Data.ParameterDirection.ReturnValue;
            //cmdCons.Parameters.Add(resp);

            //cmdCons.ExecuteNonQuery();
            //int id = Convert.ToInt32(resp.Value.ToString());

            //ConexionVista.cerrar();
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
