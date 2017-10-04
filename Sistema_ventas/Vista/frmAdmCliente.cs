﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public enum estado { Nuevo, Cerrado }
    public partial class frmAdmCliente : Form
    {
        private estado estado;
        private frmBusquedaCliente frmBusquedaCliente;
        public frmAdmCliente()
        {
            InitializeComponent();
            this.Estado = estado.Nuevo;
            
        }

        public estado Estado { get => estado; set => estado = value; }

        private void btnBuscarCliente_Click(object sender, EventArgs e) {
            if (frmBusquedaCliente == null || frmBusquedaCliente.Estado == estado.Cerrado)
            {


                frmBusquedaCliente = new frmBusquedaCliente();
                frmBusquedaCliente.Estado = estado.Nuevo;
                frmBusquedaCliente.MdiParent = this.MdiParent;
                frmBusquedaCliente.Visible = true;


                frmBusquedaCliente.StartPosition = FormStartPosition.Manual;
                frmBusquedaCliente.Left = 588;
                frmBusquedaCliente.Top = 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Dispose();
            this.estado = estado.Cerrado;
            if (frmBusquedaCliente != null) { frmBusquedaCliente.Dispose(); }
        }
    }
}
