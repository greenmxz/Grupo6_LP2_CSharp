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
    public partial class frmAdmCliente : Form
    {
        public frmAdmCliente(Form padre)
        {
            InitializeComponent();
            MdiParent = padre;
            Visible = true;
            
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e) {
            frmBusquedaCliente frmBusquedaCliente = new frmBusquedaCliente();
        }
    }
}
