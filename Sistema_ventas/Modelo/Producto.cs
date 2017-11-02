namespace Modelo
{
    public class Producto
    {
        private string _nombre;
        private string _marca;
        private float _precio;
        private string _descripcion;
        private int _id;
        public Producto(string nombre, string marca, float precio, string descripcion)
        {
            Nombre = nombre;
            Marca = marca;
            Precio = precio;
            Descripcion = descripcion;
        }
        public Producto(string nombre, string marca, float precio, string descripcion, int id)
        {
            _nombre = nombre;
            _marca = marca;
            _precio = precio;
            _descripcion = descripcion;
            _id = id;
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public float Precio { get => _precio; set => _precio = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
