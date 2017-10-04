using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Vista_menu;
namespace Vista
{
    public partial class Principal : Form
    {
        
        public Principal(string nombreUsuario)
        {
            InitializeComponent();
            IsMdiContainer = true;
            //this.Size = new Size(700,350);
            //FormBorderStyle = FormBorderStyle.None;
            frmMenuInicio fMenuInicio = new frmMenuInicio(this,nombreUsuario);
        }

        
    }
}
