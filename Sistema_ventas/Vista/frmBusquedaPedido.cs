﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace Vista
{
    public partial class frmBusquedaPedido : Form
    {
        private Pedido pedidoSelecc;
        private PedidoCL logNegPed;
        private estado _estado;
        public frmBusquedaPedido()
        {
            InitializeComponent();
            logNegPed = new PedidoCL();
            BindingList<Pedido> lista = new BindingList<Pedido>();
            lista = logNegPed.devolverLista();
            foreach (Pedido elem in lista)
            {
                dataGridView1.Rows.Add(elem.IdPedido, elem.DateReg, elem.DatoCliente.Ruc, elem.Total);
            }
            Estado = estado.Nuevo;
        }
        public Pedido PedidoSelecc { get => pedidoSelecc; set => pedidoSelecc = value; }
        public estado Estado { get => _estado; set => _estado = value; }
        private void btnCerrarBusqPedido_Click(object sender, EventArgs e)
        {
            Dispose();
            Estado = estado.Cerrado;
        }
        private void btnSelecPed_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Index;
            BindingList<Pedido> lista = new BindingList<Pedido>();
            lista = logNegPed.devolverLista();
            int i = 0;
            foreach (Pedido c in lista)
            {
                if (c.IdPedido == id)
                {
                    pedidoSelecc = c;
                    break;
                }
                i++;
            }
            DialogResult = DialogResult.OK;
            Dispose();
            Estado = estado.Cerrado;
        }
    }
}
