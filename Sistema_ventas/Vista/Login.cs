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
            string nombUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            BindingList<string> param = new BindingList<string>();
            param.Add("user");
            param.Add("passwd");
            BindingList<string> values = new BindingList<string>();
            values.Add(nombUsuario);
            values.Add(contraseña);

            int id = AdminDB.executeFunction("validarUsuario", param, values);

            if (ReferenceEquals(nombUsuario, "") || ReferenceEquals(contraseña, "") || id == 0)
            {
                if (ReferenceEquals(nombUsuario, ""))
                {
                    MessageBox.Show("Ingrese un nombre de usuario", "Error en el inicio de sesión",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ReferenceEquals(contraseña, ""))
                {
                    MessageBox.Show("Ingrese una contraseña", "Error en el inicio de sesión",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El usuario y/o la contraseña ingresadas no son válidas", "Error en el inicio de sesión",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ConexionVista.conectar();
                MySqlCommand cmdCons = new MySqlCommand();
                cmdCons.CommandText = "obtenerUsuario";
                cmdCons.CommandType = System.Data.CommandType.StoredProcedure;
                MySqlParameter parameter = new MySqlParameter();
                parameter.Value = id;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.ParameterName = "_id";
                cmdCons.Parameters.Add(parameter);
                ConexionVista.cast(cmdCons);
                MySqlDataReader dr = cmdCons.ExecuteReader();
                dr.Read();
                usuario.IdUsuario = dr.GetInt32("idUsuario");
                usuario.NombrUsuario = dr.GetString("nombreUsuario");
                usuario.Nombre = dr.GetString("nombre");
                usuario.Paterno = dr.GetString("apellidoPaterno");
                usuario.Materno = dr.GetString("apellidoMaterno");
                usuario.Correo = dr.GetString("correo");
                usuario.Tipo = dr.GetInt32("idTipoUsuario");
                dr.Close();
                ConexionVista.cerrar();
                //MessageBoxTemporal.Show(usuario, "Validación de ingreso", 2, true);
                DialogResult = DialogResult.OK;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e) {
            Close();
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
