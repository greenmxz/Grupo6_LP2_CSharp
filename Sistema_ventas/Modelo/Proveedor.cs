using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Proveedor
    {
        private static int _id=0;
        private int _ruc;
        private string _razSoc;
        private string _telef;
        private string _dirCorreo;
        private string _direccion;
        private string _distrito;

        public static int Id { get => _id; set => _id = value; }
        public int Ruc { get => _ruc; set => _ruc = value; }
        public string RazSoc { get => _razSoc; set => _razSoc = value; }
        public string Telef { get => _telef; set => _telef = value; }
        public string DirCorreo { get => _dirCorreo; set => _dirCorreo = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Distrito { get => _distrito; set => _distrito = value; }
    }

}
