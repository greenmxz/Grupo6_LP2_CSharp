namespace Modelo
{
    public class Producto
    {
        private string _nombre;
        private string _marca;
        private float _precio;
        //private string _descripcion;
        private int _id;
        private double _peso;
        public Producto(string nombre, string marca, float precio, string descripcion,double peso)
        {
            _nombre = nombre;
            _marca = marca;
            _precio = precio;
            _peso = peso;
            
        }
        public Producto(string nombre, string marca, float precio, int id)
        {
            _nombre = nombre;
            _marca = marca;
            _precio = precio;
            //_descripcion = descripcion;
            _id = id;
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public float Precio { get => _precio; set => _precio = value; }
        //public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Id { get => _id; set => _id = value; }
        public double Peso { get => _peso; set => _peso = value; }
    }
}
