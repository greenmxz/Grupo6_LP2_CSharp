using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo {
    public class Cliente {
        private static int _id=0;
        private string _ruc;//verificar si es long int o string
        private string _razonSocial;
        private string _telefono;
        private string _correo;
        private string _direccion;
        private string _distrito;

        public Cliente() {
        }
        public Cliente(string ruc, string razonSocial, string telefono, string correo, string direccion, string distrito) {
            _id = _id + 1;
            _ruc = ruc;
            _razonSocial = razonSocial;
            _telefono = telefono;
            _correo = correo;
            _direccion = direccion;
            _distrito = distrito;
        }

        
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Distrito { get => _distrito; set => _distrito = value; }
        public string Ruc { get => _ruc; set => _ruc = value; }
    }
}
