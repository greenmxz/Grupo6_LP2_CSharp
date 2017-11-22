namespace Modelo
{
    public class Producto
    {
        private int _id ;
        private string _nombre;
        private string _descripcion;
        private double _precio;
        private double _peso;
        private int _stock;
        public Producto()
        {

        }
        public Producto(int id, string nombre, string descripcion, double precio, double peso, int stock)
        {
            _id = id;
            _nombre = nombre;
            _precio = precio;
            _peso = peso;
            _descripcion = descripcion;
            _stock = stock;
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Id { get => _id; set => _id = value; }
        public double Peso { get => _peso; set => _peso = value; }
        public int Stock { get => _stock; set => _stock = value; }
    }
}
