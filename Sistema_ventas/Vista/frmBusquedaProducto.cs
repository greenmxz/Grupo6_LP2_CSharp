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
        private Producto productoSelecc;
        private ProductoCL productocl;
        private BindingList<Producto> listaproducto;
        public frmBusquedaProducto()
        {
            InitializeComponent();
            productoSelecc = new Producto();
            productocl = new ProductoCL();
            listaproducto = productocl.devolverlista();
            foreach(Producto p in listaproducto)
            {
                dgvBuscProducto.Rows.Add(p.Id, p.Nombre, p.Precio.ToString("N2"), p.Stock);
            }

        }

        public frmBusquedaProducto(string nombre)
        {
            InitializeComponent();
            productoSelecc = new Producto();
            productocl = new ProductoCL();
            listaproducto = productocl.devolverlista(nombre);
            foreach (Producto p in listaproducto)
            {
                dgvBuscProducto.Rows.Add(p.Id, p.Nombre, p.Precio.ToString("N2"), p.Stock);
            }

        }


        public estado Estado { get => _estado; set => _estado = value; }
        public Producto ProductoSelecc { get => productoSelecc; set => productoSelecc = value; }

        private void btnCerrarBusqProducto_Click(object sender, EventArgs e)
        {
            Dispose();
            Estado = estado.Cerrado;
        }
        private void btnSelecProd_Click(object sender, EventArgs e)
        {
            int id = (int)dgvBuscProducto.CurrentRow.Index;
            int i=0;
            foreach (Producto p in listaproducto)
            {
                if (i == id)
                {
                    productoSelecc = p;
                    break;
                }
                i++;
            }
            Estado = estado.Cerrado;            
            DialogResult = DialogResult.OK;
            Dispose();
        }
    }
}
