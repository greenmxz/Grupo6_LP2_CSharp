using System;
using System.Windows.Forms;
using System.ComponentModel;
using Controlador;
using Modelo;

namespace Vista
{

    
    public partial class frmBusquedaProducto : Form
    {
        private estado _estado;
        private Producto producto;
        private ProductoCL productocl;
        private BindingList<Producto> listaproducto;
        public frmBusquedaProducto()
        {
            InitializeComponent();
            productocl = new ProductoCL();
            listaproducto = productocl.devolverlista();
            dgvBuscProducto.DataSource = listaproducto;
        }

        public estado Estado { get => _estado; set => _estado = value; }

        private void btnCerrarBusqProducto_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
        private void btnSelecProd_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
    }
}
