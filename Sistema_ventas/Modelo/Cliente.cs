namespace Modelo {
    public class Cliente {
        private int _id;
        private string _ruc;//verificar si es long int o string
        private string _razonSocial;
        private string _telefono;
        private string _correo;
        private string _direccion;
        private int _idDistrito;
        public Cliente() {
        }
        public Cliente(int i, string ruc, string razonSocial, string telefono, string correo, string direccion, int distrito) {
            Id = i;
            _ruc = ruc;
            _razonSocial = razonSocial;
            _telefono = telefono;
            _correo = correo;
            _direccion = direccion;
            _idDistrito = distrito;
        }
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Distrito { get => _idDistrito; set => _idDistrito = value; }
        public string Ruc { get => _ruc; set => _ruc = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
