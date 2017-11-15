using System;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace Vista
{
    public partial class frmBusquedaCliente : Form
    {
        private Cliente clienteSelecc;
        private ClienteCL logNegCli;
        private estado _estado;

        public estado Estado { get => _estado; set => _estado = value; }
        public Cliente ClienteSelecc { get => clienteSelecc; set => clienteSelecc = value; }

        public frmBusquedaCliente()
        {
            InitializeComponent();
            logNegCli = new ClienteCL();
            BindingList<Cliente> lista = new BindingList<Cliente>();
            lista = logNegCli.devolverLista();
            foreach(Cliente elem in lista)
            {
                dgvBusquedaCliente.Rows.Add(elem.Id, elem.Ruc, elem.RazonSocial);
            }
            Estado = estado.Nuevo;
        }
        private void btnCerrarBusqCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Estado = estado.Cerrado;
        }
        private void btnSelecCli_Click(object sender, EventArgs e)
        {
            int id = (int) dgvBusquedaCliente.CurrentRow.Index;
            BindingList<Cliente> lista = new BindingList<Cliente>();
            lista = logNegCli.devolverLista();
            int i = 0;
            foreach (Cliente c in lista)
            {
                if(i == id)
                {
                    clienteSelecc = c;
                    break;
                }
                i++;
            }
            this.DialogResult = DialogResult.OK;
            this.Estado = estado.Cerrado;
        }
    }
}
