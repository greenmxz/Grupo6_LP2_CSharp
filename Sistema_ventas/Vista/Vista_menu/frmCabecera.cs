using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Modelo;

namespace Vista.Vista_menu {
    public partial class frmCabecera : Form {
        private Usuario usuario;
        private bool abierto=false;
        private frmMenuInicioAdm menuInicioAdm;
        private frmMenuInicioVentas menuInicioVentas;

        public bool Abierto { get => abierto; set => abierto = value; }
        public frmMenuInicioVentas MenuInicioVentas { get => menuInicioVentas; set => menuInicioVentas = value; }
        public frmMenuInicioAdm MenuInicioAdm { get => menuInicioAdm; set => menuInicioAdm = value; }
        public frmCabecera(Usuario user) {
            InitializeComponent();
            lblNombreUsuario.Text = user.Paterno.ToUpper() + " " + user.Materno.ToUpper()[0] + " " + user.Nombre.ToUpper();
            ConexionVista.conectar();

            MySqlCommand cmdCons = new MySqlCommand();
            cmdCons.CommandText = "obtener_tipoUsuario";
            cmdCons.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlParameter parameter = new MySqlParameter();
            parameter.Value = user.Tipo;
            parameter.Direction = System.Data.ParameterDirection.Input;
            parameter.ParameterName = "idTipo";
            cmdCons.Parameters.Add(parameter);

            MySqlParameter resp = new MySqlParameter();
            resp.Direction = System.Data.ParameterDirection.ReturnValue;
            cmdCons.Parameters.Add(resp);
            ConexionVista.cast(cmdCons);

            cmdCons.ExecuteNonQuery();
            string tipoDef = Convert.ToString(resp.Value);
            lblPerfil.Text = tipoDef;
            ConexionVista.cerrar();

            usuario = user;

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
                if (usuario.Tipo == 2 || usuario.Tipo == 4) {
                    MenuInicioAdm = new frmMenuInicioAdm((frmCabecera)this, usuario);
                    MenuInicioAdm.MdiParent = this.ParentForm;
                    MenuInicioAdm.Show();
                    Abierto = true;
                }
                else {
                    MenuInicioVentas= new frmMenuInicioVentas((frmCabecera)this, usuario);
                    MenuInicioVentas.MdiParent = this.ParentForm;
                    MenuInicioVentas.Show();
                    Abierto = true;
                }
            }
            else {
                if (usuario.Tipo == 5) {
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
